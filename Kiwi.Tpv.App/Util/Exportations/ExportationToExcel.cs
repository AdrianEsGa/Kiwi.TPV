using System;
using System.Windows.Forms;
using Kiwi.Tpv.App.Properties;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Kiwi.Tpv.App.Util.Exportations
{
    public static class ExportationToExcel
    {
        public static void FromGridView(DataGridView gridProducts, DataGridView gridEmployees, double logica,
            double invitado, double descuentos, double real, double cash, double creditCard)
        {

            _Application excel = new Application();
            _Workbook workbook = excel.Workbooks.Add(Type.Missing);

            try
            {
                _Worksheet worksheet = workbook.ActiveSheet;
                worksheet.Name = "Totales";

                worksheet.Cells[1, 1] = "Facturación lógica";
                worksheet.Cells[1, 2] = "Invitado";
                worksheet.Cells[1, 3] = "Descuentos";
                worksheet.Cells[1, 4] = "Facturación real";
                worksheet.Cells[1, 5] = "Facturación efectivo";
                worksheet.Cells[1, 6] = "Facturación tarjeta";
                worksheet.Cells[2, 1] = logica;
                worksheet.Cells[2, 2] = invitado;
                worksheet.Cells[2, 3] = descuentos;
                worksheet.Cells[2, 4] = real;
                worksheet.Cells[2, 5] = cash;
                worksheet.Cells[2, 6] = creditCard;


                worksheet = workbook.Worksheets.Add();
                worksheet.Name = "Por empleados";

                var cellRowIndex = 1;
                var cellColumnIndex = 1;

                for (var j = 0; j < gridEmployees.Columns.Count; j++)
                {
                    worksheet.Cells[cellRowIndex, cellColumnIndex] = gridEmployees.Columns[j].HeaderText;
                    cellColumnIndex++;
                }

                cellRowIndex = 2;
                cellColumnIndex = 1;

                for (var i = 0; i < gridEmployees.Rows.Count; i++)
                {
                    for (var j = 0; j < gridEmployees.Columns.Count; j++)
                    {
                        if (cellRowIndex == 0)
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = gridEmployees.Columns[j].HeaderText;
                        else
                            worksheet.Cells[cellRowIndex, cellColumnIndex] =
                                gridEmployees.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }


                worksheet = workbook.Worksheets.Add();
                worksheet.Name = "Por productos";

                cellRowIndex = 1;
                cellColumnIndex = 1;

                for (var j = 0; j < gridProducts.Columns.Count; j++)
                {
                    worksheet.Cells[cellRowIndex, cellColumnIndex] = gridProducts.Columns[j].HeaderText;
                    cellColumnIndex++;
                }

                cellRowIndex = 2;
                cellColumnIndex = 1;

                for (var i = 0; i < gridProducts.Rows.Count; i++)
                {
                    for (var j = 0; j < gridProducts.Columns.Count; j++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = gridProducts.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                var saveDialog = new SaveFileDialog
                {
                    Filter = Resources.ExcelExtensionFilter,
                    FilterIndex = 2
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    ViewController.ShowAsterisk(Resources.ExportacionExcelCorrecta);
                }
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
            finally
            {
                excel.Quit();
            }
        }
    }
}