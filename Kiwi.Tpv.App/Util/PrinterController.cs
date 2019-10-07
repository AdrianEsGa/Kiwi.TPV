using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using Kiwi.Tpv.App.Forms;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories.Reports;
using Microsoft.Reporting.WinForms;

namespace Kiwi.Tpv.App.Util
{
    public static class PrinterController
    {


        public static void PrintSale(Sale saleToPrint)
        {
            try
            {
                var saleDetails = ReportRepository.GetSaleById(saleToPrint.Id);
                var reportViewer = new FrmReportViewer();
                var report = reportViewer.reportViewer.LocalReport;
                report.ReportPath = AppGlobal.Company.TicketReport;
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource
                {
                    Name = "SaleDetails",
                    Value = saleDetails
                });

                report.DataSources.Add(new ReportDataSource
                {
                    Name = "Company",
                    Value = new List<Company> { AppGlobal.Company }
                });

                PrintReport(report);
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private static void PrintReport(LocalReport report)
        {
            var pageSettings = new PageSettings
            {
                PaperSize = report.GetDefaultPageSettings().PaperSize,
                Landscape = report.GetDefaultPageSettings().IsLandscape,
                Margins = report.GetDefaultPageSettings().Margins
            };

            string deviceInfo =
                @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>{pageSettings.PaperSize.Width * 100}in</PageWidth>
                <PageHeight>{pageSettings.PaperSize.Height * 100}in</PageHeight>
                <MarginTop>{pageSettings.Margins.Top * 100}in</MarginTop>
                <MarginLeft>{pageSettings.Margins.Left * 100}in</MarginLeft>
                <MarginRight>{pageSettings.Margins.Right * 100}in</MarginRight>
                <MarginBottom>{pageSettings.Margins.Bottom * 100}in</MarginBottom>
            </DeviceInfo>";

            Warning[] warnings;
            var streams = new List<Stream>();
            var currentPageIndex = 0;

            report.Render("Image", deviceInfo,
                (name, fileNameExtension, encoding, mimeType, willSeek) =>
                {
                    var stream = new MemoryStream();
                    streams.Add(stream);
                    return stream;
                }, out warnings);

            foreach (Stream stream in streams)
                stream.Position = 0;

            if (streams == null || streams.Count == 0)
                throw new Exception("Error: no stream to print.");

            var printDocument = new PrintDocument();
            printDocument.DefaultPageSettings = pageSettings;
            if (!printDocument.PrinterSettings.IsValid)
                throw new Exception("Error: cannot find the default printer.");
            else
            {
                printDocument.PrintPage += (sender, e) =>
                {
                    Metafile pageImage = new Metafile(streams[currentPageIndex]);
                    Rectangle adjustedRect = new Rectangle(
                        e.PageBounds.Left - (int)e.PageSettings.HardMarginX,
                        e.PageBounds.Top - (int)e.PageSettings.HardMarginY,
                        e.PageBounds.Width,
                        e.PageBounds.Height);
                    e.Graphics.FillRectangle(Brushes.White, adjustedRect);
                    e.Graphics.DrawImage(pageImage, adjustedRect);
                    currentPageIndex++;
                    e.HasMorePages = (currentPageIndex < streams.Count);
                    e.Graphics.DrawRectangle(Pens.Red, adjustedRect);
                };
                printDocument.EndPrint += (Sender, e) =>
                {
                    if (streams != null)
                    {
                        foreach (Stream stream in streams)
                            stream.Close();
                        streams = null;
                    }
                };
                printDocument.Print();
            }
        }
    }
}
