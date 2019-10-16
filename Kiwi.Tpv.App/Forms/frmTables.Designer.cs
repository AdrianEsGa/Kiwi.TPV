using System.Windows.Forms;
using MetroFramework.Controls;

namespace Kiwi.Tpv.App.Forms
{
    partial class FrmTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTables));
            this.lblActive = new MetroFramework.Controls.MetroLabel();
            this.LblProductName = new MetroFramework.Controls.MetroLabel();
            this.LblProductId = new MetroFramework.Controls.MetroLabel();
            this.TxtTableName = new MetroFramework.Controls.MetroTextBox();
            this.TxtTableId = new MetroFramework.Controls.MetroTextBox();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnRemove = new MetroFramework.Controls.MetroTile();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.tabTables = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageFicha = new MetroFramework.Controls.MetroTabPage();
            this.btnDistribucion = new MetroFramework.Controls.MetroTile();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chkActive = new MetroFramework.Controls.MetroToggle();
            this.metroTabPageBusqueda = new MetroFramework.Controls.MetroTabPage();
            this.DataGridViewTables = new MetroFramework.Controls.MetroGrid();
            this.barTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabTables.SuspendLayout();
            this.metroTabPageFicha.SuspendLayout();
            this.metroTabPageBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(5, 147);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(44, 19);
            this.lblActive.TabIndex = 81;
            this.lblActive.Text = "Activa";
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
            // TxtTableName
            // 
            this.TxtTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtTableName.CustomButton.Image = null;
            this.TxtTableName.CustomButton.Location = new System.Drawing.Point(366, 2);
            this.TxtTableName.CustomButton.Name = "";
            this.TxtTableName.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtTableName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTableName.CustomButton.TabIndex = 1;
            this.TxtTableName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTableName.CustomButton.UseSelectable = true;
            this.TxtTableName.CustomButton.Visible = false;
            this.TxtTableName.Lines = new string[0];
            this.TxtTableName.Location = new System.Drawing.Point(120, 109);
            this.TxtTableName.MaxLength = 50;
            this.TxtTableName.Name = "TxtTableName";
            this.TxtTableName.PasswordChar = '\0';
            this.TxtTableName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTableName.SelectedText = "";
            this.TxtTableName.SelectionLength = 0;
            this.TxtTableName.SelectionStart = 0;
            this.TxtTableName.ShortcutsEnabled = true;
            this.TxtTableName.Size = new System.Drawing.Size(386, 22);
            this.TxtTableName.TabIndex = 74;
            this.TxtTableName.UseSelectable = true;
            this.TxtTableName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTableName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtTableName.Click += new System.EventHandler(this.TxtTableName_Click);
            this.TxtTableName.Validated += new System.EventHandler(this.TxtTableName_Validated);
            // 
            // TxtTableId
            // 
            this.TxtTableId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtTableId.CustomButton.Image = null;
            this.TxtTableId.CustomButton.Location = new System.Drawing.Point(49, 2);
            this.TxtTableId.CustomButton.Name = "";
            this.TxtTableId.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtTableId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTableId.CustomButton.TabIndex = 1;
            this.TxtTableId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTableId.CustomButton.UseSelectable = true;
            this.TxtTableId.CustomButton.Visible = false;
            this.TxtTableId.Enabled = false;
            this.TxtTableId.Lines = new string[0];
            this.TxtTableId.Location = new System.Drawing.Point(120, 33);
            this.TxtTableId.MaxLength = 2;
            this.TxtTableId.Name = "TxtTableId";
            this.TxtTableId.PasswordChar = '\0';
            this.TxtTableId.ReadOnly = true;
            this.TxtTableId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTableId.SelectedText = "";
            this.TxtTableId.SelectionLength = 0;
            this.TxtTableId.SelectionStart = 0;
            this.TxtTableId.ShortcutsEnabled = true;
            this.TxtTableId.Size = new System.Drawing.Size(69, 22);
            this.TxtTableId.TabIndex = 73;
            this.TxtTableId.UseSelectable = true;
            this.TxtTableId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTableId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnNew
            // 
            this.btnNew.ActiveControl = null;
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnNew.Location = new System.Drawing.Point(508, 397);
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
            this.btnSave.Location = new System.Drawing.Point(730, 397);
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
            this.btnRemove.Location = new System.Drawing.Point(619, 397);
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
            // tabTables
            // 
            this.tabTables.Controls.Add(this.metroTabPageFicha);
            this.tabTables.Controls.Add(this.metroTabPageBusqueda);
            this.tabTables.Location = new System.Drawing.Point(23, 69);
            this.tabTables.Name = "tabTables";
            this.tabTables.SelectedIndex = 1;
            this.tabTables.Size = new System.Drawing.Size(865, 488);
            this.tabTables.TabIndex = 90;
            this.tabTables.UseSelectable = true;
            // 
            // metroTabPageFicha
            // 
            this.metroTabPageFicha.Controls.Add(this.btnDistribucion);
            this.metroTabPageFicha.Controls.Add(this.txtCode);
            this.metroTabPageFicha.Controls.Add(this.metroLabel1);
            this.metroTabPageFicha.Controls.Add(this.chkActive);
            this.metroTabPageFicha.Controls.Add(this.btnNew);
            this.metroTabPageFicha.Controls.Add(this.btnSave);
            this.metroTabPageFicha.Controls.Add(this.lblActive);
            this.metroTabPageFicha.Controls.Add(this.btnSearch);
            this.metroTabPageFicha.Controls.Add(this.btnRemove);
            this.metroTabPageFicha.Controls.Add(this.TxtTableId);
            this.metroTabPageFicha.Controls.Add(this.TxtTableName);
            this.metroTabPageFicha.Controls.Add(this.LblProductId);
            this.metroTabPageFicha.Controls.Add(this.LblProductName);
            this.metroTabPageFicha.HorizontalScrollbarBarColor = true;
            this.metroTabPageFicha.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageFicha.HorizontalScrollbarSize = 10;
            this.metroTabPageFicha.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageFicha.Name = "metroTabPageFicha";
            this.metroTabPageFicha.Size = new System.Drawing.Size(857, 446);
            this.metroTabPageFicha.TabIndex = 0;
            this.metroTabPageFicha.Text = "Ficha";
            this.metroTabPageFicha.VerticalScrollbarBarColor = true;
            this.metroTabPageFicha.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageFicha.VerticalScrollbarSize = 10;
            // 
            // btnDistribucion
            // 
            this.btnDistribucion.ActiveControl = null;
            this.btnDistribucion.BackColor = System.Drawing.SystemColors.Control;
            this.btnDistribucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnDistribucion.Location = new System.Drawing.Point(120, 395);
            this.btnDistribucion.Name = "btnDistribucion";
            this.btnDistribucion.Size = new System.Drawing.Size(105, 48);
            this.btnDistribucion.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDistribucion.TabIndex = 96;
            this.btnDistribucion.Text = "Distribución";
            this.btnDistribucion.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnDistribucion.UseSelectable = true;
            this.btnDistribucion.Click += new System.EventHandler(this.btnDistribucion_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(366, 2);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(120, 72);
            this.txtCode.MaxLength = 50;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(386, 22);
            this.txtCode.TabIndex = 95;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            this.txtCode.Validated += new System.EventHandler(this.txtCode_Validated);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 94;
            this.metroLabel1.Text = "Número";
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
            this.metroTabPageBusqueda.Controls.Add(this.DataGridViewTables);
            this.metroTabPageBusqueda.HorizontalScrollbarBarColor = true;
            this.metroTabPageBusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageBusqueda.HorizontalScrollbarSize = 10;
            this.metroTabPageBusqueda.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageBusqueda.Name = "metroTabPageBusqueda";
            this.metroTabPageBusqueda.Size = new System.Drawing.Size(857, 446);
            this.metroTabPageBusqueda.TabIndex = 1;
            this.metroTabPageBusqueda.Text = "Búsqueda";
            this.metroTabPageBusqueda.VerticalScrollbarBarColor = true;
            this.metroTabPageBusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageBusqueda.VerticalScrollbarSize = 10;
            // 
            // DataGridViewTables
            // 
            this.DataGridViewTables.AllowUserToResizeRows = false;
            this.DataGridViewTables.AutoGenerateColumns = false;
            this.DataGridViewTables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewTables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DataGridViewTables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.imagePathDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.DataGridViewTables.DataSource = this.barTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTables.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTables.EnableHeadersVisualStyles = false;
            this.DataGridViewTables.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewTables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewTables.Location = new System.Drawing.Point(1, 3);
            this.DataGridViewTables.MultiSelect = false;
            this.DataGridViewTables.Name = "DataGridViewTables";
            this.DataGridViewTables.ReadOnly = true;
            this.DataGridViewTables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTables.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewTables.RowHeadersVisible = false;
            this.DataGridViewTables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewTables.RowTemplate.Height = 40;
            this.DataGridViewTables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTables.Size = new System.Drawing.Size(854, 440);
            this.DataGridViewTables.TabIndex = 4;
            this.DataGridViewTables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTables_CellDoubleClick);
            // 
            // barTableBindingSource
            // 
            this.barTableBindingSource.DataSource = typeof(Kiwi.Tpv.Database.Entities.BarTable);
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(818, 17);
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Número";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagePathDataGridViewTextBoxColumn
            // 
            this.imagePathDataGridViewTextBoxColumn.DataPropertyName = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.HeaderText = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.Name = "imagePathDataGridViewTextBoxColumn";
            this.imagePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.imagePathDataGridViewTextBoxColumn.Visible = false;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Visible = false;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Activa";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Width = 45;
            // 
            // FrmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(902, 576);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabTables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "FrmTables";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Mesas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTables_FormClosed);
            this.Load += new System.EventHandler(this.FrmTables_Load);
            this.tabTables.ResumeLayout(false);
            this.metroTabPageFicha.ResumeLayout(false);
            this.metroTabPageFicha.PerformLayout();
            this.metroTabPageBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblActive;
        private MetroFramework.Controls.MetroLabel LblProductName;
        private MetroFramework.Controls.MetroLabel LblProductId;
        private MetroFramework.Controls.MetroTextBox TxtTableName;
        private MetroFramework.Controls.MetroTextBox TxtTableId;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnRemove;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroTabControl tabTables;
        private MetroTabPage metroTabPageFicha;
        private MetroToggle chkActive;
        private MetroTabPage metroTabPageBusqueda;
        private MetroTile btnClose;
        private MetroTextBox txtCode;
        private MetroLabel metroLabel1;
        private MetroTile btnDistribucion;
        private MetroGrid DataGridViewTables;
        private BindingSource barTableBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
    }
}