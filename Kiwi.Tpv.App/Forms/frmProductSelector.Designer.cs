namespace Kiwi.Tpv.App.Forms
{
    partial class FrmProductSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductSelector));
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(23, 63);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(856, 431);
            this.flowLayoutPanelProducts.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.Location = new System.Drawing.Point(23, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(856, 53);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Green;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Volver";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmProductSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 576);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flowLayoutPanelProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "FrmProductSelector";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Selección de producto";
            this.Load += new System.EventHandler(this.frmProductSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private MetroFramework.Controls.MetroTile btnCancel;
    }
}