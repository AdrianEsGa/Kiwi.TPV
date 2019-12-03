using Kiwi.Tpv.Database.Entities;
using MetroFramework.Controls;

namespace Kiwi.Tpv.App
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnCommands = new MetroFramework.Controls.MetroTile();
            this.btnSelectBar = new MetroFramework.Controls.MetroTile();
            this.btnSelectTable = new MetroFramework.Controls.MetroTile();
            this.btnMenu = new MetroFramework.Controls.MetroTile();
            this.panel11 = new System.Windows.Forms.Panel();
            this.picBoxLogo = new MetroFramework.Controls.MetroButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnNightMode = new MetroFramework.Controls.MetroTile();
            this.btnDayMode = new MetroFramework.Controls.MetroTile();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnMinimize = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMaximize = new MetroFramework.Controls.MetroTile();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.lblComPortStatus = new MetroFramework.Controls.MetroLabel();
            this.lblStation = new MetroFramework.Controls.MetroLabel();
            this.lblDateTime = new MetroFramework.Controls.MetroLabel();
            this.SaleManagementPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SaleTotalAndEmployeePanel = new System.Windows.Forms.Panel();
            this.SaleTotalAndEmployeeFlowPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.TotalPanel = new System.Windows.Forms.Panel();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            this.PrintTicketPanel = new System.Windows.Forms.Panel();
            this.btnPrintTicket = new MetroFramework.Controls.MetroTile();
            this.EmployeesPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.SaleDetailsPanel = new System.Windows.Forms.Panel();
            this.DataGridViewSaleOrderDetails = new MetroFramework.Controls.MetroGrid();
            this.saleOrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaleInfoPanel = new MetroFramework.Controls.MetroPanel();
            this.lblDayNight = new MetroFramework.Controls.MetroLabel();
            this.lblTableBar = new MetroFramework.Controls.MetroLabel();
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.TableLayoutProducts = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelSecondaryMenus = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelSoda = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelAlcohol = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelBeer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelCafes = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelTes = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelInfusiones = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelCocktails = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelVinos = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelVarious = new System.Windows.Forms.FlowLayoutPanel();
            this.TimerWatch = new System.Windows.Forms.Timer(this.components);
            this.SystemTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxPercentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBottleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RemoveOne = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddOne = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HeadPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SaleManagementPanel.SuspendLayout();
            this.SaleTotalAndEmployeePanel.SuspendLayout();
            this.SaleTotalAndEmployeeFlowPanel.SuspendLayout();
            this.TotalPanel.SuspendLayout();
            this.PrintTicketPanel.SuspendLayout();
            this.EmployeesPanel.SuspendLayout();
            this.SaleDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSaleOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDetailBindingSource)).BeginInit();
            this.SaleInfoPanel.SuspendLayout();
            this.ProductsPanel.SuspendLayout();
            this.TableLayoutProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.White;
            this.HeadPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeadPanel.Controls.Add(this.tableLayoutPanel4);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(20, 30);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(1220, 70);
            this.HeadPanel.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel11, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel12, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1220, 70);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.btnCommands);
            this.panel10.Controls.Add(this.btnSelectBar);
            this.panel10.Controls.Add(this.btnSelectTable);
            this.panel10.Controls.Add(this.btnMenu);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(482, 64);
            this.panel10.TabIndex = 0;
            // 
            // btnCommands
            // 
            this.btnCommands.ActiveControl = null;
            this.btnCommands.BackColor = System.Drawing.SystemColors.Control;
            this.btnCommands.Location = new System.Drawing.Point(295, 16);
            this.btnCommands.Name = "btnCommands";
            this.btnCommands.Size = new System.Drawing.Size(113, 48);
            this.btnCommands.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCommands.TabIndex = 65;
            this.btnCommands.Text = "Comandas";
            this.btnCommands.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCommands.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnCommands.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnCommands.UseSelectable = true;
            this.btnCommands.UseTileImage = true;
            this.btnCommands.Click += new System.EventHandler(this.btnCommands_Click);
            // 
            // btnSelectBar
            // 
            this.btnSelectBar.ActiveControl = null;
            this.btnSelectBar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectBar.Location = new System.Drawing.Point(196, 16);
            this.btnSelectBar.Name = "btnSelectBar";
            this.btnSelectBar.Size = new System.Drawing.Size(81, 49);
            this.btnSelectBar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSelectBar.TabIndex = 64;
            this.btnSelectBar.Text = "Barra";
            this.btnSelectBar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSelectBar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSelectBar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSelectBar.UseSelectable = true;
            this.btnSelectBar.UseTileImage = true;
            this.btnSelectBar.Click += new System.EventHandler(this.btnSelectBar_Click);
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.ActiveControl = null;
            this.btnSelectTable.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectTable.Location = new System.Drawing.Point(109, 16);
            this.btnSelectTable.Name = "btnSelectTable";
            this.btnSelectTable.Size = new System.Drawing.Size(81, 48);
            this.btnSelectTable.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSelectTable.TabIndex = 63;
            this.btnSelectTable.Text = "Mesas";
            this.btnSelectTable.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSelectTable.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSelectTable.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSelectTable.UseSelectable = true;
            this.btnSelectTable.UseTileImage = true;
            this.btnSelectTable.Click += new System.EventHandler(this.btnSelectTable_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.ActiveControl = null;
            this.btnMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Location = new System.Drawing.Point(3, 1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 62);
            this.btnMenu.Style = MetroFramework.MetroColorStyle.Red;
            this.btnMenu.TabIndex = 62;
            this.btnMenu.Text = "Menú";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMenu.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnMenu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMenu.UseSelectable = true;
            this.btnMenu.UseTileImage = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.picBoxLogo);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(491, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(238, 64);
            this.panel11.TabIndex = 1;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxLogo.Location = new System.Drawing.Point(77, -3);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(86, 70);
            this.picBoxLogo.Style = MetroFramework.MetroColorStyle.White;
            this.picBoxLogo.TabIndex = 63;
            this.picBoxLogo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.picBoxLogo.UseSelectable = true;
            this.picBoxLogo.Click += new System.EventHandler(this.picBoxLogo_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.btnNightMode);
            this.panel12.Controls.Add(this.btnDayMode);
            this.panel12.Controls.Add(this.panel9);
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.panel8);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(735, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(482, 64);
            this.panel12.TabIndex = 2;
            // 
            // btnNightMode
            // 
            this.btnNightMode.ActiveControl = null;
            this.btnNightMode.BackColor = System.Drawing.SystemColors.Control;
            this.btnNightMode.Location = new System.Drawing.Point(90, 13);
            this.btnNightMode.Name = "btnNightMode";
            this.btnNightMode.Size = new System.Drawing.Size(81, 49);
            this.btnNightMode.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnNightMode.TabIndex = 65;
            this.btnNightMode.Text = "Noche";
            this.btnNightMode.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNightMode.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnNightMode.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNightMode.UseSelectable = true;
            this.btnNightMode.UseTileImage = true;
            this.btnNightMode.Click += new System.EventHandler(this.btnNightMode_Click);
            // 
            // btnDayMode
            // 
            this.btnDayMode.ActiveControl = null;
            this.btnDayMode.BackColor = System.Drawing.SystemColors.Control;
            this.btnDayMode.Location = new System.Drawing.Point(3, 13);
            this.btnDayMode.Name = "btnDayMode";
            this.btnDayMode.Size = new System.Drawing.Size(81, 48);
            this.btnDayMode.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnDayMode.TabIndex = 64;
            this.btnDayMode.Text = "Día";
            this.btnDayMode.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDayMode.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDayMode.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDayMode.UseSelectable = true;
            this.btnDayMode.UseTileImage = true;
            this.btnDayMode.Click += new System.EventHandler(this.btnDayMode_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnMinimize);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(236, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(82, 64);
            this.panel9.TabIndex = 5;
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveControl = null;
            this.btnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Location = new System.Drawing.Point(6, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(70, 62);
            this.btnMinimize.Style = MetroFramework.MetroColorStyle.White;
            this.btnMinimize.TabIndex = 61;
            this.btnMinimize.TileImage = global::Kiwi.Tpv.App.Properties.Resources.icoMinimize;
            this.btnMinimize.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.UseSelectable = true;
            this.btnMinimize.UseTileImage = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(318, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnMaximize
            // 
            this.btnMaximize.ActiveControl = null;
            this.btnMaximize.BackColor = System.Drawing.SystemColors.Control;
            this.btnMaximize.Location = new System.Drawing.Point(6, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(70, 62);
            this.btnMaximize.Style = MetroFramework.MetroColorStyle.White;
            this.btnMaximize.TabIndex = 61;
            this.btnMaximize.TileImage = global::Kiwi.Tpv.App.Properties.Resources.icoMaximize;
            this.btnMaximize.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaximize.UseSelectable = true;
            this.btnMaximize.UseTileImage = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnClose);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(400, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(82, 64);
            this.panel8.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(6, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 62);
            this.btnClose.Style = MetroFramework.MetroColorStyle.White;
            this.btnClose.TabIndex = 61;
            this.btnClose.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClose.TileImage")));
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblComPortStatus
            // 
            this.lblComPortStatus.AutoSize = true;
            this.lblComPortStatus.Location = new System.Drawing.Point(469, 11);
            this.lblComPortStatus.Name = "lblComPortStatus";
            this.lblComPortStatus.Size = new System.Drawing.Size(111, 19);
            this.lblComPortStatus.TabIndex = 2;
            this.lblComPortStatus.Text = "lblComPortStatus";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.lblStation.Location = new System.Drawing.Point(331, 11);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(63, 19);
            this.lblStation.TabIndex = 1;
            this.lblStation.Text = "lblStation";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.lblDateTime.Location = new System.Drawing.Point(20, 12);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(89, 19);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "DateAndTime";
            // 
            // SaleManagementPanel
            // 
            this.SaleManagementPanel.BackColor = System.Drawing.Color.Transparent;
            this.SaleManagementPanel.ColumnCount = 1;
            this.SaleManagementPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SaleManagementPanel.Controls.Add(this.SaleTotalAndEmployeePanel, 0, 2);
            this.SaleManagementPanel.Controls.Add(this.SaleDetailsPanel, 0, 1);
            this.SaleManagementPanel.Controls.Add(this.SaleInfoPanel, 0, 0);
            this.SaleManagementPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaleManagementPanel.Location = new System.Drawing.Point(831, 100);
            this.SaleManagementPanel.Name = "SaleManagementPanel";
            this.SaleManagementPanel.RowCount = 3;
            this.SaleManagementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.SaleManagementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.SaleManagementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SaleManagementPanel.Size = new System.Drawing.Size(409, 668);
            this.SaleManagementPanel.TabIndex = 2;
            // 
            // SaleTotalAndEmployeePanel
            // 
            this.SaleTotalAndEmployeePanel.Controls.Add(this.SaleTotalAndEmployeeFlowPanel);
            this.SaleTotalAndEmployeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleTotalAndEmployeePanel.Location = new System.Drawing.Point(3, 336);
            this.SaleTotalAndEmployeePanel.Name = "SaleTotalAndEmployeePanel";
            this.SaleTotalAndEmployeePanel.Size = new System.Drawing.Size(403, 329);
            this.SaleTotalAndEmployeePanel.TabIndex = 1;
            // 
            // SaleTotalAndEmployeeFlowPanel
            // 
            this.SaleTotalAndEmployeeFlowPanel.ColumnCount = 1;
            this.SaleTotalAndEmployeeFlowPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SaleTotalAndEmployeeFlowPanel.Controls.Add(this.btnCancel, 0, 3);
            this.SaleTotalAndEmployeeFlowPanel.Controls.Add(this.TotalPanel, 0, 0);
            this.SaleTotalAndEmployeeFlowPanel.Controls.Add(this.PrintTicketPanel, 0, 1);
            this.SaleTotalAndEmployeeFlowPanel.Controls.Add(this.EmployeesPanel, 0, 2);
            this.SaleTotalAndEmployeeFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleTotalAndEmployeeFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.SaleTotalAndEmployeeFlowPanel.Name = "SaleTotalAndEmployeeFlowPanel";
            this.SaleTotalAndEmployeeFlowPanel.RowCount = 4;
            this.SaleTotalAndEmployeeFlowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.SaleTotalAndEmployeeFlowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.SaleTotalAndEmployeeFlowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.SaleTotalAndEmployeeFlowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.SaleTotalAndEmployeeFlowPanel.Size = new System.Drawing.Size(403, 329);
            this.SaleTotalAndEmployeeFlowPanel.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnCancel.Location = new System.Drawing.Point(3, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(397, 45);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TotalPanel
            // 
            this.TotalPanel.Controls.Add(this.txtTotalAmount);
            this.TotalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalPanel.Location = new System.Drawing.Point(3, 3);
            this.TotalPanel.Name = "TotalPanel";
            this.TotalPanel.Size = new System.Drawing.Size(397, 43);
            this.TotalPanel.TabIndex = 0;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTotalAmount.CustomButton.Image = null;
            this.txtTotalAmount.CustomButton.Location = new System.Drawing.Point(355, 1);
            this.txtTotalAmount.CustomButton.Name = "";
            this.txtTotalAmount.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txtTotalAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalAmount.CustomButton.TabIndex = 1;
            this.txtTotalAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalAmount.CustomButton.UseSelectable = true;
            this.txtTotalAmount.CustomButton.Visible = false;
            this.txtTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTotalAmount.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTotalAmount.Lines = new string[] {
        "0"};
            this.txtTotalAmount.Location = new System.Drawing.Point(0, 0);
            this.txtTotalAmount.MaxLength = 32767;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.SelectionLength = 0;
            this.txtTotalAmount.SelectionStart = 0;
            this.txtTotalAmount.ShortcutsEnabled = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(397, 43);
            this.txtTotalAmount.TabIndex = 2;
            this.txtTotalAmount.Text = "0";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalAmount.UseSelectable = true;
            this.txtTotalAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PrintTicketPanel
            // 
            this.PrintTicketPanel.Controls.Add(this.btnPrintTicket);
            this.PrintTicketPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintTicketPanel.Location = new System.Drawing.Point(3, 52);
            this.PrintTicketPanel.Name = "PrintTicketPanel";
            this.PrintTicketPanel.Size = new System.Drawing.Size(397, 43);
            this.PrintTicketPanel.TabIndex = 1;
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.ActiveControl = null;
            this.btnPrintTicket.BackColor = System.Drawing.Color.White;
            this.btnPrintTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnPrintTicket.Location = new System.Drawing.Point(0, 0);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(397, 43);
            this.btnPrintTicket.Style = MetroFramework.MetroColorStyle.Green;
            this.btnPrintTicket.TabIndex = 4;
            this.btnPrintTicket.Text = "Imprimir Ticket";
            this.btnPrintTicket.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnPrintTicket.UseSelectable = true;
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicket_Click);
            // 
            // EmployeesPanel
            // 
            this.EmployeesPanel.Controls.Add(this.flowLayoutPanelEmployees);
            this.EmployeesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeesPanel.Location = new System.Drawing.Point(3, 101);
            this.EmployeesPanel.Name = "EmployeesPanel";
            this.EmployeesPanel.Size = new System.Drawing.Size(397, 174);
            this.EmployeesPanel.TabIndex = 2;
            // 
            // flowLayoutPanelEmployees
            // 
            this.flowLayoutPanelEmployees.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEmployees.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelEmployees.Name = "flowLayoutPanelEmployees";
            this.flowLayoutPanelEmployees.Size = new System.Drawing.Size(397, 174);
            this.flowLayoutPanelEmployees.TabIndex = 2;
            // 
            // SaleDetailsPanel
            // 
            this.SaleDetailsPanel.Controls.Add(this.DataGridViewSaleOrderDetails);
            this.SaleDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleDetailsPanel.Location = new System.Drawing.Point(3, 36);
            this.SaleDetailsPanel.Name = "SaleDetailsPanel";
            this.SaleDetailsPanel.Size = new System.Drawing.Size(403, 294);
            this.SaleDetailsPanel.TabIndex = 0;
            // 
            // DataGridViewSaleOrderDetails
            // 
            this.DataGridViewSaleOrderDetails.AllowUserToAddRows = false;
            this.DataGridViewSaleOrderDetails.AllowUserToDeleteRows = false;
            this.DataGridViewSaleOrderDetails.AllowUserToResizeColumns = false;
            this.DataGridViewSaleOrderDetails.AllowUserToResizeRows = false;
            this.DataGridViewSaleOrderDetails.AutoGenerateColumns = false;
            this.DataGridViewSaleOrderDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewSaleOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewSaleOrderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewSaleOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSaleOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewSaleOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSaleOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductImage,
            this.idDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.TotalString,
            this.taxPercentajeDataGridViewTextBoxColumn,
            this.isBottleDataGridViewCheckBoxColumn,
            this.RemoveOne,
            this.AddOne});
            this.DataGridViewSaleOrderDetails.DataSource = this.saleOrderDetailBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSaleOrderDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewSaleOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewSaleOrderDetails.EnableHeadersVisualStyles = false;
            this.DataGridViewSaleOrderDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewSaleOrderDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewSaleOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewSaleOrderDetails.MultiSelect = false;
            this.DataGridViewSaleOrderDetails.Name = "DataGridViewSaleOrderDetails";
            this.DataGridViewSaleOrderDetails.ReadOnly = true;
            this.DataGridViewSaleOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSaleOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewSaleOrderDetails.RowHeadersVisible = false;
            this.DataGridViewSaleOrderDetails.RowHeadersWidth = 70;
            this.DataGridViewSaleOrderDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewSaleOrderDetails.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSaleOrderDetails.RowTemplate.Height = 47;
            this.DataGridViewSaleOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewSaleOrderDetails.Size = new System.Drawing.Size(403, 294);
            this.DataGridViewSaleOrderDetails.Style = MetroFramework.MetroColorStyle.Lime;
            this.DataGridViewSaleOrderDetails.TabIndex = 2;
            this.DataGridViewSaleOrderDetails.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DataGridViewSaleOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSelectedProducts_CellClick);
            this.DataGridViewSaleOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSelectedProducts_CellContentClick);
            // 
            // saleOrderDetailBindingSource
            // 
            this.saleOrderDetailBindingSource.DataSource = typeof(Kiwi.Tpv.Database.Entities.SaleOrderDetail);
            // 
            // SaleInfoPanel
            // 
            this.SaleInfoPanel.Controls.Add(this.lblDayNight);
            this.SaleInfoPanel.Controls.Add(this.lblTableBar);
            this.SaleInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleInfoPanel.HorizontalScrollbarBarColor = true;
            this.SaleInfoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.SaleInfoPanel.HorizontalScrollbarSize = 10;
            this.SaleInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.SaleInfoPanel.Name = "SaleInfoPanel";
            this.SaleInfoPanel.Size = new System.Drawing.Size(403, 27);
            this.SaleInfoPanel.TabIndex = 2;
            this.SaleInfoPanel.VerticalScrollbarBarColor = true;
            this.SaleInfoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.SaleInfoPanel.VerticalScrollbarSize = 10;
            // 
            // lblDayNight
            // 
            this.lblDayNight.AutoSize = true;
            this.lblDayNight.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDayNight.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDayNight.Location = new System.Drawing.Point(3, -3);
            this.lblDayNight.Name = "lblDayNight";
            this.lblDayNight.Size = new System.Drawing.Size(67, 25);
            this.lblDayNight.Style = MetroFramework.MetroColorStyle.Green;
            this.lblDayNight.TabIndex = 5;
            this.lblDayNight.Text = "Noche";
            // 
            // lblTableBar
            // 
            this.lblTableBar.AutoSize = true;
            this.lblTableBar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTableBar.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTableBar.Location = new System.Drawing.Point(76, -3);
            this.lblTableBar.Name = "lblTableBar";
            this.lblTableBar.Size = new System.Drawing.Size(82, 25);
            this.lblTableBar.Style = MetroFramework.MetroColorStyle.Green;
            this.lblTableBar.TabIndex = 2;
            this.lblTableBar.Text = "Mesa 12";
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProductsPanel.Controls.Add(this.TableLayoutProducts);
            this.ProductsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsPanel.Location = new System.Drawing.Point(20, 100);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(811, 668);
            this.ProductsPanel.TabIndex = 3;
            // 
            // TableLayoutProducts
            // 
            this.TableLayoutProducts.AutoSize = true;
            this.TableLayoutProducts.BackColor = System.Drawing.Color.White;
            this.TableLayoutProducts.ColumnCount = 1;
            this.TableLayoutProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutProducts.Controls.Add(this.flowLayoutPanelSecondaryMenus, 0, 9);
            this.TableLayoutProducts.Controls.Add(this.flowLayoutPanelSoda, 0, 1);
            this.TableLayoutProducts.Controls.Add(this.flowLayoutPanelAlcohol, 0, 0);
            this.TableLayoutProducts.Controls.Add(this.flowLayoutPanelBeer, 0, 2);
            this.TableLayoutProducts.Controls.Add(this.flowLayoutPanelCafes, 0, 3);
            this.TableLayoutProducts.Controls.Add(this.flowLayoutPanelTes, 0, 4);
            this.TableLayoutProducts.Controls.Add(this.flowLayoutPanelInfusiones, 0, 5);
            this.TableLayoutProducts.Controls.Add(this.flowLayoutPanelCocktails, 0, 6);
            this.TableLayoutProducts.Controls.Add(this.flowLayoutPanelVinos, 0, 7);
            this.TableLayoutProducts.Controls.Add(this.flowLayoutPanelVarious, 0, 8);
            this.TableLayoutProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutProducts.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutProducts.Name = "TableLayoutProducts";
            this.TableLayoutProducts.RowCount = 10;
            this.TableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutProducts.Size = new System.Drawing.Size(811, 668);
            this.TableLayoutProducts.TabIndex = 0;
            // 
            // flowLayoutPanelSecondaryMenus
            // 
            this.flowLayoutPanelSecondaryMenus.AutoScroll = true;
            this.flowLayoutPanelSecondaryMenus.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelSecondaryMenus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelSecondaryMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSecondaryMenus.Location = new System.Drawing.Point(3, 264);
            this.flowLayoutPanelSecondaryMenus.Name = "flowLayoutPanelSecondaryMenus";
            this.flowLayoutPanelSecondaryMenus.Size = new System.Drawing.Size(805, 401);
            this.flowLayoutPanelSecondaryMenus.TabIndex = 10;
            // 
            // flowLayoutPanelSoda
            // 
            this.flowLayoutPanelSoda.AutoScroll = true;
            this.flowLayoutPanelSoda.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelSoda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelSoda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSoda.Location = new System.Drawing.Point(3, 32);
            this.flowLayoutPanelSoda.Name = "flowLayoutPanelSoda";
            this.flowLayoutPanelSoda.Size = new System.Drawing.Size(805, 23);
            this.flowLayoutPanelSoda.TabIndex = 1;
            // 
            // flowLayoutPanelAlcohol
            // 
            this.flowLayoutPanelAlcohol.AutoScroll = true;
            this.flowLayoutPanelAlcohol.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelAlcohol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelAlcohol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAlcohol.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelAlcohol.Name = "flowLayoutPanelAlcohol";
            this.flowLayoutPanelAlcohol.Size = new System.Drawing.Size(805, 23);
            this.flowLayoutPanelAlcohol.TabIndex = 0;
            // 
            // flowLayoutPanelBeer
            // 
            this.flowLayoutPanelBeer.AutoScroll = true;
            this.flowLayoutPanelBeer.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelBeer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBeer.Location = new System.Drawing.Point(3, 61);
            this.flowLayoutPanelBeer.Name = "flowLayoutPanelBeer";
            this.flowLayoutPanelBeer.Size = new System.Drawing.Size(805, 23);
            this.flowLayoutPanelBeer.TabIndex = 4;
            // 
            // flowLayoutPanelCafes
            // 
            this.flowLayoutPanelCafes.AutoScroll = true;
            this.flowLayoutPanelCafes.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelCafes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelCafes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCafes.Location = new System.Drawing.Point(3, 90);
            this.flowLayoutPanelCafes.Name = "flowLayoutPanelCafes";
            this.flowLayoutPanelCafes.Size = new System.Drawing.Size(805, 23);
            this.flowLayoutPanelCafes.TabIndex = 3;
            // 
            // flowLayoutPanelTes
            // 
            this.flowLayoutPanelTes.AutoScroll = true;
            this.flowLayoutPanelTes.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelTes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelTes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTes.Location = new System.Drawing.Point(3, 119);
            this.flowLayoutPanelTes.Name = "flowLayoutPanelTes";
            this.flowLayoutPanelTes.Size = new System.Drawing.Size(805, 23);
            this.flowLayoutPanelTes.TabIndex = 5;
            // 
            // flowLayoutPanelInfusiones
            // 
            this.flowLayoutPanelInfusiones.AutoScroll = true;
            this.flowLayoutPanelInfusiones.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelInfusiones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelInfusiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelInfusiones.Location = new System.Drawing.Point(3, 148);
            this.flowLayoutPanelInfusiones.Name = "flowLayoutPanelInfusiones";
            this.flowLayoutPanelInfusiones.Size = new System.Drawing.Size(805, 23);
            this.flowLayoutPanelInfusiones.TabIndex = 6;
            // 
            // flowLayoutPanelCocktails
            // 
            this.flowLayoutPanelCocktails.AutoScroll = true;
            this.flowLayoutPanelCocktails.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelCocktails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelCocktails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCocktails.Location = new System.Drawing.Point(3, 177);
            this.flowLayoutPanelCocktails.Name = "flowLayoutPanelCocktails";
            this.flowLayoutPanelCocktails.Size = new System.Drawing.Size(805, 23);
            this.flowLayoutPanelCocktails.TabIndex = 7;
            // 
            // flowLayoutPanelVinos
            // 
            this.flowLayoutPanelVinos.AutoScroll = true;
            this.flowLayoutPanelVinos.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelVinos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelVinos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelVinos.Location = new System.Drawing.Point(3, 206);
            this.flowLayoutPanelVinos.Name = "flowLayoutPanelVinos";
            this.flowLayoutPanelVinos.Size = new System.Drawing.Size(805, 23);
            this.flowLayoutPanelVinos.TabIndex = 8;
            // 
            // flowLayoutPanelVarious
            // 
            this.flowLayoutPanelVarious.AutoScroll = true;
            this.flowLayoutPanelVarious.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelVarious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelVarious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelVarious.Location = new System.Drawing.Point(3, 235);
            this.flowLayoutPanelVarious.Name = "flowLayoutPanelVarious";
            this.flowLayoutPanelVarious.Size = new System.Drawing.Size(805, 23);
            this.flowLayoutPanelVarious.TabIndex = 9;
            // 
            // TimerWatch
            // 
            this.TimerWatch.Enabled = true;
            this.TimerWatch.Interval = 1000;
            this.TimerWatch.Tick += new System.EventHandler(this.timerWatch_Tick);
            // 
            // SystemTimer
            // 
            this.SystemTimer.Interval = 3000000;
            this.SystemTimer.Tick += new System.EventHandler(this.SystemTimer_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ProductImage
            // 
            this.ProductImage.DataPropertyName = "ProductImage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.ProductImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductImage.HeaderText = "";
            this.ProductImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            this.ProductImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductImage.Width = 50;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Und.";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Visible = false;
            // 
            // TotalString
            // 
            this.TotalString.DataPropertyName = "TotalString";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalString.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalString.HeaderText = "Total";
            this.TotalString.Name = "TotalString";
            this.TotalString.ReadOnly = true;
            this.TotalString.Width = 50;
            // 
            // taxPercentajeDataGridViewTextBoxColumn
            // 
            this.taxPercentajeDataGridViewTextBoxColumn.DataPropertyName = "TaxPercentaje";
            this.taxPercentajeDataGridViewTextBoxColumn.HeaderText = "TaxPercentaje";
            this.taxPercentajeDataGridViewTextBoxColumn.Name = "taxPercentajeDataGridViewTextBoxColumn";
            this.taxPercentajeDataGridViewTextBoxColumn.ReadOnly = true;
            this.taxPercentajeDataGridViewTextBoxColumn.Visible = false;
            // 
            // isBottleDataGridViewCheckBoxColumn
            // 
            this.isBottleDataGridViewCheckBoxColumn.DataPropertyName = "IsBottle";
            this.isBottleDataGridViewCheckBoxColumn.HeaderText = "IsBottle";
            this.isBottleDataGridViewCheckBoxColumn.Name = "isBottleDataGridViewCheckBoxColumn";
            this.isBottleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isBottleDataGridViewCheckBoxColumn.Visible = false;
            // 
            // RemoveOne
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.RemoveOne.DefaultCellStyle = dataGridViewCellStyle4;
            this.RemoveOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveOne.HeaderText = "";
            this.RemoveOne.Name = "RemoveOne";
            this.RemoveOne.ReadOnly = true;
            this.RemoveOne.Text = "-";
            this.RemoveOne.UseColumnTextForButtonValue = true;
            this.RemoveOne.Width = 61;
            // 
            // AddOne
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddOne.DefaultCellStyle = dataGridViewCellStyle5;
            this.AddOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddOne.HeaderText = "";
            this.AddOne.Name = "AddOne";
            this.AddOne.ReadOnly = true;
            this.AddOne.Text = "+";
            this.AddOne.UseColumnTextForButtonValue = true;
            this.AddOne.Width = 61;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 788);
            this.ControlBox = false;
            this.Controls.Add(this.lblComPortStatus);
            this.Controls.Add(this.ProductsPanel);
            this.Controls.Add(this.SaleManagementPanel);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblStation);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1260, 736);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Kiwi TPV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.HeadPanel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.SaleManagementPanel.ResumeLayout(false);
            this.SaleTotalAndEmployeePanel.ResumeLayout(false);
            this.SaleTotalAndEmployeeFlowPanel.ResumeLayout(false);
            this.TotalPanel.ResumeLayout(false);
            this.PrintTicketPanel.ResumeLayout(false);
            this.EmployeesPanel.ResumeLayout(false);
            this.SaleDetailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSaleOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDetailBindingSource)).EndInit();
            this.SaleInfoPanel.ResumeLayout(false);
            this.SaleInfoPanel.PerformLayout();
            this.ProductsPanel.ResumeLayout(false);
            this.ProductsPanel.PerformLayout();
            this.TableLayoutProducts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel SaleManagementPanel;
        private System.Windows.Forms.Panel SaleTotalAndEmployeePanel;
        private System.Windows.Forms.TableLayoutPanel SaleTotalAndEmployeeFlowPanel;
        private System.Windows.Forms.Panel TotalPanel;
        private System.Windows.Forms.Panel PrintTicketPanel;
        private System.Windows.Forms.Panel EmployeesPanel;
        private MetroTextBox txtTotalAmount;
        private MetroTile btnCancel;
        private System.Windows.Forms.Panel ProductsPanel;
        private System.Windows.Forms.TableLayoutPanel TableLayoutProducts;
        private MetroLabel lblStation;
        private MetroLabel lblComPortStatus;
        private MetroLabel lblDateTime;
        private System.Windows.Forms.Timer TimerWatch;
        private System.Windows.Forms.Timer SystemTimer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private MetroTile btnClose;
        private MetroTile btnMinimize;
        private MetroTile btnMaximize;
        private MetroTile btnMenu;
        private MetroButton picBoxLogo;
        private MetroTile btnSelectBar;
        private MetroTile btnSelectTable;
        private System.Windows.Forms.Panel SaleDetailsPanel;
        private MetroPanel SaleInfoPanel;
        private MetroLabel lblTableBar;
        private MetroTile btnPrintTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MetroGrid DataGridViewSaleOrderDetails;
        private MetroTile btnNightMode;
        private MetroTile btnDayMode;
        private MetroLabel lblDayNight;
        private MetroTile btnCommands;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlcohol;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSoda;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCafes;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBeer;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTes;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInfusiones;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCocktails;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVinos;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSecondaryMenus;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVarious;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEmployees;
        private System.Windows.Forms.BindingSource saleOrderDetailBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalString;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxPercentajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBottleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveOne;
        private System.Windows.Forms.DataGridViewButtonColumn AddOne;
    }
}

