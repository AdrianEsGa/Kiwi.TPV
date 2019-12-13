namespace Kiwi.Tpv.App.Forms
{
    partial class FrmConfirmPay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmPay));
            this.txtTotalToPay = new MetroFramework.Controls.MetroTextBox();
            this.btnConfirmCash = new MetroFramework.Controls.MetroTile();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.btnInvite = new MetroFramework.Controls.MetroTile();
            this.btnDisccount = new MetroFramework.Controls.MetroTile();
            this.btnConfirmCreditCard = new MetroFramework.Controls.MetroTile();
            this.btnConfirmCashTicket = new MetroFramework.Controls.MetroTile();
            this.btnConfirmCreditCardTicket = new MetroFramework.Controls.MetroTile();
            this.DataGridViewAllSaleOrderDetails = new MetroFramework.Controls.MetroGrid();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxPercentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBottleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saleOrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelProductsToPay = new MetroFramework.Controls.MetroPanel();
            this.btnRemoveProductSelection = new MetroFramework.Controls.MetroTile();
            this.DataGridViewIndividualSaleOrderDetails = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllSaleOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDetailBindingSource)).BeginInit();
            this.PanelProductsToPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIndividualSaleOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalToPay
            // 
            this.txtTotalToPay.BackColor = System.Drawing.SystemColors.ControlDark;
            // 
            // 
            // 
            this.txtTotalToPay.CustomButton.Image = null;
            this.txtTotalToPay.CustomButton.Location = new System.Drawing.Point(471, 2);
            this.txtTotalToPay.CustomButton.Name = "";
            this.txtTotalToPay.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtTotalToPay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalToPay.CustomButton.TabIndex = 1;
            this.txtTotalToPay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalToPay.CustomButton.UseSelectable = true;
            this.txtTotalToPay.CustomButton.Visible = false;
            this.txtTotalToPay.Enabled = false;
            this.txtTotalToPay.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTotalToPay.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTotalToPay.ForeColor = System.Drawing.Color.Green;
            this.txtTotalToPay.Lines = new string[] {
        "0"};
            this.txtTotalToPay.Location = new System.Drawing.Point(537, 69);
            this.txtTotalToPay.MaxLength = 32767;
            this.txtTotalToPay.Name = "txtTotalToPay";
            this.txtTotalToPay.PasswordChar = '\0';
            this.txtTotalToPay.ReadOnly = true;
            this.txtTotalToPay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalToPay.SelectedText = "";
            this.txtTotalToPay.SelectionLength = 0;
            this.txtTotalToPay.SelectionStart = 0;
            this.txtTotalToPay.ShortcutsEnabled = true;
            this.txtTotalToPay.Size = new System.Drawing.Size(509, 40);
            this.txtTotalToPay.TabIndex = 1;
            this.txtTotalToPay.Text = "0";
            this.txtTotalToPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalToPay.UseSelectable = true;
            this.txtTotalToPay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalToPay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConfirmCash
            // 
            this.btnConfirmCash.ActiveControl = null;
            this.btnConfirmCash.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmCash.Location = new System.Drawing.Point(537, 211);
            this.btnConfirmCash.Name = "btnConfirmCash";
            this.btnConfirmCash.Size = new System.Drawing.Size(252, 162);
            this.btnConfirmCash.Style = MetroFramework.MetroColorStyle.Green;
            this.btnConfirmCash.TabIndex = 4;
            this.btnConfirmCash.Text = "Confirmar Efectivo";
            this.btnConfirmCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmCash.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnConfirmCash.UseSelectable = true;
            this.btnConfirmCash.Click += new System.EventHandler(this.btnConfirmCash_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(537, 561);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(511, 122);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInvite
            // 
            this.btnInvite.ActiveControl = null;
            this.btnInvite.Location = new System.Drawing.Point(795, 134);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(252, 57);
            this.btnInvite.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnInvite.TabIndex = 3;
            this.btnInvite.Text = "Invitar";
            this.btnInvite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInvite.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnInvite.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnInvite.UseSelectable = true;
            this.btnInvite.Click += new System.EventHandler(this.btnInvite_Click);
            // 
            // btnDisccount
            // 
            this.btnDisccount.ActiveControl = null;
            this.btnDisccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDisccount.ForeColor = System.Drawing.Color.Coral;
            this.btnDisccount.Location = new System.Drawing.Point(537, 134);
            this.btnDisccount.Name = "btnDisccount";
            this.btnDisccount.Size = new System.Drawing.Size(252, 57);
            this.btnDisccount.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnDisccount.TabIndex = 2;
            this.btnDisccount.Text = "Dto 1€";
            this.btnDisccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDisccount.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDisccount.UseSelectable = true;
            this.btnDisccount.Click += new System.EventHandler(this.btnDisccount_Click);
            // 
            // btnConfirmCreditCard
            // 
            this.btnConfirmCreditCard.ActiveControl = null;
            this.btnConfirmCreditCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmCreditCard.Location = new System.Drawing.Point(795, 211);
            this.btnConfirmCreditCard.Name = "btnConfirmCreditCard";
            this.btnConfirmCreditCard.Size = new System.Drawing.Size(252, 162);
            this.btnConfirmCreditCard.Style = MetroFramework.MetroColorStyle.Green;
            this.btnConfirmCreditCard.TabIndex = 6;
            this.btnConfirmCreditCard.Text = "Confirmar Tarjeta";
            this.btnConfirmCreditCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmCreditCard.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnConfirmCreditCard.UseSelectable = true;
            this.btnConfirmCreditCard.Click += new System.EventHandler(this.btnConfirmCreditCard_Click);
            // 
            // btnConfirmCashTicket
            // 
            this.btnConfirmCashTicket.ActiveControl = null;
            this.btnConfirmCashTicket.Location = new System.Drawing.Point(537, 379);
            this.btnConfirmCashTicket.Name = "btnConfirmCashTicket";
            this.btnConfirmCashTicket.Size = new System.Drawing.Size(252, 162);
            this.btnConfirmCashTicket.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnConfirmCashTicket.TabIndex = 7;
            this.btnConfirmCashTicket.Text = "Confirmar Efectivo Ticket";
            this.btnConfirmCashTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmCashTicket.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnConfirmCashTicket.UseSelectable = true;
            this.btnConfirmCashTicket.Click += new System.EventHandler(this.btnConfirmCashTicket_Click);
            // 
            // btnConfirmCreditCardTicket
            // 
            this.btnConfirmCreditCardTicket.ActiveControl = null;
            this.btnConfirmCreditCardTicket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmCreditCardTicket.ForeColor = System.Drawing.Color.Green;
            this.btnConfirmCreditCardTicket.Location = new System.Drawing.Point(795, 379);
            this.btnConfirmCreditCardTicket.Name = "btnConfirmCreditCardTicket";
            this.btnConfirmCreditCardTicket.Size = new System.Drawing.Size(252, 162);
            this.btnConfirmCreditCardTicket.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnConfirmCreditCardTicket.TabIndex = 8;
            this.btnConfirmCreditCardTicket.Text = "Confirmar Tarjeta Ticket";
            this.btnConfirmCreditCardTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmCreditCardTicket.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnConfirmCreditCardTicket.UseSelectable = true;
            this.btnConfirmCreditCardTicket.Click += new System.EventHandler(this.btnConfirmCreditCardTicket_Click);
            // 
            // DataGridViewAllSaleOrderDetails
            // 
            this.DataGridViewAllSaleOrderDetails.AllowUserToAddRows = false;
            this.DataGridViewAllSaleOrderDetails.AllowUserToDeleteRows = false;
            this.DataGridViewAllSaleOrderDetails.AllowUserToResizeColumns = false;
            this.DataGridViewAllSaleOrderDetails.AllowUserToResizeRows = false;
            this.DataGridViewAllSaleOrderDetails.AutoGenerateColumns = false;
            this.DataGridViewAllSaleOrderDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewAllSaleOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewAllSaleOrderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewAllSaleOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAllSaleOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewAllSaleOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAllSaleOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductImage,
            this.idDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.TotalString,
            this.taxPercentajeDataGridViewTextBoxColumn,
            this.isBottleDataGridViewCheckBoxColumn});
            this.DataGridViewAllSaleOrderDetails.DataSource = this.saleOrderDetailBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewAllSaleOrderDetails.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewAllSaleOrderDetails.EnableHeadersVisualStyles = false;
            this.DataGridViewAllSaleOrderDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewAllSaleOrderDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewAllSaleOrderDetails.Location = new System.Drawing.Point(23, 90);
            this.DataGridViewAllSaleOrderDetails.MultiSelect = false;
            this.DataGridViewAllSaleOrderDetails.Name = "DataGridViewAllSaleOrderDetails";
            this.DataGridViewAllSaleOrderDetails.ReadOnly = true;
            this.DataGridViewAllSaleOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAllSaleOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewAllSaleOrderDetails.RowHeadersVisible = false;
            this.DataGridViewAllSaleOrderDetails.RowHeadersWidth = 70;
            this.DataGridViewAllSaleOrderDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewAllSaleOrderDetails.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAllSaleOrderDetails.RowTemplate.Height = 47;
            this.DataGridViewAllSaleOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAllSaleOrderDetails.Size = new System.Drawing.Size(496, 286);
            this.DataGridViewAllSaleOrderDetails.Style = MetroFramework.MetroColorStyle.Lime;
            this.DataGridViewAllSaleOrderDetails.TabIndex = 9;
            this.DataGridViewAllSaleOrderDetails.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DataGridViewAllSaleOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAllSaleOrderDetails_CellClick);
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
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Unidades";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.TotalString.Width = 70;
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
            // saleOrderDetailBindingSource
            // 
            this.saleOrderDetailBindingSource.DataSource = typeof(Kiwi.Tpv.Database.Entities.SaleOrderDetail);
            // 
            // PanelProductsToPay
            // 
            this.PanelProductsToPay.Controls.Add(this.btnRemoveProductSelection);
            this.PanelProductsToPay.Controls.Add(this.DataGridViewIndividualSaleOrderDetails);
            this.PanelProductsToPay.Controls.Add(this.metroLabel1);
            this.PanelProductsToPay.HorizontalScrollbarBarColor = true;
            this.PanelProductsToPay.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelProductsToPay.HorizontalScrollbarSize = 10;
            this.PanelProductsToPay.Location = new System.Drawing.Point(23, 379);
            this.PanelProductsToPay.Name = "PanelProductsToPay";
            this.PanelProductsToPay.Size = new System.Drawing.Size(496, 304);
            this.PanelProductsToPay.TabIndex = 10;
            this.PanelProductsToPay.VerticalScrollbarBarColor = true;
            this.PanelProductsToPay.VerticalScrollbarHighlightOnWheel = false;
            this.PanelProductsToPay.VerticalScrollbarSize = 10;
            this.PanelProductsToPay.Visible = false;
            // 
            // btnRemoveProductSelection
            // 
            this.btnRemoveProductSelection.ActiveControl = null;
            this.btnRemoveProductSelection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveProductSelection.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveProductSelection.Location = new System.Drawing.Point(0, 265);
            this.btnRemoveProductSelection.Name = "btnRemoveProductSelection";
            this.btnRemoveProductSelection.Size = new System.Drawing.Size(496, 39);
            this.btnRemoveProductSelection.Style = MetroFramework.MetroColorStyle.Red;
            this.btnRemoveProductSelection.TabIndex = 6;
            this.btnRemoveProductSelection.Text = "Deshacer selección";
            this.btnRemoveProductSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveProductSelection.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnRemoveProductSelection.UseSelectable = true;
            this.btnRemoveProductSelection.Click += new System.EventHandler(this.btnRemoveProductSelection_Click);
            // 
            // DataGridViewIndividualSaleOrderDetails
            // 
            this.DataGridViewIndividualSaleOrderDetails.AllowUserToAddRows = false;
            this.DataGridViewIndividualSaleOrderDetails.AllowUserToDeleteRows = false;
            this.DataGridViewIndividualSaleOrderDetails.AllowUserToResizeColumns = false;
            this.DataGridViewIndividualSaleOrderDetails.AllowUserToResizeRows = false;
            this.DataGridViewIndividualSaleOrderDetails.AutoGenerateColumns = false;
            this.DataGridViewIndividualSaleOrderDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewIndividualSaleOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewIndividualSaleOrderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewIndividualSaleOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewIndividualSaleOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewIndividualSaleOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewIndividualSaleOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.DataGridViewIndividualSaleOrderDetails.DataSource = this.saleOrderDetailBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewIndividualSaleOrderDetails.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewIndividualSaleOrderDetails.EnableHeadersVisualStyles = false;
            this.DataGridViewIndividualSaleOrderDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewIndividualSaleOrderDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewIndividualSaleOrderDetails.Location = new System.Drawing.Point(0, 22);
            this.DataGridViewIndividualSaleOrderDetails.MultiSelect = false;
            this.DataGridViewIndividualSaleOrderDetails.Name = "DataGridViewIndividualSaleOrderDetails";
            this.DataGridViewIndividualSaleOrderDetails.ReadOnly = true;
            this.DataGridViewIndividualSaleOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewIndividualSaleOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewIndividualSaleOrderDetails.RowHeadersVisible = false;
            this.DataGridViewIndividualSaleOrderDetails.RowHeadersWidth = 70;
            this.DataGridViewIndividualSaleOrderDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewIndividualSaleOrderDetails.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewIndividualSaleOrderDetails.RowTemplate.Height = 47;
            this.DataGridViewIndividualSaleOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewIndividualSaleOrderDetails.Size = new System.Drawing.Size(496, 237);
            this.DataGridViewIndividualSaleOrderDetails.Style = MetroFramework.MetroColorStyle.Lime;
            this.DataGridViewIndividualSaleOrderDetails.TabIndex = 3;
            this.DataGridViewIndividualSaleOrderDetails.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ProductImage";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalString";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TaxPercentaje";
            this.dataGridViewTextBoxColumn6.HeaderText = "TaxPercentaje";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsBottle";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsBottle";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(190, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Productos de venta individual";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(342, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Selecciona productos para realizar una venta individual";
            // 
            // FrmConfirmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 696);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.PanelProductsToPay);
            this.Controls.Add(this.DataGridViewAllSaleOrderDetails);
            this.Controls.Add(this.txtTotalToPay);
            this.Controls.Add(this.btnConfirmCreditCardTicket);
            this.Controls.Add(this.btnConfirmCashTicket);
            this.Controls.Add(this.btnConfirmCreditCard);
            this.Controls.Add(this.btnDisccount);
            this.Controls.Add(this.btnInvite);
            this.Controls.Add(this.btnConfirmCash);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmConfirmPay";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Realizar venta";
            this.Load += new System.EventHandler(this.FrmConfirmPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllSaleOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDetailBindingSource)).EndInit();
            this.PanelProductsToPay.ResumeLayout(false);
            this.PanelProductsToPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIndividualSaleOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtTotalToPay;
        private MetroFramework.Controls.MetroTile btnConfirmCash;
        private MetroFramework.Controls.MetroTile btnCancel;
        private MetroFramework.Controls.MetroTile btnInvite;
        private MetroFramework.Controls.MetroTile btnDisccount;
        private MetroFramework.Controls.MetroTile btnConfirmCreditCard;
        private MetroFramework.Controls.MetroTile btnConfirmCashTicket;
        private MetroFramework.Controls.MetroTile btnConfirmCreditCardTicket;
        private System.Windows.Forms.BindingSource saleOrderDetailBindingSource;
        private MetroFramework.Controls.MetroGrid DataGridViewAllSaleOrderDetails;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalString;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxPercentajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBottleDataGridViewCheckBoxColumn;
        private MetroFramework.Controls.MetroPanel PanelProductsToPay;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid DataGridViewIndividualSaleOrderDetails;
        private MetroFramework.Controls.MetroTile btnRemoveProductSelection;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}