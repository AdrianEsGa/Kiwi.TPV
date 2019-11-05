namespace Kiwi.Tpv.App.Forms
{
    partial class FrmCommands
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
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.DataGridViewCommands = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewCommandDetails = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CombinedProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.combinedProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActions = new MetroFramework.Controls.MetroTile();
            this.TimerRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCommandDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(977, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 62);
            this.btnClose.Style = MetroFramework.MetroColorStyle.White;
            this.btnClose.TabIndex = 55;
            this.btnClose.TileImage = global::Kiwi.Tpv.App.Properties.Resources.icoClose;
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DataGridViewCommands
            // 
            this.DataGridViewCommands.AllowUserToResizeRows = false;
            this.DataGridViewCommands.AutoGenerateColumns = false;
            this.DataGridViewCommands.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewCommands.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DataGridViewCommands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCommands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCommands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.EmployeeImage,
            this.employeeDataGridViewTextBoxColumn,
            this.tableDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.Status});
            this.DataGridViewCommands.DataSource = this.commandBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCommands.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewCommands.EnableHeadersVisualStyles = false;
            this.DataGridViewCommands.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewCommands.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewCommands.Location = new System.Drawing.Point(25, 85);
            this.DataGridViewCommands.MultiSelect = false;
            this.DataGridViewCommands.Name = "DataGridViewCommands";
            this.DataGridViewCommands.ReadOnly = true;
            this.DataGridViewCommands.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCommands.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewCommands.RowHeadersVisible = false;
            this.DataGridViewCommands.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewCommands.RowTemplate.Height = 55;
            this.DataGridViewCommands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCommands.Size = new System.Drawing.Size(1022, 210);
            this.DataGridViewCommands.TabIndex = 56;
            this.DataGridViewCommands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCommands_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmployeeImage
            // 
            this.EmployeeImage.DataPropertyName = "EmployeeImage";
            this.EmployeeImage.FillWeight = 200F;
            this.EmployeeImage.HeaderText = "";
            this.EmployeeImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EmployeeImage.Name = "EmployeeImage";
            this.EmployeeImage.ReadOnly = true;
            this.EmployeeImage.Width = 80;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableDataGridViewTextBoxColumn
            // 
            this.tableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableDataGridViewTextBoxColumn.DataPropertyName = "Table";
            this.tableDataGridViewTextBoxColumn.HeaderText = "Mesa";
            this.tableDataGridViewTextBoxColumn.Name = "tableDataGridViewTextBoxColumn";
            this.tableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Fecha/Hora";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Estado";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // commandBindingSource
            // 
            this.commandBindingSource.DataSource = typeof(Kiwi.Tpv.Database.Entities.Command);
            // 
            // DataGridViewCommandDetails
            // 
            this.DataGridViewCommandDetails.AllowUserToResizeRows = false;
            this.DataGridViewCommandDetails.AutoGenerateColumns = false;
            this.DataGridViewCommandDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewCommandDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewCommandDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DataGridViewCommandDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCommandDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewCommandDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCommandDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.commandIdDataGridViewTextBoxColumn,
            this.ProductImage,
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.CombinedProductImage,
            this.combinedProductDataGridViewTextBoxColumn});
            this.DataGridViewCommandDetails.DataSource = this.commandDetailBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCommandDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewCommandDetails.EnableHeadersVisualStyles = false;
            this.DataGridViewCommandDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewCommandDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewCommandDetails.Location = new System.Drawing.Point(25, 301);
            this.DataGridViewCommandDetails.MultiSelect = false;
            this.DataGridViewCommandDetails.Name = "DataGridViewCommandDetails";
            this.DataGridViewCommandDetails.ReadOnly = true;
            this.DataGridViewCommandDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCommandDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewCommandDetails.RowHeadersVisible = false;
            this.DataGridViewCommandDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewCommandDetails.RowTemplate.Height = 55;
            this.DataGridViewCommandDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewCommandDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCommandDetails.Size = new System.Drawing.Size(1022, 334);
            this.DataGridViewCommandDetails.TabIndex = 57;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // commandIdDataGridViewTextBoxColumn
            // 
            this.commandIdDataGridViewTextBoxColumn.DataPropertyName = "CommandId";
            this.commandIdDataGridViewTextBoxColumn.HeaderText = "CommandId";
            this.commandIdDataGridViewTextBoxColumn.Name = "commandIdDataGridViewTextBoxColumn";
            this.commandIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.commandIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ProductImage
            // 
            this.ProductImage.DataPropertyName = "ProductImage";
            this.ProductImage.HeaderText = "";
            this.ProductImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            this.ProductImage.Width = 80;
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
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Unidades";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CombinedProductImage
            // 
            this.CombinedProductImage.DataPropertyName = "CombinedProductImage";
            this.CombinedProductImage.HeaderText = "";
            this.CombinedProductImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.CombinedProductImage.Name = "CombinedProductImage";
            this.CombinedProductImage.ReadOnly = true;
            this.CombinedProductImage.Width = 80;
            // 
            // combinedProductDataGridViewTextBoxColumn
            // 
            this.combinedProductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.combinedProductDataGridViewTextBoxColumn.DataPropertyName = "CombinedProduct";
            this.combinedProductDataGridViewTextBoxColumn.HeaderText = "Combinado con";
            this.combinedProductDataGridViewTextBoxColumn.Name = "combinedProductDataGridViewTextBoxColumn";
            this.combinedProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commandDetailBindingSource
            // 
            this.commandDetailBindingSource.DataSource = typeof(Kiwi.Tpv.Database.Entities.CommandDetail);
            // 
            // btnActions
            // 
            this.btnActions.ActiveControl = null;
            this.btnActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnActions.ForeColor = System.Drawing.Color.Green;
            this.btnActions.Location = new System.Drawing.Point(25, 641);
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(1022, 43);
            this.btnActions.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnActions.TabIndex = 58;
            this.btnActions.Text = "En proceso";
            this.btnActions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActions.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnActions.UseSelectable = true;
            this.btnActions.Click += new System.EventHandler(this.btnActions_Click);
            // 
            // TimerRefresh
            // 
            this.TimerRefresh.Interval = 1500;
            this.TimerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // FrmCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 696);
            this.ControlBox = false;
            this.Controls.Add(this.btnActions);
            this.Controls.Add(this.DataGridViewCommandDetails);
            this.Controls.Add(this.DataGridViewCommands);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmCommands";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Comandas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCommands_FormClosing);
            this.Load += new System.EventHandler(this.FrmCommands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCommandDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnClose;
        private MetroFramework.Controls.MetroGrid DataGridViewCommands;
        private MetroFramework.Controls.MetroGrid DataGridViewCommandDetails;
        private System.Windows.Forms.BindingSource commandBindingSource;
        private System.Windows.Forms.BindingSource commandDetailBindingSource;
        private MetroFramework.Controls.MetroTile btnActions;
        private System.Windows.Forms.Timer TimerRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EmployeeImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn CombinedProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn combinedProductDataGridViewTextBoxColumn;
    }
}