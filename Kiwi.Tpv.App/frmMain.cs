using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Kiwi.Tpv.App.Forms;
using Kiwi.Tpv.App.Properties;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.App.Util.Configurations;
using Kiwi.Tpv.Database;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;
using MetroFramework;
using MetroFramework.Forms;
using Settings = Kiwi.Tpv.App.Util.Configurations.Settings;

namespace Kiwi.Tpv.App
{
    public partial class FrmMain : MetroForm
    {
        private List<Employee> _employees;
        private List<Product> _products;
        private BackgroundWorker _worker;
        private BackgroundWorker _dbBackupWorker;

        private static FrmMain _instance;
        public static FrmMain Instance { get { return _instance; } }

        public FrmMain()
        {

            InitializeComponent();
            _instance = this;
            ViewController.SetSkin(this);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            AppGlobal.MainForm = this;

            Initialize();
        
            _worker = new BackgroundWorker();
            _worker.DoWork += DoWork;
            _worker.RunWorkerCompleted += RunWorkerCompleted;

            _dbBackupWorker = new BackgroundWorker();
            _dbBackupWorker.DoWork += DbBackup_DoWork;
            _dbBackupWorker.RunWorkerCompleted += DbBackup_RunWorkerCompleted;

            SelectBar();

            DataGridViewSaleOrderDetails.DefaultCellStyle.SelectionBackColor =
                DataGridViewSaleOrderDetails.DefaultCellStyle.BackColor;
            DataGridViewSaleOrderDetails.DefaultCellStyle.SelectionForeColor =
                DataGridViewSaleOrderDetails.DefaultCellStyle.ForeColor;

            ViewController.ShowPopUpWithSpinner();
            _dbBackupWorker.RunWorkerAsync();

        }

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RefreshScreen();
            ViewController.HidePopUp();
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            PrintSaleTicket();
        }

