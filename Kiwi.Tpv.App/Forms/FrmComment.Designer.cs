namespace Kiwi.Tpv.App.Forms
{
    partial class FrmComment
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
            this.TxtComment = new MetroFramework.Controls.MetroTextBox();
            this.btnConfirm = new MetroFramework.Controls.MetroTile();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // TxtComment
            // 
            // 
            // 
            // 
            this.TxtComment.CustomButton.Image = null;
            this.TxtComment.CustomButton.Location = new System.Drawing.Point(419, 1);
            this.TxtComment.CustomButton.Name = "";
            this.TxtComment.CustomButton.Size = new System.Drawing.Size(99, 99);
            this.TxtComment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtComment.CustomButton.TabIndex = 1;
            this.TxtComment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtComment.CustomButton.UseSelectable = true;
            this.TxtComment.CustomButton.Visible = false;
            this.TxtComment.Lines = new string[0];
            this.TxtComment.Location = new System.Drawing.Point(23, 63);
            this.TxtComment.MaxLength = 32767;
            this.TxtComment.Multiline = true;
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.PasswordChar = '\0';
            this.TxtComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtComment.SelectedText = "";
            this.TxtComment.SelectionLength = 0;
            this.TxtComment.SelectionStart = 0;
            this.TxtComment.ShortcutsEnabled = true;
            this.TxtComment.Size = new System.Drawing.Size(519, 101);
            this.TxtComment.TabIndex = 0;
            this.TxtComment.UseSelectable = true;
            this.TxtComment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtComment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveControl = null;
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnConfirm.Location = new System.Drawing.Point(23, 179);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(252, 54);
            this.btnConfirm.Style = MetroFramework.MetroColorStyle.Green;
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnCancel.Location = new System.Drawing.Point(290, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(252, 54);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 247);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.TxtComment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmComment";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Comentario";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtComment;
        private MetroFramework.Controls.MetroTile btnConfirm;
        private MetroFramework.Controls.MetroTile btnCancel;
    }
}