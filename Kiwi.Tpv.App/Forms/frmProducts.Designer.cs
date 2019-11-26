using System.Windows.Forms;
using MetroFramework.Controls;

namespace Kiwi.Tpv.App.Forms
{
    partial class FrmProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbProductSubType = new MetroFramework.Controls.MetroComboBox();
            this.txtPurchaseUnits = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.TxtPurchasePrice = new MetroFramework.Controls.MetroTextBox();
            this.cbPurchaseTaxTypes = new MetroFramework.Controls.MetroComboBox();
            this.lblNightPrice = new MetroFramework.Controls.MetroLabel();
            this.TxtSaleNightPrice = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.txtSaleUnits = new MetroFramework.Controls.MetroTextBox();
            this.cbSaleTaxTypes = new MetroFramework.Controls.MetroComboBox();
            this.lblActive = new MetroFramework.Controls.MetroLabel();
            this.CbProductType = new MetroFramework.Controls.MetroComboBox();
            this.LblProductType = new MetroFramework.Controls.MetroLabel();
            this.LblProductName = new MetroFramework.Controls.MetroLabel();
            this.LblProductId = new MetroFramework.Controls.MetroLabel();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnRemove = new MetroFramework.Controls.MetroTile();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.tabProducts = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageFicha = new MetroFramework.Controls.MetroTabPage();
            this.chkShowInMainView = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BtnRemoveImage = new MetroFramework.Controls.MetroButton();
            this.SalePanel = new MetroFramework.Controls.MetroPanel();
            this.SodaPrices = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtSaleCombinedPrice = new MetroFramework.Controls.MetroTextBox();
            this.AlcoholPricesPanel = new MetroFramework.Controls.MetroPanel();
            this.lblShotDayPrice = new MetroFramework.Controls.MetroLabel();
            this.TxtSaleShotNightPrice = new MetroFramework.Controls.MetroTextBox();
            this.TxtSaleShotDayPrice = new MetroFramework.Controls.MetroTextBox();
            this.lblShotNightPrice = new MetroFramework.Controls.MetroLabel();
            this.lblCupNightPrice = new MetroFramework.Controls.MetroLabel();
            this.TxtSaleCupNightPrice = new MetroFramework.Controls.MetroTextBox();
            this.TxtSaleCupDayPrice = new MetroFramework.Controls.MetroTextBox();
            this.lblCupDayPrice = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblDayPrice = new MetroFramework.Controls.MetroLabel();
            this.TxtSaleDayPrice = new MetroFramework.Controls.MetroTextBox();
            this.PurchasePanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxProductImage = new MetroFramework.Controls.MetroButton();
            this.TxtProductName = new MetroFramework.Controls.MetroTextBox();
            this.TxtProductId = new MetroFramework.Controls.MetroTextBox();
            this.chkActive = new MetroFramework.Controls.MetroToggle();
            this.metroTabPageBusqueda = new MetroFramework.Controls.MetroTabPage();
            this.DataGridViewProducts = new MetroFramework.Controls.MetroGrid();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDayPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleNightPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTaxTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseTaxTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saleUnitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseUnitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProducts.SuspendLayout();
            this.metroTabPageFicha.SuspendLayout();
            this.SalePanel.SuspendLayout();
            this.SodaPrices.SuspendLayout();
            this.AlcoholPricesPanel.SuspendLayout();
            this.PurchasePanel.SuspendLayout();
            this.metroTabPageBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CbProductSubType
            // 
            this.CbProductSubType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.CbProductSubType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbProductSubType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProductSubType.FormattingEnabled = true;
            this.CbProductSubType.ItemHeight = 23;
            this.CbProductSubType.Location = new System.Drawing.Point(278, 70);
            this.CbProductSubType.Name = "CbProductSubType";
            this.CbProductSubType.Size = new System.Drawing.Size(152, 29);
            this.CbProductSubType.TabIndex = 85;
            this.CbProductSubType.UseSelectable = true;
            this.CbProductSubType.Visible = false;
            // 
            // txtPurchaseUnits
            // 
            this.txtPurchaseUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.txtPurchaseUnits.CustomButton.Image = null;
            this.txtPurchaseUnits.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.txtPurchaseUnits.CustomButton.Name = "";
            this.txtPurchaseUnits.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtPurchaseUnits.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPurchaseUnits.CustomButton.TabIndex = 1;
            this.txtPurchaseUnits.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPurchaseUnits.CustomButton.UseSelectable = true;
            this.txtPurchaseUnits.CustomButton.Visible = false;
            this.txtPurchaseUnits.Lines = new string[0];
            this.txtPurchaseUnits.Location = new System.Drawing.Point(122, 104);
            this.txtPurchaseUnits.MaxLength = 6;
            this.txtPurchaseUnits.Name = "txtPurchaseUnits";
            this.txtPurchaseUnits.PasswordChar = '\0';
            this.txtPurchaseUnits.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPurchaseUnits.SelectedText = "";
            this.txtPurchaseUnits.SelectionLength = 0;
            this.txtPurchaseUnits.SelectionStart = 0;
            this.txtPurchaseUnits.ShortcutsEnabled = true;
            this.txtPurchaseUnits.Size = new System.Drawing.Size(131, 22);
            this.txtPurchaseUnits.TabIndex = 67;
            this.txtPurchaseUnits.UseSelectable = true;
            this.txtPurchaseUnits.Visible = false;
            this.txtPurchaseUnits.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPurchaseUnits.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPurchaseUnits.TextChanged += new System.EventHandler(this.txtPurchaseUnits_TextChanged);
            this.txtPurchaseUnits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchaseUnits_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "% I.V.A.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 66;
            this.label3.Text = "Und. + Stock";
            this.label3.Visible = false;
            // 
            // TxtPurchasePrice
            // 
            this.TxtPurchasePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtPurchasePrice.CustomButton.Image = null;
            this.TxtPurchasePrice.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.TxtPurchasePrice.CustomButton.Name = "";
            this.TxtPurchasePrice.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtPurchasePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPurchasePrice.CustomButton.TabIndex = 1;
            this.TxtPurchasePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPurchasePrice.CustomButton.UseSelectable = true;
            this.TxtPurchasePrice.CustomButton.Visible = false;
            this.TxtPurchasePrice.Lines = new string[0];
            this.TxtPurchasePrice.Location = new System.Drawing.Point(122, 41);
            this.TxtPurchasePrice.MaxLength = 6;
            this.TxtPurchasePrice.Name = "TxtPurchasePrice";
            this.TxtPurchasePrice.PasswordChar = '\0';
            this.TxtPurchasePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPurchasePrice.SelectedText = "";
            this.TxtPurchasePrice.SelectionLength = 0;
            this.TxtPurchasePrice.SelectionStart = 0;
            this.TxtPurchasePrice.ShortcutsEnabled = true;
            this.TxtPurchasePrice.Size = new System.Drawing.Size(131, 22);
            this.TxtPurchasePrice.TabIndex = 62;
            this.TxtPurchasePrice.UseSelectable = true;
            this.TxtPurchasePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPurchasePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPurchasePrice.TextChanged += new System.EventHandler(this.TxtPurchasePrice_TextChanged);
            this.TxtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPurchasePrice_KeyPress);
            // 
            // cbPurchaseTaxTypes
            // 
            this.cbPurchaseTaxTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbPurchaseTaxTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPurchaseTaxTypes.FormattingEnabled = true;
            this.cbPurchaseTaxTypes.ItemHeight = 23;
            this.cbPurchaseTaxTypes.Location = new System.Drawing.Point(122, 69);
            this.cbPurchaseTaxTypes.Name = "cbPurchaseTaxTypes";
            this.cbPurchaseTaxTypes.Size = new System.Drawing.Size(131, 29);
            this.cbPurchaseTaxTypes.TabIndex = 63;
            this.cbPurchaseTaxTypes.UseSelectable = true;
            // 
            // lblNightPrice
            // 
            this.lblNightPrice.AutoSize = true;
            this.lblNightPrice.Location = new System.Drawing.Point(13, 64);
            this.lblNightPrice.Name = "lblNightPrice";
            this.lblNightPrice.Size = new System.Drawing.Size(96, 19);
            this.lblNightPrice.TabIndex = 48;
            this.lblNightPrice.Text = "Precio (Noche)";
            // 
            // TxtSaleNightPrice
            // 
            this.TxtSaleNightPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtSaleNightPrice.CustomButton.Image = null;
            this.TxtSaleNightPrice.CustomButton.Location = new System.Drawing.Point(36, 2);
            this.TxtSaleNightPrice.CustomButton.Name = "";
            this.TxtSaleNightPrice.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtSaleNightPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSaleNightPrice.CustomButton.TabIndex = 1;
            this.TxtSaleNightPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSaleNightPrice.CustomButton.UseSelectable = true;
            this.TxtSaleNightPrice.CustomButton.Visible = false;
            this.TxtSaleNightPrice.Lines = new string[0];
            this.TxtSaleNightPrice.Location = new System.Drawing.Point(153, 67);
            this.TxtSaleNightPrice.MaxLength = 6;
            this.TxtSaleNightPrice.Name = "TxtSaleNightPrice";
            this.TxtSaleNightPrice.PasswordChar = '\0';
            this.TxtSaleNightPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSaleNightPrice.SelectedText = "";
            this.TxtSaleNightPrice.SelectionLength = 0;
            this.TxtSaleNightPrice.SelectionStart = 0;
            this.TxtSaleNightPrice.ShortcutsEnabled = true;
            this.TxtSaleNightPrice.Size = new System.Drawing.Size(56, 22);
            this.TxtSaleNightPrice.TabIndex = 49;
            this.TxtSaleNightPrice.UseSelectable = true;
            this.TxtSaleNightPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSaleNightPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSaleNightPrice.TextChanged += new System.EventHandler(this.TxtSalePrice_TextChanged);
            this.TxtSaleNightPrice.Click += new System.EventHandler(this.TxtSaleNightPrice_Click);
            this.TxtSaleNightPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSalePrice_KeyPress);
            this.TxtSaleNightPrice.Validated += new System.EventHandler(this.TxtSaleNightPrice_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 64;
            this.label4.Text = "Und. - Stock";
            this.label4.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "% I.V.A.";
            // 
            // txtSaleUnits
            // 
            this.txtSaleUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.txtSaleUnits.CustomButton.Image = null;
            this.txtSaleUnits.CustomButton.Location = new System.Drawing.Point(22, 2);
            this.txtSaleUnits.CustomButton.Name = "";
            this.txtSaleUnits.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtSaleUnits.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSaleUnits.CustomButton.TabIndex = 1;
            this.txtSaleUnits.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSaleUnits.CustomButton.UseSelectable = true;
            this.txtSaleUnits.CustomButton.Visible = false;
            this.txtSaleUnits.Lines = new string[0];
            this.txtSaleUnits.Location = new System.Drawing.Point(438, 132);
            this.txtSaleUnits.MaxLength = 6;
            this.txtSaleUnits.Name = "txtSaleUnits";
            this.txtSaleUnits.PasswordChar = '\0';
            this.txtSaleUnits.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSaleUnits.SelectedText = "";
            this.txtSaleUnits.SelectionLength = 0;
            this.txtSaleUnits.SelectionStart = 0;
            this.txtSaleUnits.ShortcutsEnabled = true;
            this.txtSaleUnits.Size = new System.Drawing.Size(42, 22);
            this.txtSaleUnits.TabIndex = 65;
            this.txtSaleUnits.UseSelectable = true;
            this.txtSaleUnits.Visible = false;
            this.txtSaleUnits.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSaleUnits.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSaleUnits.TextChanged += new System.EventHandler(this.txtSaleUnits_TextChanged);
            this.txtSaleUnits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleUnits_KeyPress);
            // 
            // cbSaleTaxTypes
            // 
            this.cbSaleTaxTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cbSaleTaxTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSaleTaxTypes.FormattingEnabled = true;
            this.cbSaleTaxTypes.ItemHeight = 23;
            this.cbSaleTaxTypes.Location = new System.Drawing.Point(153, 29);
            this.cbSaleTaxTypes.Name = "cbSaleTaxTypes";
            this.cbSaleTaxTypes.Size = new System.Drawing.Size(56, 29);
            this.cbSaleTaxTypes.TabIndex = 59;
            this.cbSaleTaxTypes.UseSelectable = true;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(5, 147);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(45, 19);
            this.lblActive.TabIndex = 81;
            this.lblActive.Text = "Activo";
            // 
            // CbProductType
            // 
            this.CbProductType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.CbProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProductType.FormattingEnabled = true;
            this.CbProductType.ItemHeight = 23;
            this.CbProductType.Location = new System.Drawing.Point(120, 71);
            this.CbProductType.Name = "CbProductType";
            this.CbProductType.Size = new System.Drawing.Size(152, 29);
            this.CbProductType.TabIndex = 79;
            this.CbProductType.UseSelectable = true;
            this.CbProductType.SelectionChangeCommitted += new System.EventHandler(this.CbProductType_SelectionChangeCommitted);
            // 
            // LblProductType
            // 
            this.LblProductType.AutoSize = true;
            this.LblProductType.ForeColor = System.Drawing.Color.Black;
            this.LblProductType.Location = new System.Drawing.Point(5, 71);
            this.LblProductType.Name = "LblProductType";
            this.LblProductType.Size = new System.Drawing.Size(35, 19);
            this.LblProductType.TabIndex = 78;
            this.LblProductType.Text = "Tipo";
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Location = new System.Drawing.Point(5, 109);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(59, 19);
            this.LblProductName.TabIndex = 72;
            this.LblProductName.Text = "Nombre";
            // 
            // LblProductId
            // 
            this.LblProductId.AutoSize = true;
            this.LblProductId.Location = new System.Drawing.Point(5, 33);
            this.LblProductId.Name = "LblProductId";
            this.LblProductId.Size = new System.Drawing.Size(82, 19);
            this.LblProductId.TabIndex = 71;
            this.LblProductId.Text = "Identificador";
            // 
            // btnNew
            // 
            this.btnNew.ActiveControl = null;
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnNew.Location = new System.Drawing.Point(493, 395);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 48);
            this.btnNew.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNew.TabIndex = 89;
            this.btnNew.Text = "Nuevo";
            this.btnNew.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnSave.Location = new System.Drawing.Point(715, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 48);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Guardar";
            this.btnSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ActiveControl = null;
            this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnRemove.Location = new System.Drawing.Point(604, 395);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 48);
            this.btnRemove.Style = MetroFramework.MetroColorStyle.Red;
            this.btnRemove.TabIndex = 88;
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveControl = null;
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnSearch.Location = new System.Drawing.Point(5, 395);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 48);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSearch.TabIndex = 86;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.metroTabPageFicha);
            this.tabProducts.Controls.Add(this.metroTabPageBusqueda);
            this.tabProducts.Location = new System.Drawing.Point(23, 69);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.SelectedIndex = 0;
            this.tabProducts.Size = new System.Drawing.Size(824, 488);
            this.tabProducts.TabIndex = 90;
            this.tabProducts.UseSelectable = true;
            // 
            // metroTabPageFicha
            // 
            this.metroTabPageFicha.Controls.Add(this.chkShowInMainView);
            this.metroTabPageFicha.Controls.Add(this.metroLabel4);
            this.metroTabPageFicha.Controls.Add(this.BtnRemoveImage);
            this.metroTabPageFicha.Controls.Add(this.SalePanel);
            this.metroTabPageFicha.Controls.Add(this.PurchasePanel);
            this.metroTabPageFicha.Controls.Add(this.pictureBoxProductImage);
            this.metroTabPageFicha.Controls.Add(this.TxtProductName);
            this.metroTabPageFicha.Controls.Add(this.TxtProductId);
            this.metroTabPageFicha.Controls.Add(this.chkActive);
            this.metroTabPageFicha.Controls.Add(this.CbProductSubType);
            this.metroTabPageFicha.Controls.Add(this.btnNew);
            this.metroTabPageFicha.Controls.Add(this.btnSave);
            this.metroTabPageFicha.Controls.Add(this.lblActive);
            this.metroTabPageFicha.Controls.Add(this.btnSearch);
            this.metroTabPageFicha.Controls.Add(this.btnRemove);
            this.metroTabPageFicha.Controls.Add(this.CbProductType);
            this.metroTabPageFicha.Controls.Add(this.LblProductType);
            this.metroTabPageFicha.Controls.Add(this.LblProductId);
            this.metroTabPageFicha.Controls.Add(this.LblProductName);
            this.metroTabPageFicha.HorizontalScrollbarBarColor = true;
            this.metroTabPageFicha.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageFicha.HorizontalScrollbarSize = 10;
            this.metroTabPageFicha.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageFicha.Name = "metroTabPageFicha";
            this.metroTabPageFicha.Size = new System.Drawing.Size(816, 446);
            this.metroTabPageFicha.TabIndex = 0;
            this.metroTabPageFicha.Text = "Ficha";
            this.metroTabPageFicha.VerticalScrollbarBarColor = true;
            this.metroTabPageFicha.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageFicha.VerticalScrollbarSize = 10;
            // 
            // chkShowInMainView
            // 
            this.chkShowInMainView.AutoSize = true;
            this.chkShowInMainView.Location = new System.Drawing.Point(383, 147);
            this.chkShowInMainView.Name = "chkShowInMainView";
            this.chkShowInMainView.Size = new System.Drawing.Size(80, 17);
            this.chkShowInMainView.TabIndex = 99;
            this.chkShowInMainView.Text = "Off";
            this.chkShowInMainView.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(262, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 98;
            this.metroLabel4.Text = "Principal";
            // 
            // BtnRemoveImage
            // 
            this.BtnRemoveImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRemoveImage.Location = new System.Drawing.Point(694, 208);
            this.BtnRemoveImage.Name = "BtnRemoveImage";
            this.BtnRemoveImage.Size = new System.Drawing.Size(67, 31);
            this.BtnRemoveImage.TabIndex = 103;
            this.BtnRemoveImage.Text = "X";
            this.BtnRemoveImage.UseSelectable = true;
            this.BtnRemoveImage.Click += new System.EventHandler(this.BtnRemoveImage_Click);
            // 
            // SalePanel
            // 
            this.SalePanel.Controls.Add(this.SodaPrices);
            this.SalePanel.Controls.Add(this.AlcoholPricesPanel);
            this.SalePanel.Controls.Add(this.metroLabel1);
            this.SalePanel.Controls.Add(this.cbSaleTaxTypes);
            this.SalePanel.Controls.Add(this.txtSaleUnits);
            this.SalePanel.Controls.Add(this.lblDayPrice);
            this.SalePanel.Controls.Add(this.label7);
            this.SalePanel.Controls.Add(this.TxtSaleDayPrice);
            this.SalePanel.Controls.Add(this.label4);
            this.SalePanel.Controls.Add(this.TxtSaleNightPrice);
            this.SalePanel.Controls.Add(this.lblNightPrice);
            this.SalePanel.HorizontalScrollbarBarColor = true;
            this.SalePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.SalePanel.HorizontalScrollbarSize = 10;
            this.SalePanel.Location = new System.Drawing.Point(5, 204);
            this.SalePanel.Name = "SalePanel";
            this.SalePanel.Size = new System.Drawing.Size(640, 165);
            this.SalePanel.TabIndex = 102;
            this.SalePanel.VerticalScrollbarBarColor = true;
            this.SalePanel.VerticalScrollbarHighlightOnWheel = false;
            this.SalePanel.VerticalScrollbarSize = 10;
            // 
            // SodaPrices
            // 
            this.SodaPrices.Controls.Add(this.metroLabel3);
            this.SodaPrices.Controls.Add(this.TxtSaleCombinedPrice);
            this.SodaPrices.HorizontalScrollbarBarColor = true;
            this.SodaPrices.HorizontalScrollbarHighlightOnWheel = false;
            this.SodaPrices.HorizontalScrollbarSize = 10;
            this.SodaPrices.Location = new System.Drawing.Point(9, 127);
            this.SodaPrices.Name = "SodaPrices";
            this.SodaPrices.Size = new System.Drawing.Size(215, 29);
            this.SodaPrices.TabIndex = 106;
            this.SodaPrices.VerticalScrollbarBarColor = true;
            this.SodaPrices.VerticalScrollbarHighlightOnWheel = false;
            this.SodaPrices.VerticalScrollbarSize = 10;
            this.SodaPrices.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 104;
            this.metroLabel3.Text = "Precio combi.";
            // 
            // TxtSaleCombinedPrice
            // 
            this.TxtSaleCombinedPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtSaleCombinedPrice.CustomButton.Image = null;
            this.TxtSaleCombinedPrice.CustomButton.Location = new System.Drawing.Point(36, 2);
            this.TxtSaleCombinedPrice.CustomButton.Name = "";
            this.TxtSaleCombinedPrice.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtSaleCombinedPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSaleCombinedPrice.CustomButton.TabIndex = 1;
            this.TxtSaleCombinedPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSaleCombinedPrice.CustomButton.UseSelectable = true;
            this.TxtSaleCombinedPrice.CustomButton.Visible = false;
            this.TxtSaleCombinedPrice.Lines = new string[0];
            this.TxtSaleCombinedPrice.Location = new System.Drawing.Point(144, 3);
            this.TxtSaleCombinedPrice.MaxLength = 6;
            this.TxtSaleCombinedPrice.Name = "TxtSaleCombinedPrice";
            this.TxtSaleCombinedPrice.PasswordChar = '\0';
            this.TxtSaleCombinedPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSaleCombinedPrice.SelectedText = "";
            this.TxtSaleCombinedPrice.SelectionLength = 0;
            this.TxtSaleCombinedPrice.SelectionStart = 0;
            this.TxtSaleCombinedPrice.ShortcutsEnabled = true;
            this.TxtSaleCombinedPrice.Size = new System.Drawing.Size(56, 22);
            this.TxtSaleCombinedPrice.TabIndex = 105;
            this.TxtSaleCombinedPrice.UseSelectable = true;
            this.TxtSaleCombinedPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSaleCombinedPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSaleCombinedPrice.Click += new System.EventHandler(this.TxtSaleCombinedPrice_Click);
            this.TxtSaleCombinedPrice.Validated += new System.EventHandler(this.TxtSaleCombinedPrice_Validated);
            // 
            // AlcoholPricesPanel
            // 
            this.AlcoholPricesPanel.Controls.Add(this.lblShotDayPrice);
            this.AlcoholPricesPanel.Controls.Add(this.TxtSaleShotNightPrice);
            this.AlcoholPricesPanel.Controls.Add(this.TxtSaleShotDayPrice);
            this.AlcoholPricesPanel.Controls.Add(this.lblShotNightPrice);
            this.AlcoholPricesPanel.Controls.Add(this.lblCupNightPrice);
            this.AlcoholPricesPanel.Controls.Add(this.TxtSaleCupNightPrice);
            this.AlcoholPricesPanel.Controls.Add(this.TxtSaleCupDayPrice);
            this.AlcoholPricesPanel.Controls.Add(this.lblCupDayPrice);
            this.AlcoholPricesPanel.HorizontalScrollbarBarColor = true;
            this.AlcoholPricesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AlcoholPricesPanel.HorizontalScrollbarSize = 10;
            this.AlcoholPricesPanel.Location = new System.Drawing.Point(215, 62);
            this.AlcoholPricesPanel.Name = "AlcoholPricesPanel";
            this.AlcoholPricesPanel.Size = new System.Drawing.Size(410, 64);
            this.AlcoholPricesPanel.TabIndex = 103;
            this.AlcoholPricesPanel.VerticalScrollbarBarColor = true;
            this.AlcoholPricesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AlcoholPricesPanel.VerticalScrollbarSize = 10;
            this.AlcoholPricesPanel.Visible = false;
            // 
            // lblShotDayPrice
            // 
            this.lblShotDayPrice.AutoSize = true;
            this.lblShotDayPrice.Location = new System.Drawing.Point(203, 35);
            this.lblShotDayPrice.Name = "lblShotDayPrice";
            this.lblShotDayPrice.Size = new System.Drawing.Size(124, 19);
            this.lblShotDayPrice.TabIndex = 104;
            this.lblShotDayPrice.Text = "Precio chupito (Día)";
            // 
            // TxtSaleShotNightPrice
            // 
            this.TxtSaleShotNightPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtSaleShotNightPrice.CustomButton.Image = null;
            this.TxtSaleShotNightPrice.CustomButton.Location = new System.Drawing.Point(36, 2);
            this.TxtSaleShotNightPrice.CustomButton.Name = "";
            this.TxtSaleShotNightPrice.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtSaleShotNightPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSaleShotNightPrice.CustomButton.TabIndex = 1;
            this.TxtSaleShotNightPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSaleShotNightPrice.CustomButton.UseSelectable = true;
            this.TxtSaleShotNightPrice.CustomButton.Visible = false;
            this.TxtSaleShotNightPrice.Lines = new string[0];
            this.TxtSaleShotNightPrice.Location = new System.Drawing.Point(348, 5);
            this.TxtSaleShotNightPrice.MaxLength = 6;
            this.TxtSaleShotNightPrice.Name = "TxtSaleShotNightPrice";
            this.TxtSaleShotNightPrice.PasswordChar = '\0';
            this.TxtSaleShotNightPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSaleShotNightPrice.SelectedText = "";
            this.TxtSaleShotNightPrice.SelectionLength = 0;
            this.TxtSaleShotNightPrice.SelectionStart = 0;
            this.TxtSaleShotNightPrice.ShortcutsEnabled = true;
            this.TxtSaleShotNightPrice.Size = new System.Drawing.Size(56, 22);
            this.TxtSaleShotNightPrice.TabIndex = 103;
            this.TxtSaleShotNightPrice.UseSelectable = true;
            this.TxtSaleShotNightPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSaleShotNightPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSaleShotNightPrice.TextChanged += new System.EventHandler(this.TxtSaleShotNightPrice_TextChanged);
            this.TxtSaleShotNightPrice.Click += new System.EventHandler(this.TxtSaleShotNightPrice_Click);
            this.TxtSaleShotNightPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaleShotNightPrice_KeyPress);
            this.TxtSaleShotNightPrice.Validated += new System.EventHandler(this.TxtSaleShotNightPrice_Validated);
            // 
            // TxtSaleShotDayPrice
            // 
            this.TxtSaleShotDayPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtSaleShotDayPrice.CustomButton.Image = null;
            this.TxtSaleShotDayPrice.CustomButton.Location = new System.Drawing.Point(36, 2);
            this.TxtSaleShotDayPrice.CustomButton.Name = "";
            this.TxtSaleShotDayPrice.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtSaleShotDayPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSaleShotDayPrice.CustomButton.TabIndex = 1;
            this.TxtSaleShotDayPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSaleShotDayPrice.CustomButton.UseSelectable = true;
            this.TxtSaleShotDayPrice.CustomButton.Visible = false;
            this.TxtSaleShotDayPrice.Lines = new string[0];
            this.TxtSaleShotDayPrice.Location = new System.Drawing.Point(348, 33);
            this.TxtSaleShotDayPrice.MaxLength = 6;
            this.TxtSaleShotDayPrice.Name = "TxtSaleShotDayPrice";
            this.TxtSaleShotDayPrice.PasswordChar = '\0';
            this.TxtSaleShotDayPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSaleShotDayPrice.SelectedText = "";
            this.TxtSaleShotDayPrice.SelectionLength = 0;
            this.TxtSaleShotDayPrice.SelectionStart = 0;
            this.TxtSaleShotDayPrice.ShortcutsEnabled = true;
            this.TxtSaleShotDayPrice.Size = new System.Drawing.Size(56, 22);
            this.TxtSaleShotDayPrice.TabIndex = 105;
            this.TxtSaleShotDayPrice.UseSelectable = true;
            this.TxtSaleShotDayPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSaleShotDayPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSaleShotDayPrice.TextChanged += new System.EventHandler(this.TxtSaleShotDayPrice_TextChanged);
            this.TxtSaleShotDayPrice.Click += new System.EventHandler(this.TxtSaleShotDayPrice_Click);
            this.TxtSaleShotDayPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaleShotDayPrice_KeyPress);
            this.TxtSaleShotDayPrice.Validated += new System.EventHandler(this.TxtSaleShotDayPrice_Validated);
            // 
            // lblShotNightPrice
            // 
            this.lblShotNightPrice.AutoSize = true;
            this.lblShotNightPrice.Location = new System.Drawing.Point(203, 5);
            this.lblShotNightPrice.Name = "lblShotNightPrice";
            this.lblShotNightPrice.Size = new System.Drawing.Size(143, 19);
            this.lblShotNightPrice.TabIndex = 102;
            this.lblShotNightPrice.Text = "Precio chupito (Noche)";
            // 
            // lblCupNightPrice
            // 
            this.lblCupNightPrice.AutoSize = true;
            this.lblCupNightPrice.Location = new System.Drawing.Point(3, 2);
            this.lblCupNightPrice.Name = "lblCupNightPrice";
            this.lblCupNightPrice.Size = new System.Drawing.Size(129, 19);
            this.lblCupNightPrice.TabIndex = 98;
            this.lblCupNightPrice.Text = "Precio copa (Noche)";
            // 
            // TxtSaleCupNightPrice
            // 
            this.TxtSaleCupNightPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtSaleCupNightPrice.CustomButton.Image = null;
            this.TxtSaleCupNightPrice.CustomButton.Location = new System.Drawing.Point(36, 2);
            this.TxtSaleCupNightPrice.CustomButton.Name = "";
            this.TxtSaleCupNightPrice.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtSaleCupNightPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSaleCupNightPrice.CustomButton.TabIndex = 1;
            this.TxtSaleCupNightPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSaleCupNightPrice.CustomButton.UseSelectable = true;
            this.TxtSaleCupNightPrice.CustomButton.Visible = false;
            this.TxtSaleCupNightPrice.Lines = new string[0];
            this.TxtSaleCupNightPrice.Location = new System.Drawing.Point(137, 5);
            this.TxtSaleCupNightPrice.MaxLength = 6;
            this.TxtSaleCupNightPrice.Name = "TxtSaleCupNightPrice";
            this.TxtSaleCupNightPrice.PasswordChar = '\0';
            this.TxtSaleCupNightPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSaleCupNightPrice.SelectedText = "";
            this.TxtSaleCupNightPrice.SelectionLength = 0;
            this.TxtSaleCupNightPrice.SelectionStart = 0;
            this.TxtSaleCupNightPrice.ShortcutsEnabled = true;
            this.TxtSaleCupNightPrice.Size = new System.Drawing.Size(56, 22);
            this.TxtSaleCupNightPrice.TabIndex = 99;
            this.TxtSaleCupNightPrice.UseSelectable = true;
            this.TxtSaleCupNightPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSaleCupNightPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSaleCupNightPrice.TextChanged += new System.EventHandler(this.TxtSaleCupNightPrice_TextChanged);
            this.TxtSaleCupNightPrice.Click += new System.EventHandler(this.TxtSaleCupNightPrice_Click);
            this.TxtSaleCupNightPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaleCupNightPrice_KeyPress);
            this.TxtSaleCupNightPrice.Validated += new System.EventHandler(this.TxtSaleCupNightPrice_Validated);
            // 
            // TxtSaleCupDayPrice
            // 
            this.TxtSaleCupDayPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtSaleCupDayPrice.CustomButton.Image = null;
            this.TxtSaleCupDayPrice.CustomButton.Location = new System.Drawing.Point(36, 2);
            this.TxtSaleCupDayPrice.CustomButton.Name = "";
            this.TxtSaleCupDayPrice.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtSaleCupDayPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSaleCupDayPrice.CustomButton.TabIndex = 1;
            this.TxtSaleCupDayPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSaleCupDayPrice.CustomButton.UseSelectable = true;
            this.TxtSaleCupDayPrice.CustomButton.Visible = false;
            this.TxtSaleCupDayPrice.Lines = new string[0];
            this.TxtSaleCupDayPrice.Location = new System.Drawing.Point(137, 33);
            this.TxtSaleCupDayPrice.MaxLength = 6;
            this.TxtSaleCupDayPrice.Name = "TxtSaleCupDayPrice";
            this.TxtSaleCupDayPrice.PasswordChar = '\0';
            this.TxtSaleCupDayPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSaleCupDayPrice.SelectedText = "";
            this.TxtSaleCupDayPrice.SelectionLength = 0;
            this.TxtSaleCupDayPrice.SelectionStart = 0;
            this.TxtSaleCupDayPrice.ShortcutsEnabled = true;
            this.TxtSaleCupDayPrice.Size = new System.Drawing.Size(56, 22);
            this.TxtSaleCupDayPrice.TabIndex = 101;
            this.TxtSaleCupDayPrice.UseSelectable = true;
            this.TxtSaleCupDayPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSaleCupDayPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSaleCupDayPrice.TextChanged += new System.EventHandler(this.TxtSaleCupDayPrice_TextChanged);
            this.TxtSaleCupDayPrice.Click += new System.EventHandler(this.TxtSaleCupDayPrice_Click);
            this.TxtSaleCupDayPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaleCupDayPrice_KeyPress);
            this.TxtSaleCupDayPrice.Validated += new System.EventHandler(this.TxtSaleCupDayPrice_Validated);
            // 
            // lblCupDayPrice
            // 
            this.lblCupDayPrice.AutoSize = true;
            this.lblCupDayPrice.Location = new System.Drawing.Point(3, 35);
            this.lblCupDayPrice.Name = "lblCupDayPrice";
            this.lblCupDayPrice.Size = new System.Drawing.Size(110, 19);
            this.lblCupDayPrice.TabIndex = 100;
            this.lblCupDayPrice.Text = "Precio copa (Día)";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 91;
            this.metroLabel1.Text = "Ventas";
            // 
            // lblDayPrice
            // 
            this.lblDayPrice.AutoSize = true;
            this.lblDayPrice.Location = new System.Drawing.Point(13, 97);
            this.lblDayPrice.Name = "lblDayPrice";
            this.lblDayPrice.Size = new System.Drawing.Size(77, 19);
            this.lblDayPrice.TabIndex = 96;
            this.lblDayPrice.Text = "Precio (Día)";
            // 
            // TxtSaleDayPrice
            // 
            this.TxtSaleDayPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtSaleDayPrice.CustomButton.Image = null;
            this.TxtSaleDayPrice.CustomButton.Location = new System.Drawing.Point(36, 2);
            this.TxtSaleDayPrice.CustomButton.Name = "";
            this.TxtSaleDayPrice.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtSaleDayPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSaleDayPrice.CustomButton.TabIndex = 1;
            this.TxtSaleDayPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSaleDayPrice.CustomButton.UseSelectable = true;
            this.TxtSaleDayPrice.CustomButton.Visible = false;
            this.TxtSaleDayPrice.Lines = new string[0];
            this.TxtSaleDayPrice.Location = new System.Drawing.Point(153, 98);
            this.TxtSaleDayPrice.MaxLength = 6;
            this.TxtSaleDayPrice.Name = "TxtSaleDayPrice";
            this.TxtSaleDayPrice.PasswordChar = '\0';
            this.TxtSaleDayPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSaleDayPrice.SelectedText = "";
            this.TxtSaleDayPrice.SelectionLength = 0;
            this.TxtSaleDayPrice.SelectionStart = 0;
            this.TxtSaleDayPrice.ShortcutsEnabled = true;
            this.TxtSaleDayPrice.Size = new System.Drawing.Size(56, 22);
            this.TxtSaleDayPrice.TabIndex = 97;
            this.TxtSaleDayPrice.UseSelectable = true;
            this.TxtSaleDayPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSaleDayPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSaleDayPrice.TextChanged += new System.EventHandler(this.TxtSaleDayPrice_TextChanged);
            this.TxtSaleDayPrice.Click += new System.EventHandler(this.TxtSaleDayPrice_Click);
            this.TxtSaleDayPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaleDayPrice_KeyPress);
            this.TxtSaleDayPrice.Validated += new System.EventHandler(this.TxtSaleDayPrice_Validated);
            // 
            // PurchasePanel
            // 
            this.PurchasePanel.Controls.Add(this.cbPurchaseTaxTypes);
            this.PurchasePanel.Controls.Add(this.TxtPurchasePrice);
            this.PurchasePanel.Controls.Add(this.label3);
            this.PurchasePanel.Controls.Add(this.label1);
            this.PurchasePanel.Controls.Add(this.label2);
            this.PurchasePanel.Controls.Add(this.txtPurchaseUnits);
            this.PurchasePanel.Controls.Add(this.metroLabel2);
            this.PurchasePanel.HorizontalScrollbarBarColor = true;
            this.PurchasePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.PurchasePanel.HorizontalScrollbarSize = 10;
            this.PurchasePanel.Location = new System.Drawing.Point(129, 397);
            this.PurchasePanel.Name = "PurchasePanel";
            this.PurchasePanel.Size = new System.Drawing.Size(100, 46);
            this.PurchasePanel.TabIndex = 101;
            this.PurchasePanel.VerticalScrollbarBarColor = true;
            this.PurchasePanel.VerticalScrollbarHighlightOnWheel = false;
            this.PurchasePanel.VerticalScrollbarSize = 10;
            this.PurchasePanel.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(13, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 92;
            this.metroLabel2.Text = "Compras";
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.Location = new System.Drawing.Point(557, 11);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(204, 187);
            this.pictureBoxProductImage.TabIndex = 95;
            this.pictureBoxProductImage.Text = "Imagen";
            this.pictureBoxProductImage.UseSelectable = true;
            this.pictureBoxProductImage.Click += new System.EventHandler(this.pictureBoxProductImage_Click);
            // 
            // TxtProductName
            // 
            this.TxtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtProductName.CustomButton.Image = null;
            this.TxtProductName.CustomButton.Location = new System.Drawing.Point(366, 2);
            this.TxtProductName.CustomButton.Name = "";
            this.TxtProductName.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtProductName.CustomButton.TabIndex = 1;
            this.TxtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtProductName.CustomButton.UseSelectable = true;
            this.TxtProductName.CustomButton.Visible = false;
            this.TxtProductName.Lines = new string[0];
            this.TxtProductName.Location = new System.Drawing.Point(120, 109);
            this.TxtProductName.MaxLength = 50;
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.PasswordChar = '\0';
            this.TxtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtProductName.SelectedText = "";
            this.TxtProductName.SelectionLength = 0;
            this.TxtProductName.SelectionStart = 0;
            this.TxtProductName.ShortcutsEnabled = true;
            this.TxtProductName.Size = new System.Drawing.Size(386, 22);
            this.TxtProductName.TabIndex = 94;
            this.TxtProductName.UseSelectable = true;
            this.TxtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtProductName.Click += new System.EventHandler(this.TxtProductName_Click);
            this.TxtProductName.Validated += new System.EventHandler(this.TxtProductName_Validated);
            // 
            // TxtProductId
            // 
            this.TxtProductId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtProductId.CustomButton.Image = null;
            this.TxtProductId.CustomButton.Location = new System.Drawing.Point(49, 2);
            this.TxtProductId.CustomButton.Name = "";
            this.TxtProductId.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtProductId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtProductId.CustomButton.TabIndex = 1;
            this.TxtProductId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtProductId.CustomButton.UseSelectable = true;
            this.TxtProductId.CustomButton.Visible = false;
            this.TxtProductId.Enabled = false;
            this.TxtProductId.Lines = new string[0];
            this.TxtProductId.Location = new System.Drawing.Point(120, 33);
            this.TxtProductId.MaxLength = 2;
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.PasswordChar = '\0';
            this.TxtProductId.ReadOnly = true;
            this.TxtProductId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtProductId.SelectedText = "";
            this.TxtProductId.SelectionLength = 0;
            this.TxtProductId.SelectionStart = 0;
            this.TxtProductId.ShortcutsEnabled = true;
            this.TxtProductId.Size = new System.Drawing.Size(69, 22);
            this.TxtProductId.TabIndex = 93;
            this.TxtProductId.UseSelectable = true;
            this.TxtProductId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtProductId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(120, 147);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(80, 17);
            this.chkActive.TabIndex = 90;
            this.chkActive.Text = "Off";
            this.chkActive.UseSelectable = true;
            // 
            // metroTabPageBusqueda
            // 
            this.metroTabPageBusqueda.Controls.Add(this.DataGridViewProducts);
            this.metroTabPageBusqueda.HorizontalScrollbarBarColor = true;
            this.metroTabPageBusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageBusqueda.HorizontalScrollbarSize = 10;
            this.metroTabPageBusqueda.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageBusqueda.Name = "metroTabPageBusqueda";
            this.metroTabPageBusqueda.Size = new System.Drawing.Size(816, 446);
            this.metroTabPageBusqueda.TabIndex = 1;
            this.metroTabPageBusqueda.Text = "Búsqueda";
            this.metroTabPageBusqueda.VerticalScrollbarBarColor = true;
            this.metroTabPageBusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageBusqueda.VerticalScrollbarSize = 10;
            // 
            // DataGridViewProducts
            // 
            this.DataGridViewProducts.AllowUserToResizeRows = false;
            this.DataGridViewProducts.AutoGenerateColumns = false;
            this.DataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductImage,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.SaleDayPrice,
            this.SaleNightPrice,
            this.salePriceDataGridViewTextBoxColumn,
            this.saleTaxTypeDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.purchaseTaxTypeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.SubType,
            this.activeDataGridViewCheckBoxColumn,
            this.saleUnitsDataGridViewTextBoxColumn,
            this.purchaseUnitsDataGridViewTextBoxColumn});
            this.DataGridViewProducts.DataSource = this.productBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewProducts.EnableHeadersVisualStyles = false;
            this.DataGridViewProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewProducts.Location = new System.Drawing.Point(1, 3);
            this.DataGridViewProducts.MultiSelect = false;
            this.DataGridViewProducts.Name = "DataGridViewProducts";
            this.DataGridViewProducts.ReadOnly = true;
            this.DataGridViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewProducts.RowHeadersVisible = false;
            this.DataGridViewProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewProducts.RowTemplate.Height = 60;
            this.DataGridViewProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewProducts.Size = new System.Drawing.Size(815, 440);
            this.DataGridViewProducts.TabIndex = 3;
            this.DataGridViewProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProducts_CellDoubleClick);
            // 
            // ProductImage
            // 
            this.ProductImage.DataPropertyName = "Image";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            this.ProductImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductImage.HeaderText = "";
            this.ProductImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SaleDayPrice
            // 
            this.SaleDayPrice.DataPropertyName = "SaleDayPrice";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleDayPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.SaleDayPrice.HeaderText = "Precio Día";
            this.SaleDayPrice.Name = "SaleDayPrice";
            this.SaleDayPrice.ReadOnly = true;
            this.SaleDayPrice.Width = 120;
            // 
            // SaleNightPrice
            // 
            this.SaleNightPrice.DataPropertyName = "SaleNightPrice";
            this.SaleNightPrice.HeaderText = "Precio Noche";
            this.SaleNightPrice.Name = "SaleNightPrice";
            this.SaleNightPrice.ReadOnly = true;
            this.SaleNightPrice.Width = 120;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "Precio Venta";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.salePriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // saleTaxTypeDataGridViewTextBoxColumn
            // 
            this.saleTaxTypeDataGridViewTextBoxColumn.DataPropertyName = "SaleTaxType";
            this.saleTaxTypeDataGridViewTextBoxColumn.HeaderText = "SaleTaxType";
            this.saleTaxTypeDataGridViewTextBoxColumn.Name = "saleTaxTypeDataGridViewTextBoxColumn";
            this.saleTaxTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleTaxTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Precio Compra";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchasePriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // purchaseTaxTypeDataGridViewTextBoxColumn
            // 
            this.purchaseTaxTypeDataGridViewTextBoxColumn.DataPropertyName = "PurchaseTaxType";
            this.purchaseTaxTypeDataGridViewTextBoxColumn.HeaderText = "PurchaseTaxType";
            this.purchaseTaxTypeDataGridViewTextBoxColumn.Name = "purchaseTaxTypeDataGridViewTextBoxColumn";
            this.purchaseTaxTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchaseTaxTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 90;
            // 
            // SubType
            // 
            this.SubType.DataPropertyName = "SubType";
            this.SubType.HeaderText = "Subtipo";
            this.SubType.Name = "SubType";
            this.SubType.ReadOnly = true;
            this.SubType.Width = 90;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Width = 45;
            // 
            // saleUnitsDataGridViewTextBoxColumn
            // 
            this.saleUnitsDataGridViewTextBoxColumn.DataPropertyName = "SaleUnits";
            this.saleUnitsDataGridViewTextBoxColumn.HeaderText = "SaleUnits";
            this.saleUnitsDataGridViewTextBoxColumn.Name = "saleUnitsDataGridViewTextBoxColumn";
            this.saleUnitsDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleUnitsDataGridViewTextBoxColumn.Visible = false;
            // 
            // purchaseUnitsDataGridViewTextBoxColumn
            // 
            this.purchaseUnitsDataGridViewTextBoxColumn.DataPropertyName = "PurchaseUnits";
            this.purchaseUnitsDataGridViewTextBoxColumn.HeaderText = "PurchaseUnits";
            this.purchaseUnitsDataGridViewTextBoxColumn.Name = "purchaseUnitsDataGridViewTextBoxColumn";
            this.purchaseUnitsDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchaseUnitsDataGridViewTextBoxColumn.Visible = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Kiwi.Tpv.Database.Entities.Product);
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(777, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 62);
            this.btnClose.Style = MetroFramework.MetroColorStyle.White;
            this.btnClose.TabIndex = 91;
            this.btnClose.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClose.TileImage")));
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SubType";
            this.dataGridViewTextBoxColumn1.HeaderText = "Subtipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(860, 576);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "FrmProducts";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProducts_FormClosed);
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.tabProducts.ResumeLayout(false);
            this.metroTabPageFicha.ResumeLayout(false);
            this.metroTabPageFicha.PerformLayout();
            this.SalePanel.ResumeLayout(false);
            this.SalePanel.PerformLayout();
            this.SodaPrices.ResumeLayout(false);
            this.SodaPrices.PerformLayout();
            this.AlcoholPricesPanel.ResumeLayout(false);
            this.AlcoholPricesPanel.PerformLayout();
            this.PurchasePanel.ResumeLayout(false);
            this.PurchasePanel.PerformLayout();
            this.metroTabPageBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private MetroFramework.Controls.MetroComboBox CbProductSubType;
        private MetroFramework.Controls.MetroTextBox txtPurchaseUnits;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroTextBox TxtPurchasePrice;
        private MetroFramework.Controls.MetroComboBox cbPurchaseTaxTypes;
        private MetroFramework.Controls.MetroLabel lblNightPrice;
        private MetroFramework.Controls.MetroTextBox TxtSaleNightPrice;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroTextBox txtSaleUnits;
        private MetroFramework.Controls.MetroComboBox cbSaleTaxTypes;
        private MetroFramework.Controls.MetroLabel lblActive;
        private MetroFramework.Controls.MetroComboBox CbProductType;
        private MetroFramework.Controls.MetroLabel LblProductType;
        private MetroFramework.Controls.MetroLabel LblProductName;
        private MetroFramework.Controls.MetroLabel LblProductId;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnRemove;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroTabControl tabProducts;
        private MetroTabPage metroTabPageFicha;
        private MetroToggle chkActive;
        private MetroTabPage metroTabPageBusqueda;
        private MetroLabel metroLabel2;
        private MetroLabel metroLabel1;
        private MetroGrid DataGridViewProducts;
        private BindingSource productBindingSource;
        private MetroTile btnClose;
        private MetroTextBox TxtProductId;
        private MetroTextBox TxtProductName;
        private MetroButton pictureBoxProductImage;
        private MetroLabel lblDayPrice;
        private MetroTextBox TxtSaleDayPrice;
        private DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MetroToggle chkShowInMainView;
        private MetroLabel metroLabel4;
        private MetroPanel SalePanel;
        private MetroPanel PurchasePanel;
        private MetroLabel lblCupDayPrice;
        private MetroTextBox TxtSaleCupDayPrice;
        private MetroTextBox TxtSaleCupNightPrice;
        private MetroLabel lblCupNightPrice;
        private MetroLabel lblShotDayPrice;
        private MetroTextBox TxtSaleShotDayPrice;
        private MetroTextBox TxtSaleShotNightPrice;
        private MetroLabel lblShotNightPrice;
        private MetroPanel AlcoholPricesPanel;
        private MetroPanel SodaPrices;
        private MetroLabel metroLabel3;
        private MetroTextBox TxtSaleCombinedPrice;
        private DataGridViewImageColumn ProductImage;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SaleDayPrice;
        private DataGridViewTextBoxColumn SaleNightPrice;
        private DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleTaxTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchaseTaxTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SubType;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn saleUnitsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchaseUnitsDataGridViewTextBoxColumn;
        private MetroButton BtnRemoveImage;
    }
}