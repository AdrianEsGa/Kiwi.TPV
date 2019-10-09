namespace Kiwi.Tpv.App.Forms
{
    partial class frmAlcoholModeTypes
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
            this.BtnCombined = new MetroFramework.Controls.MetroTile();
            this.BtnCup = new MetroFramework.Controls.MetroTile();
            this.BtnShot = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // BtnCombined
            // 
            this.BtnCombined.ActiveControl = null;
            this.BtnCombined.Location = new System.Drawing.Point(32, 79);
            this.BtnCombined.Name = "BtnCombined";
            this.BtnCombined.Size = new System.Drawing.Size(133, 113);
            this.BtnCombined.TabIndex = 0;
            this.BtnCombined.Text = "Combinado";
            this.BtnCombined.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BtnCombined.UseSelectable = true;
            this.BtnCombined.Click += new System.EventHandler(this.BtnCombined_Click);
            // 
            // BtnCup
            // 
            this.BtnCup.ActiveControl = null;
            this.BtnCup.Location = new System.Drawing.Point(171, 79);
            this.BtnCup.Name = "BtnCup";
            this.BtnCup.Size = new System.Drawing.Size(133, 113);
            this.BtnCup.TabIndex = 1;
            this.BtnCup.Text = "Copa";
            this.BtnCup.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BtnCup.UseSelectable = true;
            this.BtnCup.Click += new System.EventHandler(this.BtnCup_Click);
            // 
            // BtnShot
            // 
            this.BtnShot.ActiveControl = null;
            this.BtnShot.Location = new System.Drawing.Point(310, 79);
            this.BtnShot.Name = "BtnShot";
            this.BtnShot.Size = new System.Drawing.Size(133, 113);
            this.BtnShot.TabIndex = 2;
            this.BtnShot.Text = "Chupito";
            this.BtnShot.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BtnShot.UseSelectable = true;
            this.BtnShot.Click += new System.EventHandler(this.BtnShot_Click);
            // 
            // frmAlcoholModeTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 220);
            this.ControlBox = false;
            this.Controls.Add(this.BtnShot);
            this.Controls.Add(this.BtnCup);
            this.Controls.Add(this.BtnCombined);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmAlcoholModeTypes";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Servido como:";
            this.Load += new System.EventHandler(this.frmAlcoholModeTypes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile BtnCombined;
        private MetroFramework.Controls.MetroTile BtnCup;
        private MetroFramework.Controls.MetroTile BtnShot;
    }
}