        private void DbBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ViewController.HidePopUp();
        }

        private void DbBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            GenerateDbBackup();
        }

        #region General Events

        internal void ButtonProduct_Click(object sender, EventArgs e)
        {
            AlcoholModeTypes alcoholModeType = AlcoholModeTypes.Default;

            Product product;
            var btn = (Button) sender;

            if (ReferenceEquals(btn.Tag, "Bottle"))
            {
                ViewController.ShowPopUp();
                var frmBottle = new FrmBottle();
                frmBottle.ShowDialog();

                if (frmBottle.Bottle == null)
                {
                    ViewController.HidePopUp();
                    return;
                }
                product = frmBottle.Bottle;
             
                AddProductToSale(product, alcoholModeType);
                RefreshScreen();
                ViewController.HidePopUp();

                return;
            }

            if (ReferenceEquals(btn.Tag, "Alcohol") ||
                ReferenceEquals(btn.Tag, "Refrescos") ||
                ReferenceEquals(btn.Tag, "Cervezas") ||
                ReferenceEquals(btn.Tag, "Cafes") || 
                ReferenceEquals(btn.Tag, "Tes") || 
                ReferenceEquals(btn.Tag, "Cocktails") ||
                ReferenceEquals(btn.Tag, "Infusiones") ||
                ReferenceEquals(btn.Tag, "Vinos") ||
                ReferenceEquals(btn.Tag, "Varios"))
            {
                ProductType productType;

                if (ReferenceEquals(btn.Tag, "Cafes"))
                    productType = ProductType.Cafes;     
          
                else if (ReferenceEquals(btn.Tag, "Tes"))
                    productType = ProductType.Tes;

                else if (ReferenceEquals(btn.Tag, "Cocktails"))       
                    productType = ProductType.Cocktails;

                else if (ReferenceEquals(btn.Tag, "Alcohol"))
                    productType = ProductType.Alcohol;

                else if (ReferenceEquals(btn.Tag, "Refrescos"))
                    productType = ProductType.Refresco;

                else if (ReferenceEquals(btn.Tag, "Cervezas"))
                    productType = ProductType.Cerveza;

                else if (ReferenceEquals(btn.Tag, "Infusiones"))
                    productType = ProductType.Infusiones;

                else if (ReferenceEquals(btn.Tag, "Vinos"))
                    productType = ProductType.Vinos;

                else productType = ProductType.Varios;


                ViewController.ShowPopUp();
                var frmProductSelector = new FrmProductSelector(productType, false);
                frmProductSelector.ShowDialog();
                ViewController.HidePopUp();             
                return;
            }

            product = (Product) btn.Tag;
            product.Quantity = 1;

            if (AppGlobal.Company.CombinationControl && product.Type == ProductType.Alcohol)
            {
                ViewController.ShowPopUp();

                var frmAlcoholModeTypes = new FrmAlcoholModeTypes();
                frmAlcoholModeTypes.ShowDialog();
                alcoholModeType = frmAlcoholModeTypes.SelectedAlcoholModeType;

                if (alcoholModeType == AlcoholModeTypes.Combined)
                {
                    var frmProductSelector = new FrmProductSelector(ProductType.Refresco, true);
                    frmProductSelector.ShowDialog();
                }

                ViewController.HidePopUp();
            }
          
            AddProductToSale(product, alcoholModeType);
          
            RefreshScreen();
        }

        internal void ButtonEmployee_Click(object sender, EventArgs e)
        {
            if (AppGlobal.SaleOrder == null || AppGlobal.SaleOrder.Details.Count == 0 || AppGlobal.SaleOrder.Total == 0) return;

            var btn = (Button) sender;

            ViewController.ShowPopUp();
            var frmConfirmPay = new FrmConfirmPay((Employee)btn.Tag, AppGlobal.SaleOrder);
            frmConfirmPay.ShowDialog();
            ViewController.HidePopUp();             
            RefreshScreen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SaleOrdersController.Remove(AppGlobal.SaleOrder);
            AppGlobal.SaleOrder = new SaleOrder();
            RefreshScreen();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ViewController.ShowPopUp();
            var frmPassword = new FrmPassword();
            frmPassword.ShowDialog();

            if (frmPassword.ValidPassword)
            {
                var frmMenu = new FrmMenu();
                frmMenu.ShowDialog();
                Initialize();
            }
            ViewController.HidePopUp();
       
        }

        private void DataGridViewSelectedProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewSaleOrderDetails.CurrentRow == null) return;
            DataGridViewSaleOrderDetails.ClearSelection();
        }

        private void DataGridViewSelectedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var saleOrderDetail = new SaleOrderDetail();
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "RemoveOne")
            {
                if (DataGridViewSaleOrderDetails.CurrentRow != null)
                    saleOrderDetail = (SaleOrderDetail)DataGridViewSaleOrderDetails.CurrentRow.DataBoundItem;

                AppGlobal.SaleOrder.RemoveOneUnit(saleOrderDetail);
                RefreshScreen();
            }

            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex].Name != "AddOne") return;
            if (DataGridViewSaleOrderDetails.CurrentRow != null)
                saleOrderDetail = (SaleOrderDetail)DataGridViewSaleOrderDetails.CurrentRow.DataBoundItem;

            AppGlobal.SaleOrder.AddOneUnit(saleOrderDetail);
            RefreshScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SaveSale();
            GenerateDbBackup();
            Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    WindowState = FormWindowState.Maximized;
                    FormBorderStyle = FormBorderStyle.None;
                    break;
                case FormWindowState.Maximized:
                    WindowState = FormWindowState.Normal;
                    FormBorderStyle = FormBorderStyle.Sizable;
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timerWatch_Tick(object sender, EventArgs e)
        {

            lblDateTime.Text = DateTime.Now.ToString("F").ToUpper();

            var actualHour = DateTime.Now.Hour;

            if (AppGlobal.AppGeneralConfig.SystemJoke)
            {
                if (actualHour >= AppGlobal.AppGeneralConfig.JokeInit && actualHour < AppGlobal.AppGeneralConfig.JokeEnd)
                    AppGlobal.JokeSystemActive = true;
                else AppGlobal.JokeSystemActive = false;
            }
            else
            {
                AppGlobal.JokeSystemActive = false;
            }
          
        }

        private void SystemTimer_Tick(object sender, EventArgs e)
        {
        }

        private void btnSelectTable_Click(object sender, EventArgs e)
        {
            SelectTable();
        }

        private void btnSelectBar_Click(object sender, EventArgs e)
        {
            SelectBar();
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            if (AppGlobal.SaleOrder == null || AppGlobal.SaleOrder.Details.Count == 0 || AppGlobal.SaleOrder.Total == 0) return;
            ViewController.ShowPopUpWithSpinner();
            _worker.RunWorkerAsync();
        }

        private void picBoxLogo_Click(object sender, EventArgs e)
        {
            try
            {
                CashDrawerController.Open();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void btnDayMode_Click(object sender, EventArgs e)
        {
            lblDayNight.Text = "DÍA";
            AppGlobal.SaleMode = SaleMode.Day;
        }

        private void btnNightMode_Click(object sender, EventArgs e)
        {
            lblDayNight.Text = "NOCHE";
            AppGlobal.SaleMode = SaleMode.Night;
        }

        private void btnCommands_Click(object sender, EventArgs e)
        {
            ViewController.ShowPopUp();
            var frmCommands = new FrmCommands();
            frmCommands.ShowDialog();
            ViewController.HidePopUp();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
     
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        #endregion

        #region Private Events

        private void Initialize()
        {
            try
            {

                InitializeConfiguration();

                MainViewProductButtonsController.PaintProducts();
                MainViewEmployeeButtonsController.PaintEmployees();

                TestPrinter();

                lblDayNight.Text = "DÍA";
                AppGlobal.SaleMode = SaleMode.Day;

                if (AppGlobal.AppGeneralConfig.SystemJoke)
                    SystemTimer.Enabled = true;

                AppGlobal.SalesController = new SalesController(AppGlobal.JokeSystemActive, AppGlobal.AppGeneralConfig.JokeInterval);

                FormBorderStyle = FormBorderStyle.Sizable;
                FormBorderStyle = FormBorderStyle.None;
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }

            try
            {
                picBoxLogo.BackgroundImage = Common.BytesToImage(AppGlobal.Company.AppLogo);
                picBoxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch
            {
                // ignored
            }
        }

        private void TestPrinter()
        {
            if (RawPrinterHelper.IsPrinterConnectedAndOnline(AppGlobal.Station.PrintterComPort))
            {
                lblComPortStatus.Text = Resources.CajaConectada.ToUpper();
                lblComPortStatus.Style = MetroColorStyle.Green;
            }
            else
            {
                lblComPortStatus.Text = Resources.CajaDesconectada.ToUpper();
                lblComPortStatus.Style = MetroColorStyle.Red;
            }
        }

        private void InitializeConfiguration()
        {
            try
            {
                GlobalConfigurationRepository.Read();
                GlobalDb.ConnectionString = Settings.ConnectionString;

                if (!GlobalDb.TestConnection())
                {
                    ViewController.ShowError(Resources.ErrorConexionBD);
                    Close();
                }

                AppGlobal.Station = StationController.GetByCode(Convert.ToInt16(Settings.StationCode));

                if (AppGlobal.Station.Id == 0)
                {
                    ViewController.ShowError(Resources.EstacionNoExiste);
                    Close();
                }

                lblStation.Text = AppGlobal.Station.Name.ToUpper();
                AppGlobal.AppGeneralConfig = AppCommonController.Get();

                AppGlobal.Company = CompanyController.GetById(new Company {CompanyId = 1});
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }

            try
            {
                BackgroundImage = Image.FromFile(AppGlobal.AppGeneralConfig.BackgroundImage);
                BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void AddProductToSale(Product selectedProduct, AlcoholModeTypes alcoholModeType)
        {

            if (AppGlobal.SaleOrder == null)
            {
                AppGlobal.SaleOrder = new SaleOrder();
            }
          
        
            AppGlobal.SaleOrder.Table = AppGlobal.Table;
            AppGlobal.SaleOrder.Station = AppGlobal.Station;
            AppGlobal.SaleOrder.Add(selectedProduct, AppGlobal.SaleMode, alcoholModeType);    
        }

        public void RefreshScreen()
        {
            try
            {
                RefreshSaleDetails();
                RefreshScreenInfo();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void RefreshSaleDetails()
        {
            DataGridViewSaleOrderDetails.DataSource = null;
            if (AppGlobal.SaleOrder != null && AppGlobal.SaleOrder.Details.Count != 0)
            {
                DataGridViewSaleOrderDetails.DataSource = AppGlobal.SaleOrder.Details;
                DataGridViewSaleOrderDetails.ClearSelection();

                foreach (var column in DataGridViewSaleOrderDetails.Columns)
                {
                    if (column is DataGridViewImageColumn)
                        (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
                }
            }
        }

        private void RefreshScreenInfo()
        {
            txtTotalAmount.Text = AppGlobal.SaleOrder.Total.ToString("F") + Resources.Euro;
        }

        private void SelectTable()
        {

            ViewController.ShowPopUp();

            try
            {
                SaveSale();

                var frmTablesDistribution = new FrmTablesDistribution(FrmTablesDistribution.WindowMode.SaleSelection);
                frmTablesDistribution.ShowDialog();

                if (frmTablesDistribution.SelectedTable != null)
                {
                    btnSelectBar.Enabled = true;
                    AppGlobal.Table = frmTablesDistribution.SelectedTable;
                    lblTableBar.Text = AppGlobal.Table.Name.ToUpper();               
                }

                RefreshScreen();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }

            ViewController.HidePopUp();
        }

        private void SelectBar()
        {
            try
            {
                btnSelectBar.Enabled = false;
                SaveSale();
                AppGlobal.Table = null;
                lblTableBar.Text = "EN BARRA";
                AppGlobal.SaleOrder = SaleOrdersController.GetPendingByStationAndBar(AppGlobal.Station);
                RefreshScreen();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void SaveSale()
        {
            try
            {
                if (AppGlobal.SaleOrder == null || (AppGlobal.SaleOrder.Details.Count == 0 && AppGlobal.SaleOrder.Id == 0)) return;

                SaleOrdersController.SaveOrUpdate(AppGlobal.SaleOrder);
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void PrintSaleTicket()
        {
            try
            {
                SaveSale();
                PrinterController.PrintSaleOrder(AppGlobal.SaleOrder);
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void GenerateDbBackup()
        {
            try
            {
                if (AppGlobal.AppGeneralConfig.ServerStation != null)
                {
                    if (AppGlobal.AppGeneralConfig.ServerStation.Id == AppGlobal.Station.Id)
                    {
                        if (string.IsNullOrEmpty(AppGlobal.AppGeneralConfig.DbBackupFilePath) ||
                            !Directory.Exists(AppGlobal.AppGeneralConfig.DbBackupFilePath))
                        {
                            ViewController.ShowWarning(
                                "No existe configuración del sistema de copia de seguridad o la ruta configurada no es accesible.");
                            return;
                        }

                        var builder = new System.Data.SqlClient.SqlConnectionStringBuilder(GlobalDb.ConnectionString);

                        var dbBackupFile = AppGlobal.AppGeneralConfig.DbBackupFilePath + "\\" + builder.InitialCatalog + "_Backup.bak";
                        if (File.Exists(dbBackupFile))
                        {
                            File.Delete(dbBackupFile);
                        }

                        var strSQL =
                            @"DECLARE @BackupLocation NVARCHAR(2000) = '" + dbBackupFile + "'" +
                            " BACKUP DATABASE " + builder.InitialCatalog + 
                            " TO DISK = @BackupLocation; ";

                        DbManagementRepository.ExecuteSql(strSQL);
                    }
                }
                else
                {
                    ViewController.ShowWarning(
                        "No se ha configurado el punto de venta servidor.");
                }
            }     
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }


        #endregion

        private void FrmMain_Shown(object sender, EventArgs e)
        {

        }
    }
}