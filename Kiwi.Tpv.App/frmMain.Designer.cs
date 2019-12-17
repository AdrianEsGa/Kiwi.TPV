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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.PricesSystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PricesSystemDayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PricesSystemNightMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FreeSaleOrdersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FreeSaleOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarTablesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PendingSaleOrdersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PDAComandasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel11 = new System.Windows.Forms.Panel();
            this.picBoxLogo = new MetroFramework.Controls.MetroButton();
            this.panel12 = new System.Windows.Forms.Panel();
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
            this.saleOrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaleInfoPanel = new MetroFramework.Controls.MetroPanel();
            this.lblTableBar = new MetroFramework.Controls.MetroTile();
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
            this.lblDayNight = new MetroFramework.Controls.MetroTile();
            this.HeadPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.MenuStrip.SuspendLayout();
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
            this.panel10.Controls.Add(this.MenuStrip);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(482, 64);
            this.panel10.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.White;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuStrip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPrincipal,
            this.FreeSaleOrdersMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(482, 64);
            this.MenuStrip.TabIndex = 66;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuItemPrincipal
            // 
            this.MenuItemPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PricesSystemMenuItem,
            this.AdministrationMenuItem});
            this.MenuItemPrincipal.Name = "MenuItemPrincipal";
            this.MenuItemPrincipal.Size = new System.Drawing.Size(97, 60);
            this.MenuItemPrincipal.Text = "Menú";
            // 
            // PricesSystemMenuItem
            // 
            this.PricesSystemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PricesSystemDayMenuItem,
            this.PricesSystemNightMenuItem});
            this.PricesSystemMenuItem.Name = "PricesSystemMenuItem";
            this.PricesSystemMenuItem.Size = new System.Drawing.Size(342, 36);
            this.PricesSystemMenuItem.Text = "Sistema de precios";
            // 
            // PricesSystemDayMenuItem
            // 
            this.PricesSystemDayMenuItem.Name = "PricesSystemDayMenuItem";
            this.PricesSystemDayMenuItem.Size = new System.Drawing.Size(175, 36);
            this.PricesSystemDayMenuItem.Text = "Día";
            this.PricesSystemDayMenuItem.Click += new System.EventHandler(this.PricesSystemDayMenuItem_Click);
            // 
            // PricesSystemNightMenuItem
            // 
            this.PricesSystemNightMenuItem.Name = "PricesSystemNightMenuItem";
            this.PricesSystemNightMenuItem.Size = new System.Drawing.Size(175, 36);
            this.PricesSystemNightMenuItem.Text = "Noche";
            this.PricesSystemNightMenuItem.Click += new System.EventHandler(this.PricesSystemNightMenuItem_Click);
            // 
            // AdministrationMenuItem
            // 
            this.AdministrationMenuItem.Name = "AdministrationMenuItem";
            this.AdministrationMenuItem.Size = new System.Drawing.Size(342, 36);
            this.AdministrationMenuItem.Text = "Administración";
            this.AdministrationMenuItem.Click += new System.EventHandler(this.AdministrationMenuItem_Click);
            // 
            // FreeSaleOrdersMenuItem
            // 
            this.FreeSaleOrdersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FreeSaleOrderMenuItem,
            this.BarTablesMenuItem,
            this.PendingSaleOrdersMenuItem,
            this.PDAComandasMenuItem});
            this.FreeSaleOrdersMenuItem.Name = "FreeSaleOrdersMenuItem";
            this.FreeSaleOrdersMenuItem.Size = new System.Drawing.Size(133, 60);
            this.FreeSaleOrdersMenuItem.Text = "Pedidos";
            // 
            // FreeSaleOrderMenuItem
            // 
            this.FreeSaleOrderMenuItem.Name = "FreeSaleOrderMenuItem";
            this.FreeSaleOrderMenuItem.Size = new System.Drawing.Size(294, 36);
            this.FreeSaleOrderMenuItem.Text = "Libre";
            this.FreeSaleOrderMenuItem.Click += new System.EventHandler(this.FreeSaleOrdersMenuItem_Click);
            // 
            // BarTablesMenuItem
            // 
            this.BarTablesMenuItem.Name = "BarTablesMenuItem";
            this.BarTablesMenuItem.Size = new System.Drawing.Size(294, 36);
            this.BarTablesMenuItem.Text = "Mesas / Barra";
            this.BarTablesMenuItem.Click += new System.EventHandler(this.BarTablesMenuItem_Click);
            // 
            // PendingSaleOrdersMenuItem
            // 
            this.PendingSaleOrdersMenuItem.Name = "PendingSaleOrdersMenuItem";
            this.PendingSaleOrdersMenuItem.Size = new System.Drawing.Size(294, 36);
            this.PendingSaleOrdersMenuItem.Text = "Pendientes";
            this.PendingSaleOrdersMenuItem.Click += new System.EventHandler(this.PendingSaleOrdersMenuItem_Click);
            // 
            // PDAComandasMenuItem
            // 
            this.PDAComandasMenuItem.Name = "PDAComandasMenuItem";
            this.PDAComandasMenuItem.Size = new System.Drawing.Size(294, 36);
            this.PDAComandasMenuItem.Text = "Comandas PDA";
            this.PDAComandasMenuItem.Click += new System.EventHandler(this.PDAComandasMenuItem_Click);
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
            this.panel12.Controls.Add(this.panel9);
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.panel8);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(735, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(482, 64);
            this.panel12.TabIndex = 2;
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
            this.SaleManagementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.SaleManagementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.SaleManagementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.SaleManagementPanel.Size = new System.Drawing.Size(409, 668);
            this.SaleManagementPanel.TabIndex = 2;
            // 
            // SaleTotalAndEmployeePanel
            // 
            this.SaleTotalAndEmployeePanel.Controls.Add(this.SaleTotalAndEmployeeFlowPanel);
            this.SaleTotalAndEmployeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleTotalAndEmployeePanel.Location = new System.Drawing.Point(3, 363);
            this.SaleTotalAndEmployeePanel.Name = "SaleTotalAndEmployeePanel";
            this.SaleTotalAndEmployeePanel.Size = new System.Drawing.Size(403, 302);
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
            this.SaleTotalAndEmployeeFlowPanel.Size = new System.Drawing.Size(403, 302);
            this.SaleTotalAndEmployeeFlowPanel.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnCancel.Location = new System.Drawing.Point(3, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(397, 40);
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
            this.TotalPanel.Size = new System.Drawing.Size(397, 39);
            this.TotalPanel.TabIndex = 0;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTotalAmount.CustomButton.Image = null;
            this.txtTotalAmount.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.txtTotalAmount.CustomButton.Name = "";
            this.txtTotalAmount.CustomButton.Size = new System.Drawing.Size(37, 37);
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
            this.txtTotalAmount.Size = new System.Drawing.Size(397, 39);
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
            this.PrintTicketPanel.Location = new System.Drawing.Point(3, 48);
            this.PrintTicketPanel.Name = "PrintTicketPanel";
            this.PrintTicketPanel.Size = new System.Drawing.Size(397, 39);
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
            this.btnPrintTicket.Size = new System.Drawing.Size(397, 39);
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
            this.EmployeesPanel.Location = new System.Drawing.Point(3, 93);
            this.EmployeesPanel.Name = "EmployeesPanel";
            this.EmployeesPanel.Size = new System.Drawing.Size(397, 160);
            this.EmployeesPanel.TabIndex = 2;
            // 
            // flowLayoutPanelEmployees
            // 
            this.flowLayoutPanelEmployees.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEmployees.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelEmployees.Name = "flowLayoutPanelEmployees";
            this.flowLayoutPanelEmployees.Size = new System.Drawing.Size(397, 160);
            this.flowLayoutPanelEmployees.TabIndex = 2;
            // 
            // SaleDetailsPanel
            // 
            this.SaleDetailsPanel.Controls.Add(this.DataGridViewSaleOrderDetails);
            this.SaleDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleDetailsPanel.Location = new System.Drawing.Point(3, 56);
            this.SaleDetailsPanel.Name = "SaleDetailsPanel";
            this.SaleDetailsPanel.Size = new System.Drawing.Size(403, 301);
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSaleOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSaleOrderDetails.DefaultCellStyle = dataGridViewCellStyle20;
            this.DataGridViewSaleOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewSaleOrderDetails.EnableHeadersVisualStyles = false;
            this.DataGridViewSaleOrderDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewSaleOrderDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewSaleOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewSaleOrderDetails.MultiSelect = false;
            this.DataGridViewSaleOrderDetails.Name = "DataGridViewSaleOrderDetails";
            this.DataGridViewSaleOrderDetails.ReadOnly = true;
            this.DataGridViewSaleOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSaleOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DataGridViewSaleOrderDetails.RowHeadersVisible = false;
            this.DataGridViewSaleOrderDetails.RowHeadersWidth = 70;
            this.DataGridViewSaleOrderDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewSaleOrderDetails.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSaleOrderDetails.RowTemplate.Height = 47;
            this.DataGridViewSaleOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewSaleOrderDetails.Size = new System.Drawing.Size(403, 301);
            this.DataGridViewSaleOrderDetails.Style = MetroFramework.MetroColorStyle.Lime;
            this.DataGridViewSaleOrderDetails.TabIndex = 2;
            this.DataGridViewSaleOrderDetails.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DataGridViewSaleOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSelectedProducts_CellClick);
            this.DataGridViewSaleOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSelectedProducts_CellContentClick);
            // 
            // ProductImage
            // 
            this.ProductImage.DataPropertyName = "ProductImage";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(2);
            this.ProductImage.DefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalString.DefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Red;
            this.RemoveOne.DefaultCellStyle = dataGridViewCellStyle18;
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddOne.DefaultCellStyle = dataGridViewCellStyle19;
            this.AddOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddOne.HeaderText = "";
            this.AddOne.Name = "AddOne";
            this.AddOne.ReadOnly = true;
            this.AddOne.Text = "+";
            this.AddOne.UseColumnTextForButtonValue = true;
            this.AddOne.Width = 61;
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
            this.SaleInfoPanel.Size = new System.Drawing.Size(403, 47);
            this.SaleInfoPanel.TabIndex = 2;
            this.SaleInfoPanel.VerticalScrollbarBarColor = true;
            this.SaleInfoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.SaleInfoPanel.VerticalScrollbarSize = 10;
            // 
            // lblTableBar
            // 
            this.lblTableBar.ActiveControl = null;
            this.lblTableBar.Location = new System.Drawing.Point(3, -3);
            this.lblTableBar.Name = "lblTableBar";
            this.lblTableBar.Size = new System.Drawing.Size(300, 50);
            this.lblTableBar.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblTableBar.TabIndex = 6;
            this.lblTableBar.Text = "PEDIDO LIBRE";
            this.lblTableBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTableBar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.lblTableBar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.lblTableBar.UseSelectable = true;
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
            // lblDayNight
            // 
            this.lblDayNight.ActiveControl = null;
            this.lblDayNight.Location = new System.Drawing.Point(299, -3);
            this.lblDayNight.Name = "lblDayNight";
            this.lblDayNight.Size = new System.Drawing.Size(101, 50);
            this.lblDayNight.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblDayNight.TabIndex = 7;
            this.lblDayNight.Text = "NOCHE";
            this.lblDayNight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDayNight.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.lblDayNight.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.lblDayNight.UseSelectable = true;
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
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(1260, 736);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Kiwi TPV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.HeadPanel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
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
        private MetroButton picBoxLogo;
        private System.Windows.Forms.Panel SaleDetailsPanel;
        private MetroPanel SaleInfoPanel;
        private MetroTile btnPrintTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MetroGrid DataGridViewSaleOrderDetails;
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
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrincipal;
        private System.Windows.Forms.ToolStripMenuItem PricesSystemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PricesSystemDayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PricesSystemNightMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministrationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FreeSaleOrdersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FreeSaleOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BarTablesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PendingSaleOrdersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PDAComandasMenuItem;
        private MetroTile lblTableBar;
        private MetroTile lblDayNight;
    }
}

