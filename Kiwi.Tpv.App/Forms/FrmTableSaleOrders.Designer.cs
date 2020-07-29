namespace Kiwi.Tpv.App.Forms
{
    partial class FrmTableSaleOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableSaleOrders));
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.panelButtons = new MetroFramework.Controls.MetroPanel();
            this.btnMoveToPendingSaleOrders = new MetroFramework.Controls.MetroTile();
            this.btnAddProducts = new MetroFramework.Controls.MetroTile();
            this.btnMoveAllToOtherTable = new MetroFramework.Controls.MetroTile();
            this.btnPaySelectedSale = new MetroFramework.Controls.MetroTile();
            this.btnNewSale = new MetroFramework.Controls.MetroTile();
            this.DataGridViewTableSales = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotalPending = new MetroFramework.Controls.MetroTile();
            this.DataGridViewTableSaleDetails = new MetroFramework.Controls.MetroGrid();
            this.productImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxPercentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBottleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleOrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTableSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTableSaleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(909, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 62);
            this.btnClose.Style = MetroFramework.MetroColorStyle.White;
            this.btnClose.TabIndex = 56;
            this.btnClose.TileImage = global::Kiwi.Tpv.App.Properties.Resources.icoClose;
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnMoveToPendingSaleOrders);
            this.panelButtons.Controls.Add(this.btnAddProducts);
            this.panelButtons.Controls.Add(this.btnMoveAllToOtherTable);
            this.panelButtons.Controls.Add(this.btnPaySelectedSale);
            this.panelButtons.Controls.Add(this.btnNewSale);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.HorizontalScrollbarBarColor = true;
            this.panelButtons.HorizontalScrollbarHighlightOnWheel = false;
            this.panelButtons.HorizontalScrollbarSize = 10;
            this.panelButtons.Location = new System.Drawing.Point(20, 612);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(974, 64);
            this.panelButtons.TabIndex = 57;
            this.panelButtons.VerticalScrollbarBarColor = true;
            this.panelButtons.VerticalScrollbarHighlightOnWheel = false;
            this.panelButtons.VerticalScrollbarSize = 10;
            // 
            // btnMoveToPendingSaleOrders
            // 
            this.btnMoveToPendingSaleOrders.ActiveControl = null;
            this.btnMoveToPendingSaleOrders.BackColor = System.Drawing.Color.White;
            this.btnMoveToPendingSaleOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnMoveToPendingSaleOrders.Location = new System.Drawing.Point(501, 3);
            this.btnMoveToPendingSaleOrders.Name = "btnMoveToPendingSaleOrders";
            this.btnMoveToPendingSaleOrders.Size = new System.Drawing.Size(153, 58);
            this.btnMoveToPendingSaleOrders.Style = MetroFramework.MetroColorStyle.Red;
            this.btnMoveToPendingSaleOrders.TabIndex = 10;
            this.btnMoveToPendingSaleOrders.Text = "Mover a pendientes";
            this.btnMoveToPendingSaleOrders.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMoveToPendingSaleOrders.UseSelectable = true;
            this.btnMoveToPendingSaleOrders.Click += new System.EventHandler(this.btnMoveToPendingSaleOrders_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.ActiveControl = null;
            this.btnAddProducts.BackColor = System.Drawing.Color.White;
            this.btnAddProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddProducts.Location = new System.Drawing.Point(169, 3);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(160, 58);
            this.btnAddProducts.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnAddProducts.TabIndex = 9;
            this.btnAddProducts.Text = "Añadir productos";
            this.btnAddProducts.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAddProducts.UseSelectable = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnMoveAllToOtherTable
            // 
            this.btnMoveAllToOtherTable.ActiveControl = null;
            this.btnMoveAllToOtherTable.BackColor = System.Drawing.Color.White;
            this.btnMoveAllToOtherTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnMoveAllToOtherTable.Location = new System.Drawing.Point(660, 3);
            this.btnMoveAllToOtherTable.Name = "btnMoveAllToOtherTable";
            this.btnMoveAllToOtherTable.Size = new System.Drawing.Size(153, 58);
            this.btnMoveAllToOtherTable.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnMoveAllToOtherTable.TabIndex = 8;
            this.btnMoveAllToOtherTable.Text = "Mover a otra mesa";
            this.btnMoveAllToOtherTable.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMoveAllToOtherTable.UseSelectable = true;
            this.btnMoveAllToOtherTable.Click += new System.EventHandler(this.btnMoveAllToOtherTable_Click);
            // 
            // btnPaySelectedSale
            // 
            this.btnPaySelectedSale.ActiveControl = null;
            this.btnPaySelectedSale.BackColor = System.Drawing.Color.White;
            this.btnPaySelectedSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnPaySelectedSale.Location = new System.Drawing.Point(3, 3);
            this.btnPaySelectedSale.Name = "btnPaySelectedSale";
            this.btnPaySelectedSale.Size = new System.Drawing.Size(160, 58);
            this.btnPaySelectedSale.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPaySelectedSale.TabIndex = 7;
            this.btnPaySelectedSale.Text = "Cobrar";
            this.btnPaySelectedSale.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnPaySelectedSale.UseSelectable = true;
            this.btnPaySelectedSale.Click += new System.EventHandler(this.btnPaySelectedSaleOrder_Click);
            // 
            // btnNewSale
            // 
            this.btnNewSale.ActiveControl = null;
            this.btnNewSale.BackColor = System.Drawing.Color.White;
            this.btnNewSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnNewSale.Location = new System.Drawing.Point(818, 3);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(153, 58);
            this.btnNewSale.Style = MetroFramework.MetroColorStyle.Green;
            this.btnNewSale.TabIndex = 5;
            this.btnNewSale.Text = "Nueva venta";
            this.btnNewSale.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNewSale.UseSelectable = true;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // DataGridViewTableSales
            // 
            this.DataGridViewTableSales.AllowUserToAddRows = false;
            this.DataGridViewTableSales.AllowUserToResizeRows = false;
            this.DataGridViewTableSales.AutoGenerateColumns = false;
            this.DataGridViewTableSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewTableSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewTableSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DataGridViewTableSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTableSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewTableSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTableSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.tableDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.TotalString});
            this.DataGridViewTableSales.DataSource = this.saleOrderBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTableSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTableSales.EnableHeadersVisualStyles = false;
            this.DataGridViewTableSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewTableSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewTableSales.Location = new System.Drawing.Point(20, 85);
            this.DataGridViewTableSales.MultiSelect = false;
            this.DataGridViewTableSales.Name = "DataGridViewTableSales";
            this.DataGridViewTableSales.ReadOnly = true;
            this.DataGridViewTableSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTableSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewTableSales.RowHeadersVisible = false;
            this.DataGridViewTableSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewTableSales.RowTemplate.Height = 45;
            this.DataGridViewTableSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewTableSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTableSales.Size = new System.Drawing.Size(974, 258);
            this.DataGridViewTableSales.TabIndex = 3;
            this.DataGridViewTableSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTableSaleOrders_CellClick);
            this.DataGridViewTableSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTableSaleOrders_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stationDataGridViewTextBoxColumn
            // 
            this.stationDataGridViewTextBoxColumn.DataPropertyName = "Station";
            this.stationDataGridViewTextBoxColumn.HeaderText = "Station";
            this.stationDataGridViewTextBoxColumn.Name = "stationDataGridViewTextBoxColumn";
            this.stationDataGridViewTextBoxColumn.ReadOnly = true;
            this.stationDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Fecha creación";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableDataGridViewTextBoxColumn
            // 
            this.tableDataGridViewTextBoxColumn.DataPropertyName = "Table";
            this.tableDataGridViewTextBoxColumn.HeaderText = "Table";
            this.tableDataGridViewTextBoxColumn.Name = "tableDataGridViewTextBoxColumn";
            this.tableDataGridViewTextBoxColumn.ReadOnly = true;
            this.tableDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Visible = false;
            // 
            // TotalString
            // 
            this.TotalString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalString.DataPropertyName = "TotalString";
            this.TotalString.HeaderText = "Total (€)";
            this.TotalString.Name = "TotalString";
            this.TotalString.ReadOnly = true;
            // 
            // saleOrderBindingSource
            // 
            this.saleOrderBindingSource.DataSource = typeof(Kiwi.Tpv.Database.Entities.SaleOrder);
            // 
            // txtTotalPending
            // 
            this.txtTotalPending.ActiveControl = null;
            this.txtTotalPending.BackColor = System.Drawing.Color.White;
            this.txtTotalPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.txtTotalPending.Location = new System.Drawing.Point(231, 17);
            this.txtTotalPending.Name = "txtTotalPending";
            this.txtTotalPending.Size = new System.Drawing.Size(642, 43);
            this.txtTotalPending.Style = MetroFramework.MetroColorStyle.Red;
            this.txtTotalPending.TabIndex = 58;
            this.txtTotalPending.Text = "Mesa 1 - Total: 100 €";
            this.txtTotalPending.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.txtTotalPending.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.txtTotalPending.UseSelectable = true;
            // 
            // DataGridViewTableSaleDetails
            // 
            this.DataGridViewTableSaleDetails.AllowUserToAddRows = false;
            this.DataGridViewTableSaleDetails.AllowUserToResizeRows = false;
            this.DataGridViewTableSaleDetails.AutoGenerateColumns = false;
            this.DataGridViewTableSaleDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewTableSaleDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewTableSaleDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DataGridViewTableSaleDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTableSaleDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewTableSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTableSaleDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productImageDataGridViewImageColumn,
            this.idDataGridViewTextBoxColumn1,
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.PriceString,
            this.taxPercentajeDataGridViewTextBoxColumn,
            this.isBottleDataGridViewCheckBoxColumn,
            this.totalDataGridViewTextBoxColumn1,
            this.totalStringDataGridViewTextBoxColumn});
            this.DataGridViewTableSaleDetails.DataSource = this.saleOrderDetailBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTableSaleDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewTableSaleDetails.EnableHeadersVisualStyles = false;
            this.DataGridViewTableSaleDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewTableSaleDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewTableSaleDetails.Location = new System.Drawing.Point(20, 351);
            this.DataGridViewTableSaleDetails.MultiSelect = false;
            this.DataGridViewTableSaleDetails.Name = "DataGridViewTableSaleDetails";
            this.DataGridViewTableSaleDetails.ReadOnly = true;
            this.DataGridViewTableSaleDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTableSaleDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewTableSaleDetails.RowHeadersVisible = false;
            this.DataGridViewTableSaleDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewTableSaleDetails.RowTemplate.Height = 45;
            this.DataGridViewTableSaleDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewTableSaleDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTableSaleDetails.Size = new System.Drawing.Size(974, 255);
            this.DataGridViewTableSaleDetails.TabIndex = 59;
            // 
            // productImageDataGridViewImageColumn
            // 
            this.productImageDataGridViewImageColumn.DataPropertyName = "ProductImage";
            this.productImageDataGridViewImageColumn.HeaderText = "";
            this.productImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.productImageDataGridViewImageColumn.Name = "productImageDataGridViewImageColumn";
            this.productImageDataGridViewImageColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
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
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Unidades";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Visible = false;
            // 
            // PriceString
            // 
            this.PriceString.DataPropertyName = "PriceString";
            this.PriceString.HeaderText = "Precio (€)";
            this.PriceString.Name = "PriceString";
            this.PriceString.ReadOnly = true;
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
            // totalDataGridViewTextBoxColumn1
            // 
            this.totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            this.totalDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn1.Visible = false;
            // 
            // totalStringDataGridViewTextBoxColumn
            // 
            this.totalStringDataGridViewTextBoxColumn.DataPropertyName = "TotalString";
            this.totalStringDataGridViewTextBoxColumn.HeaderText = "Total (€)";
            this.totalStringDataGridViewTextBoxColumn.Name = "totalStringDataGridViewTextBoxColumn";
            this.totalStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleOrderDetailBindingSource
            // 
            this.saleOrderDetailBindingSource.DataSource = typeof(Kiwi.Tpv.Database.Entities.SaleOrderDetail);
            // 
            // FrmTableSaleOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 696);
            this.ControlBox = false;
            this.Controls.Add(this.DataGridViewTableSaleDetails);
            this.Controls.Add(this.txtTotalPending);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.DataGridViewTableSales);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmTableSaleOrders";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frmTableSaleOrders_Load);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTableSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTableSaleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnClose;
        private MetroFramework.Controls.MetroPanel panelButtons;
        private MetroFramework.Controls.MetroGrid DataGridViewTableSales;
        private MetroFramework.Controls.MetroTile btnNewSale;
        private MetroFramework.Controls.MetroTile txtTotalPending;
        private MetroFramework.Controls.MetroGrid DataGridViewTableSaleDetails;
        private MetroFramework.Controls.MetroTile btnPaySelectedSale;
        private MetroFramework.Controls.MetroTile btnMoveAllToOtherTable;
        private System.Windows.Forms.BindingSource saleOrderBindingSource;
        private System.Windows.Forms.BindingSource saleOrderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalString;
        private System.Windows.Forms.DataGridViewImageColumn productImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceString;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxPercentajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBottleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalStringDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile btnAddProducts;
        private MetroFramework.Controls.MetroTile btnMoveToPendingSaleOrders;
    }
}