namespace Kiwi.Tpv.App.Forms
{
    partial class FrmTablesDistribution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTablesDistribution));
            this.btnAddTable = new MetroFramework.Controls.MetroTile();
            this.panelButons = new MetroFramework.Controls.MetroPanel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnRemove = new MetroFramework.Controls.MetroTile();
            this.panelDistribution = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.panelButons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTable
            // 
            this.btnAddTable.ActiveControl = null;
            this.btnAddTable.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnAddTable.Location = new System.Drawing.Point(3, 5);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(105, 36);
            this.btnAddTable.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAddTable.TabIndex = 87;
            this.btnAddTable.Text = "Agregar";
            this.btnAddTable.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAddTable.UseSelectable = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // panelButons
            // 
            this.panelButons.Controls.Add(this.btnSave);
            this.panelButons.Controls.Add(this.btnRemove);
            this.panelButons.Controls.Add(this.btnAddTable);
            this.panelButons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButons.HorizontalScrollbarBarColor = true;
            this.panelButons.HorizontalScrollbarHighlightOnWheel = false;
            this.panelButons.HorizontalScrollbarSize = 10;
            this.panelButons.Location = new System.Drawing.Point(20, 632);
            this.panelButons.Name = "panelButons";
            this.panelButons.Size = new System.Drawing.Size(1030, 44);
            this.panelButons.TabIndex = 88;
            this.panelButons.VerticalScrollbarBarColor = true;
            this.panelButons.VerticalScrollbarHighlightOnWheel = false;
            this.panelButons.VerticalScrollbarSize = 10;
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnSave.Location = new System.Drawing.Point(922, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 36);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 89;
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
            this.btnRemove.Location = new System.Drawing.Point(811, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 36);
            this.btnRemove.Style = MetroFramework.MetroColorStyle.Red;
            this.btnRemove.TabIndex = 90;
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panelDistribution
            // 
            this.panelDistribution.HorizontalScrollbarBarColor = true;
            this.panelDistribution.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDistribution.HorizontalScrollbarSize = 10;
            this.panelDistribution.Location = new System.Drawing.Point(20, 85);
            this.panelDistribution.Name = "panelDistribution";
            this.panelDistribution.Size = new System.Drawing.Size(1030, 541);
            this.panelDistribution.TabIndex = 89;
            this.panelDistribution.VerticalScrollbarBarColor = true;
            this.panelDistribution.VerticalScrollbarHighlightOnWheel = false;
            this.panelDistribution.VerticalScrollbarSize = 10;
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(980, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 62);
            this.btnClose.Style = MetroFramework.MetroColorStyle.White;
            this.btnClose.TabIndex = 92;
            this.btnClose.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClose.TileImage")));
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmTablesDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 696);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelDistribution);
            this.Controls.Add(this.panelButons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmTablesDistribution";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Distribución de mesas";
            this.Load += new System.EventHandler(this.frmTablesDistribution_Load);
            this.panelButons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnAddTable;
        private MetroFramework.Controls.MetroPanel panelButons;
        private MetroFramework.Controls.MetroPanel panelDistribution;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnRemove;
        private MetroFramework.Controls.MetroTile btnClose;


    }
}