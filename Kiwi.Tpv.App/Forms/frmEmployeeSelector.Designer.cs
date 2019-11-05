namespace Kiwi.Tpv.App.Forms
{
    partial class FrmEmployeeSelector
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
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanelEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.Location = new System.Drawing.Point(23, 620);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(1024, 53);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Green;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Volver";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flowLayoutPanelEmployees
            // 
            this.flowLayoutPanelEmployees.Location = new System.Drawing.Point(23, 64);
            this.flowLayoutPanelEmployees.Name = "flowLayoutPanelEmployees";
            this.flowLayoutPanelEmployees.Size = new System.Drawing.Size(1024, 540);
            this.flowLayoutPanelEmployees.TabIndex = 2;
            // 
            // FrmEmployeeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 696);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flowLayoutPanelEmployees);
            this.Movable = false;
            this.Name = "FrmEmployeeSelector";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Selección de empleado";
            this.Load += new System.EventHandler(this.frmEmployeeSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEmployees;
    }
}