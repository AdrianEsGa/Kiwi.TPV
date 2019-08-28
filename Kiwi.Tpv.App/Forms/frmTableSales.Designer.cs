namespace Kiwi.Tpv.App.Forms
{
    partial class FrmTableSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableSales));
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.panelButtons = new MetroFramework.Controls.MetroPanel();
            this.btnNewSale = new MetroFramework.Controls.MetroTile();
            this.DataGridViewTableSales = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ticketDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTableSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(818, 17);
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
            this.panelButtons.Controls.Add(this.btnNewSale);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.HorizontalScrollbarBarColor = true;
            this.panelButtons.HorizontalScrollbarHighlightOnWheel = false;
            this.panelButtons.HorizontalScrollbarSize = 10;
            this.panelButtons.Location = new System.Drawing.Point(20, 485);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(862, 71);
            this.panelButtons.TabIndex = 57;
            this.panelButtons.VerticalScrollbarBarColor = true;
            this.panelButtons.VerticalScrollbarHighlightOnWheel = false;
            this.panelButtons.VerticalScrollbarSize = 10;
            // 
            // btnNewSale
            // 
            this.btnNewSale.ActiveControl = null;
            this.btnNewSale.BackColor = System.Drawing.Color.White;
            this.btnNewSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnNewSale.Location = new System.Drawing.Point(0, 0);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(862, 71);
            this.btnNewSale.Style = MetroFramework.MetroColorStyle.Green;
            this.btnNewSale.TabIndex = 5;
            this.btnNewSale.Text = "Nueva Venta";
            this.btnNewSale.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNewSale.UseSelectable = true;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // DataGridViewTableSales
            // 
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
            this.employeeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.disscountDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.payTypeDataGridViewTextBoxColumn,
            this.tableDataGridViewTextBoxColumn,
            this.paidDataGridViewCheckBoxColumn,
            this.ticketDataGridViewCheckBoxColumn});
            this.DataGridViewTableSales.DataSource = this.saleBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTableSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewTableSales.RowHeadersVisible = false;
            this.DataGridViewTableSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewTableSales.RowTemplate.Height = 40;
            this.DataGridViewTableSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewTableSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTableSales.Size = new System.Drawing.Size(862, 394);
            this.DataGridViewTableSales.TabIndex = 3;
            this.DataGridViewTableSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTableSales_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Venta";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stationDataGridViewTextBoxColumn
            // 
            this.stationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stationDataGridViewTextBoxColumn.DataPropertyName = "Station";
            this.stationDataGridViewTextBoxColumn.HeaderText = "Punto de venta";
            this.stationDataGridViewTextBoxColumn.Name = "stationDataGridViewTextBoxColumn";
            this.stationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disscountDataGridViewTextBoxColumn
            // 
            this.disscountDataGridViewTextBoxColumn.DataPropertyName = "Disscount";
            this.disscountDataGridViewTextBoxColumn.HeaderText = "Disscount";
            this.disscountDataGridViewTextBoxColumn.Name = "disscountDataGridViewTextBoxColumn";
            this.disscountDataGridViewTextBoxColumn.ReadOnly = true;
            this.disscountDataGridViewTextBoxColumn.Visible = false;
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            this.taxDataGridViewTextBoxColumn.ReadOnly = true;
            this.taxDataGridViewTextBoxColumn.Visible = false;
            // 
            // payTypeDataGridViewTextBoxColumn
            // 
            this.payTypeDataGridViewTextBoxColumn.DataPropertyName = "PayType";
            this.payTypeDataGridViewTextBoxColumn.HeaderText = "PayType";
            this.payTypeDataGridViewTextBoxColumn.Name = "payTypeDataGridViewTextBoxColumn";
            this.payTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.payTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // tableDataGridViewTextBoxColumn
            // 
            this.tableDataGridViewTextBoxColumn.DataPropertyName = "Table";
            this.tableDataGridViewTextBoxColumn.HeaderText = "Table";
            this.tableDataGridViewTextBoxColumn.Name = "tableDataGridViewTextBoxColumn";
            this.tableDataGridViewTextBoxColumn.ReadOnly = true;
            this.tableDataGridViewTextBoxColumn.Visible = false;
            // 
            // paidDataGridViewCheckBoxColumn
            // 
            this.paidDataGridViewCheckBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewCheckBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewCheckBoxColumn.Name = "paidDataGridViewCheckBoxColumn";
            this.paidDataGridViewCheckBoxColumn.ReadOnly = true;
            this.paidDataGridViewCheckBoxColumn.Visible = false;
            // 
            // ticketDataGridViewCheckBoxColumn
            // 
            this.ticketDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ticketDataGridViewCheckBoxColumn.DataPropertyName = "Ticket";
            this.ticketDataGridViewCheckBoxColumn.HeaderText = "Ticket";
            this.ticketDataGridViewCheckBoxColumn.Name = "ticketDataGridViewCheckBoxColumn";
            this.ticketDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(Kiwi.Tpv.Database.Entities.Sale);
            // 
            // FrmTableSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 576);
            this.ControlBox = false;
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.DataGridViewTableSales);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmTableSales";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Ventas de mesa";
            this.Load += new System.EventHandler(this.frmTableSales_Load);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTableSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnClose;
        private MetroFramework.Controls.MetroPanel panelButtons;
        private MetroFramework.Controls.MetroGrid DataGridViewTableSales;
        private MetroFramework.Controls.MetroTile btnNewSale;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ticketDataGridViewCheckBoxColumn;
    }
}