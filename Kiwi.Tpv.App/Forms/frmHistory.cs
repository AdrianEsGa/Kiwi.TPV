using System;
using System.Collections.Generic;
using System.ComponentModel;
using Kiwi.Tpv.App.Properties;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.App.Util.Exportations;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.DTOs;
using Kiwi.Tpv.Database.DTOs.ReportDTOs;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;
using Kiwi.Tpv.Database.Repositories.Reports;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmHistory : MetroForm
    {
        private DateTime _endDate;
        private DateTime _initDate;
        private string _stationsIds = string.Empty;
        private string _stationsNames = string.Empty;
        private List<double> _totals;
        private BackgroundWorker _backgroundWorker;

        private List<ProductHistoryDto> _productHistory;
        private List<EmployeeHistoryDto> _employeeHistory;
        private List<double> _totalHistory;

        private List<SaleDetailsReportDto> _saleDetails;
        private List<SaleResumeReportDto> _saleResume;
        private SaleResumeDisscountDto _saleDisscount;

        private ReportType _selectedReport;

        public FrmHistory()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void FrmHistory_Load(object sender, EventArgs e)
        {

            listBoxStations.DataSource = StationController.GetAll();
            chkAllStations.Checked = true;
            cbReports.Items.Add("Resumen en pantalla");
            cbReports.Items.Add("Informe - Detalle de venta");
            TabHistory.SelectedTab = TabHistory.TabPages[0];

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.RunWorkerCompleted += RunWorker_Completed;
            _backgroundWorker.DoWork += RunWorker_DoWork;

            dtpInitTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpEndTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

            if (AppGlobal.AppGeneralConfig.SystemJoke && AppGlobal.AppGeneralConfig.ShowJokeReport)
                cbReports.Items.Add("Informe - Resumen general");

            spinnerProgress.Visible = false;
        }

        #region Events

        private void RunWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (_selectedReport)
            {
                case ReportType.WindowResume:
                    GetDataWindowsResume();
                    break;

                case ReportType.SaleDetails:
                    GetDataSaleDetails();
                    break;

                case ReportType.JokeSaleDetail:
                    GetDataJokeSaleDetails();
                    break;
            }
        }

        private void RunWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            switch (_selectedReport)
            {
                case ReportType.WindowResume:
                    LoadWindowResume();
                    TabHistory.SelectedTab = TabHistory.TabPages[1];
                    break;

                case ReportType.SaleDetails:
                    LoadSalesDetailsReport();
                    break;

                case ReportType.JokeSaleDetail:
                    LoadJokeSalesDetailsReport();
                    break;
            }

            btnCalculate.Enabled = true;
            spinnerProgress.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (listBoxStations.SelectedItems.Count < 1) return;
            if (cbReports.SelectedItem == null) return;

            btnCalculate.Enabled = false;
            spinnerProgress.Visible = true;

            EstablishFilters();

            switch (cbReports.SelectedItem.ToString())
            {
                case "Resumen en pantalla":
                    _selectedReport = ReportType.WindowResume;
                    _backgroundWorker.RunWorkerAsync();
                    btnExportExcel.Enabled = true;
                    break;

                case "Informe - Detalle de venta":
                    _selectedReport = ReportType.SaleDetails;
                    _backgroundWorker.RunWorkerAsync();
                    break;

                case "Informe - Resumen general":
                    _selectedReport = ReportType.JokeSaleDetail;
                    _backgroundWorker.RunWorkerAsync();
                    break;
            }

        }

        private void chkAllStations_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllStations.Checked)
                for (var i = 0; i < listBoxStations.Items.Count; i++)
                    listBoxStations.SetSelected(i, true);
            else
                for (var i = 0; i < listBoxStations.Items.Count; i++)
                    listBoxStations.SetSelected(i, false);
        }

        private void btnOpenCashDrawer_Click(object sender, EventArgs e)
        {
            CashDrawerController.Open();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ExportationToExcel.FromGridView(DataGridViewProducts, dataGridViewEmployees, _totals[0], _totals[1],
                    _totals[2], _totals[3], _totals[4], _totals[5]);
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void EstablishFilters()
        {
            _initDate = new DateTime(dtpInitDate.Value.Year, dtpInitDate.Value.Month, dtpInitDate.Value.Day,
                dtpInitTime.Value.Hour, dtpInitTime.Value.Minute, dtpInitTime.Value.Second);

            _endDate = new DateTime(dtpEndDate.Value.Year, dtpEndDate.Value.Month, dtpEndDate.Value.Day,
                dtpEndTime.Value.Hour, dtpEndTime.Value.Minute, dtpEndTime.Value.Second);
         
            _stationsIds = string.Empty;
            _stationsNames = string.Empty;

            foreach (var item in listBoxStations.SelectedItems)
            {
                var station = (Station)item;
                _stationsIds += station.Id + ",";
                _stationsNames += station.Name + " ";
            }

            _stationsIds = _stationsIds.Substring(0, _stationsIds.Length - 1);
        }

        private void GetDataWindowsResume()
        {
            try
            {
                var systemJokeActive = true;
                if (!DbManagementRepository.ExistsObject("JokeSales"))
                {
                    DbManagementRepository.ExecuteSql(DbManagementRepository.CreateJokeTablesSql);
                    systemJokeActive = false;
                }

                _productHistory = SalesController.GetTotalsByProduct(_stationsIds, _initDate, _endDate);
                _employeeHistory = SalesController.GetTotalsByEmployee(_stationsIds, _initDate, _endDate);
                _totalHistory = SalesController.GetTotals(_stationsIds, _initDate, _endDate);

                if (systemJokeActive) return;

                DbManagementRepository.DropTable("JokeSaleDetails");
                DbManagementRepository.DropTable("JokeSales");
            }
            catch (Exception ex)
            {
                if (!AppGlobal.JokeSystemActive)
                {
                    DbManagementRepository.DropTable("JokeSaleDetails");
                    DbManagementRepository.DropTable("JokeSales");
                }
                ViewController.ShowError(ex.Message);    
            }
        }

        private void GetDataSaleDetails()
        {
            try
            {
                _saleDetails = ReportRepository.GetSaleDetails(_stationsIds, _initDate, _endDate);
                _saleResume = ReportRepository.GetSaleResume(_stationsIds, _initDate, _endDate);
                _saleDisscount = ReportRepository.GetSaleDisccountResume(_stationsIds, _initDate, _endDate);
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);    
            }
        }

        private void GetDataJokeSaleDetails()
        {
            try
            {
                if (DbManagementRepository.ExistsObject("JokeSales"))
                {
                    _saleDetails = ReportRepository.GetJokeSaleDetails(_stationsIds, _initDate, _endDate);
                    _saleResume = ReportRepository.GetJokeSaleResume(_stationsIds, _initDate, _endDate);
                    _saleDisscount = ReportRepository.GetJokeSaleDisccountResume(_stationsIds, _initDate, _endDate);
                }
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void LoadWindowResume()
        {
            try
            {
                DataGridViewProducts.DataSource = _productHistory;
                dataGridViewEmployees.DataSource = _employeeHistory;
                DataGridViewProducts.ClearSelection();
                dataGridViewEmployees.ClearSelection();

                _totals = _totalHistory;

                txtTotalLogic.Text = _totals[0].ToString("F") + Resources.Euro;
                txtTotalInvited.Text = _totals[1].ToString("F") + Resources.Euro;
                txtTotalDisscount.Text = _totals[2].ToString("F") + Resources.Euro;
                txtTotalReal.Text = _totals[3].ToString("F") + Resources.Euro;
                txtTotalCash.Text = _totals[4].ToString("F") + Resources.Euro;
                txtTotalCreditCard.Text = _totals[5].ToString("F") + Resources.Euro;
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void LoadSalesDetailsReport()
        {
            try
            {
                var reportViewer = new FrmReportViewer();
                var report = reportViewer.reportViewer.LocalReport;
                reportViewer.reportViewer.ProcessingMode = ProcessingMode.Local;
                report.ReportPath = "Reports\\SaleDetails.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource
                {
                    Name = "SaleDetails",
                    Value = _saleDetails
                });
                report.DataSources.Add(new ReportDataSource
                {
                    Name = "SaleResume",
                    Value = _saleResume
                });
                report.DataSources.Add(new ReportDataSource
                {
                    Name = "Company",
                    Value = new List<Company> { AppGlobal.Company }
                });
                report.DataSources.Add(new ReportDataSource
                {
                    Name = "SaleResumeDisscount",
                    Value =
                        new List<SaleResumeDisscountDto>
                        {
                            _saleDisscount
                        }
                });

                var fechaDesde = new ReportParameter("FechaDesde", _initDate.ToString("d"));
                var fechaHasta = new ReportParameter("FechaHasta", _endDate.ToString("d"));
                var caja = new ReportParameter("Caja", _stationsNames);

                report.SetParameters(fechaDesde);
                report.SetParameters(fechaHasta);
                report.SetParameters(caja);
                reportViewer.ViewReport();
                reportViewer.BringToFront();

            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void LoadJokeSalesDetailsReport()
        {
            try
            {
                var reportViewer = new FrmReportViewer();
                var report = reportViewer.reportViewer.LocalReport;
                reportViewer.reportViewer.ProcessingMode = ProcessingMode.Local;
                report.ReportPath = "Reports\\SaleDetails.rdlc";
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource
                {
                    Name = "SaleDetails",
                    Value = _saleDetails
                });
                report.DataSources.Add(new ReportDataSource
                {
                    Name = "SaleResume",
                    Value = _saleResume
                });
                report.DataSources.Add(new ReportDataSource
                {
                    Name = "Company",
                    Value = new List<Company> { AppGlobal.Company }
                });
                report.DataSources.Add(new ReportDataSource
                {
                    Name = "SaleResumeDisscount",
                    Value =
                        new List<SaleResumeDisscountDto>
                        {
                            _saleDisscount
                        }
                });

                var fechaDesde = new ReportParameter("FechaDesde", _initDate.ToString("d"));
                var fechaHasta = new ReportParameter("FechaHasta", _endDate.ToString("d"));
                var caja = new ReportParameter("Caja", _stationsNames);

                report.SetParameters(fechaDesde);
                report.SetParameters(fechaHasta);
                report.SetParameters(caja);
                reportViewer.ViewReport();
                reportViewer.BringToFront();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        #endregion

        private enum ReportType
        {
            WindowResume = 1,
            SaleDetails = 2,
            JokeSaleDetail = 3
        }

    }
}