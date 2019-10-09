using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Kiwi.Tpv.App.Forms;
using Kiwi.Tpv.App.Properties;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.App.Util.Configurations;
using Kiwi.Tpv.Database;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Settings = Kiwi.Tpv.App.Util.Configurations.Settings;

namespace Kiwi.Tpv.App
{
    public partial class FrmMain : MetroForm
    {
        private List<Employee> _employees;
        private List<Product> _products;
        private BackgroundWorker _worker;

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
            Initialize();
            AppGlobal.MainForm = this;
            _worker = new BackgroundWorker();
            _worker.DoWork += DoWork;
            _worker.RunWorkerCompleted += RunWorkerCompleted;
            SelectBar();
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

        private void Initialize()
        {
            try
            {
                flowLayoutPanelAlcohol.AutoScroll = false;
                flowLayoutPanelAlcohol.AutoSize = true;
                flowLayoutPanelAlcohol.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                flowLayoutPanelSoda.AutoScroll = false;
                flowLayoutPanelSoda.AutoSize = true;
                flowLayoutPanelSoda.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                flowLayoutPanelCafes.AutoScroll = false;
                flowLayoutPanelCafes.AutoSize = true;
                flowLayoutPanelCafes.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                flowLayoutPanelVarious.AutoScroll = false;
                flowLayoutPanelVarious.AutoSize = true;
                flowLayoutPanelVarious.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                flowLayoutPanelEmployees.AutoScroll = false;
                flowLayoutPanelEmployees.AutoSize = true;
                flowLayoutPanelEmployees.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                InitializeConfiguration();
                PaintProducts();
                PaintEmployees();
                TestPrinter();

                lblDayNight.Text = "Día";
                AppGlobal.SaleMode = SaleMode.Day;

                if (AppGlobal.AppGeneralConfig.SystemJoke)
                    SystemTimer.Enabled = true;
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

        #region General Events

        private void ButtonProduct_Click(object sender, EventArgs e)
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

                var frmAlcoholModeTypes = new frmAlcoholModeTypes();
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

        private void ButtonEmployee_Click(object sender, EventArgs e)
        {
            if (AppGlobal.Sale == null || AppGlobal.Sale.Details.Count == 0 || AppGlobal.Sale.TotalPriceDetails() == 0) return;

            var btn = (Button) sender;
            AppGlobal.Sale.Employee = (Employee) btn.Tag;

            ViewController.ShowPopUp();
            var frmConfirmPay = new FrmConfirmPay(false);
            frmConfirmPay.ShowDialog();
            ViewController.HidePopUp();

            if (!frmConfirmPay.OperationFinalized) return;
              FinalizeSale();

            RefreshScreen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FinalizeSale();
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
            if (DataGridViewSelectedProducts.CurrentRow == null) return;
            DataGridViewSelectedProducts.ClearSelection();
        }

        private void DataGridViewSelectedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var saleDetail = new SaleDetail();
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "RemoveOne")
            {
                if (DataGridViewSelectedProducts.CurrentRow != null)
                    saleDetail = (SaleDetail)DataGridViewSelectedProducts.CurrentRow.DataBoundItem;

                AppGlobal.Sale.RemoveOneUnit(saleDetail);
                RefreshScreen();
            }

            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex].Name != "AddOne") return;
            if (DataGridViewSelectedProducts.CurrentRow != null)
                saleDetail = (SaleDetail)DataGridViewSelectedProducts.CurrentRow.DataBoundItem;

            AppGlobal.Sale.AddOneUnit(saleDetail);
            RefreshScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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

            if (actualHour >= AppGlobal.AppGeneralConfig.JokeInit && actualHour < AppGlobal.AppGeneralConfig.JokeEnd)
                AppGlobal.JokeSystemActive = true;
            else AppGlobal.JokeSystemActive = false;
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
            if (AppGlobal.Sale == null || AppGlobal.Sale.Details.Count == 0 || AppGlobal.Sale.TotalPriceDetails() == 0) return;
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
            lblDayNight.Text = "Día";
            AppGlobal.SaleMode = SaleMode.Day;
        }

        private void btnNightMode_Click(object sender, EventArgs e)
        {
            lblDayNight.Text = "Noche";
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
                SaveSale();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        #endregion

        #region Private Events

        #region Paint Methods

        private void PaintProducts()
        {
            try
            {
                flowLayoutPanelAlcohol.Controls.Clear();
                flowLayoutPanelSoda.Controls.Clear();
                flowLayoutPanelCafes.Controls.Clear();
                flowLayoutPanelVarious.Controls.Clear();

                _products = ProductController.GetAllActive();

                foreach (var product in _products)
                {
                    if (product.Image != null)
                    {
                        PaintProductTiles(product);
                    }
                    else
                    {
                        PaintProductButtons(product);
                    }
                }

                PaintProductBottleTile();
                PaintProductExtraTiles();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void PaintProductTiles(Product product)
        {
            var btn = new MetroButton
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = product,
                BackgroundImage = Common.BytesToImage(product.Image),
                BackgroundImageLayout = ImageLayout.Stretch
            };

            btn.Click += ButtonProduct_Click;

            switch (product.Type)
            {
                case ProductType.Alcohol:
                    flowLayoutPanelAlcohol.Controls.Add(btn);
                    break;
                case ProductType.Refresco:
                    flowLayoutPanelSoda.Controls.Add(btn);
                    break;
                case ProductType.Cerveza:
                    flowLayoutPanelSoda.Controls.Add(btn);
                    break;
                case ProductType.Cafes:
                    flowLayoutPanelCafes.Controls.Add(btn);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void PaintProductButtons(Product product)
        {
            var btn = new MetroTile
            {
                Width = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                Text = product.Name,
                Tag = product,
                TileTextFontWeight = MetroTileTextWeight.Regular,
                TileTextFontSize = MetroTileTextSize.Small,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btn.Click += ButtonProduct_Click;

            switch (product.Type)
            {
                case ProductType.Alcohol:
                    flowLayoutPanelAlcohol.Controls.Add(btn);
                    break;
                case ProductType.Refresco:
                    flowLayoutPanelSoda.Controls.Add(btn);
                    break;
                case ProductType.Cerveza:
                    flowLayoutPanelSoda.Controls.Add(btn);
                    break;
                case ProductType.Cafes:
                    flowLayoutPanelCafes.Controls.Add(btn);
                    break;
            }
        }

        private void PaintProductBottleTile()
        {
            //Create button botella
            var btnBottle = new MetroTile()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Bottle",
                Text = Resources.Botella,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btnBottle.Click += ButtonProduct_Click;

            flowLayoutPanelAlcohol.Controls.Add(btnBottle);
        }

        private void PaintProductExtraTiles()
        {
            //Create button Alcohol
            var btnAlcohol = new MetroTile()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Alcohol",
                Text = "Alcohol",
                TileTextFontWeight = MetroTileTextWeight.Regular,
                TileTextFontSize = MetroTileTextSize.Small,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btnAlcohol.Click += ButtonProduct_Click;

            flowLayoutPanelVarious.Controls.Add(btnAlcohol);

            //Create button Refrescos
            var btnRefrescos = new MetroTile()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Refrescos",
                Text = "Refrescos",
                TileTextFontWeight = MetroTileTextWeight.Regular,
                TileTextFontSize = MetroTileTextSize.Small,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btnRefrescos.Click += ButtonProduct_Click;

            flowLayoutPanelVarious.Controls.Add(btnRefrescos);

            //Create button Cervezas
            var btnCervezas = new MetroTile()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Cervezas",
                Text = "Cervezas",
                TileTextFontWeight = MetroTileTextWeight.Regular,
                TileTextFontSize = MetroTileTextSize.Small,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btnCervezas.Click += ButtonProduct_Click;

            flowLayoutPanelVarious.Controls.Add(btnCervezas);

            //Create button Cafes
            var btnCafes = new MetroTile()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Cafes",
                Text = "Cafés",
                TileTextFontWeight = MetroTileTextWeight.Regular,
                TileTextFontSize = MetroTileTextSize.Small,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btnCafes.Click += ButtonProduct_Click;

            flowLayoutPanelVarious.Controls.Add(btnCafes);

            //Create button Tes
            var btnTes = new MetroTile()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Tes",
                Text = "Tés",
                TileTextFontWeight = MetroTileTextWeight.Regular,
                TileTextFontSize = MetroTileTextSize.Small,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btnTes.Click += ButtonProduct_Click;

            flowLayoutPanelVarious.Controls.Add(btnTes);

            //Create button Cocktails
            var btnCocktails = new MetroTile()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Cocktails",
                Text = "Cocktails",
                TileTextFontWeight = MetroTileTextWeight.Regular,
                TileTextFontSize = MetroTileTextSize.Small,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btnCocktails.Click += ButtonProduct_Click;

            flowLayoutPanelVarious.Controls.Add(btnCocktails);

            //Create button Infusiones
            var btnInfusiones = new MetroTile()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Infusiones",
                Text = "Infusiones",
                TileTextFontWeight = MetroTileTextWeight.Regular,
                TileTextFontSize = MetroTileTextSize.Small,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btnInfusiones.Click += ButtonProduct_Click;

            flowLayoutPanelVarious.Controls.Add(btnInfusiones);

            //Create button Infusiones
            var btnVinos = new MetroTile()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Vinos",
                Text = "Vinos",
                TileTextFontWeight = MetroTileTextWeight.Regular,
                TileTextFontSize = MetroTileTextSize.Small,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btnVinos.Click += ButtonProduct_Click;

            flowLayoutPanelVarious.Controls.Add(btnVinos);

            //Create button Varios
            var btnVarios = new MetroTile()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Varios",
                Text = "Varios",
                TileTextFontWeight = MetroTileTextWeight.Regular,
                TileTextFontSize = MetroTileTextSize.Small,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btnVarios.Click += ButtonProduct_Click;

            flowLayoutPanelVarious.Controls.Add(btnVarios);
        }

        private void PaintEmployees()
        {
            try
            {
                flowLayoutPanelEmployees.Controls.Clear();

                _employees = EmployeeController.GetAllActive();

                foreach (var employee in _employees)
                {

                    if (employee.Image != null)
                    {
                        PaintEmployeeButtons(employee);
                    }
                    else
                    {
                        PaintEmployeeTiles(employee);
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void PaintEmployeeButtons(Employee employee)
        {
            var btn = new MetroButton
            {
                Width = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                Tag = employee,
                BackgroundImage = Common.BytesToImage(employee.Image),
                BackgroundImageLayout = ImageLayout.Stretch
            };
            btn.Click += ButtonEmployee_Click;
            flowLayoutPanelEmployees.Controls.Add(btn);
        }

        private void PaintEmployeeTiles(Employee employee)
        {
            var btn = new MetroTile
            {
                Width = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                Text = employee.Name,
                Tag = employee,
                Style = MetroColorStyle.Silver,
                TextAlign = ContentAlignment.TopLeft,
            };

            btn.Click += ButtonEmployee_Click;
            flowLayoutPanelEmployees.Controls.Add(btn);
        }

        #endregion

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

            if (AppGlobal.Sale == null)
            {
                AppGlobal.Sale = new Sale();
            }
          
            AppGlobal.Sale.Station = AppGlobal.Station;
            AppGlobal.Sale.Table = AppGlobal.Table;
            AppGlobal.Sale.Add(selectedProduct, AppGlobal.SaleMode, alcoholModeType);    
        }

        public void RefreshScreen()
        {
            try
            {
                RefreshSaleDetails();
                RefreshScreenInfo();
                LockSale();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void RefreshSaleDetails()
        {
            DataGridViewSelectedProducts.DataSource = null;
            if (AppGlobal.Sale != null && AppGlobal.Sale.Details.Count != 0)
            DataGridViewSelectedProducts.DataSource = AppGlobal.Sale.Details;
            DataGridViewSelectedProducts.ClearSelection();
        }

        private void RefreshScreenInfo()
        {
            lblSaleId.Text = string.Empty;
            lblTicket.Text = string.Empty;
            if (AppGlobal.Sale != null && AppGlobal.Sale.Id != 0)
            {
                lblTicket.Text = AppGlobal.Sale.Ticket ? "TICKET" : string.Empty;
                lblSaleId.Text = "VENTA: " + AppGlobal.Sale.Id;
            }

            txtTotalAmount.Text = AppGlobal.Sale.TotalPriceDetails().ToString("F") + Resources.Euro;
        }

        private void LockSale()
        {
            btnCancel.Enabled = !AppGlobal.Sale.Ticket; ;
            DataGridViewSelectedProducts.Enabled = !AppGlobal.Sale.Ticket;
            TableLayoutProducts.Enabled = !AppGlobal.Sale.Ticket;
        }

        private void FinalizeSale()
        {
            AppGlobal.Sale = new Sale();
            lblSaleId.Text = string.Empty;
            DataGridViewSelectedProducts.DataSource = null;
            txtTotalAmount.Text = Resources.CeroEuros;
        }

        private void SelectTable()
        {

            ViewController.ShowPopUp();

            try
            {
                SaveSale();

                var frmTablesDistribution = new FrmTablesDistribution(false);
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
                AppGlobal.Sale = SalesController.GetPendingByStationAndBar(AppGlobal.Station);
                RefreshScreen();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void SaveSale()
        {
            if (AppGlobal.Sale == null || AppGlobal.Sale.Details.Count == 0) return;

            SalesController.SaveOrUpdate(AppGlobal.Sale);         
        }

        private void PrintSaleTicket()
        {
            try
            {
                AppGlobal.Sale.PayType = PayType.NoPaid;
                AppGlobal.Sale.Ticket = true;
                SaveSale();

                PrinterController.PrintSale(AppGlobal.Sale);

            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        #endregion


    }
}