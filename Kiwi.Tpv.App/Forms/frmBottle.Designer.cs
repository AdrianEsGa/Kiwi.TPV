using System.Windows.Forms;

namespace Kiwi.Tpv.App.Forms
{
    partial class FrmBottle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBottle));
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.TxtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.TxtPrice = new MetroFramework.Controls.MetroTextBox();
            this.btnErase = new MetroFramework.Controls.MetroTile();
            this.btnZero = new MetroFramework.Controls.MetroTile();
            this.btnPoint = new MetroFramework.Controls.MetroTile();
            this.btnNine = new MetroFramework.Controls.MetroTile();
            this.btnEight = new MetroFramework.Controls.MetroTile();
            this.btnSeven = new MetroFramework.Controls.MetroTile();
            this.btnSix = new MetroFramework.Controls.MetroTile();
            this.btnFive = new MetroFramework.Controls.MetroTile();
            this.btnFour = new MetroFramework.Controls.MetroTile();
            this.btnTwo = new MetroFramework.Controls.MetroTile();
            this.btnOne = new MetroFramework.Controls.MetroTile();
            this.btnThree = new MetroFramework.Controls.MetroTile();
            this.btnConfirm = new MetroFramework.Controls.MetroTile();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.CbAlcohol = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidades";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtQuantity.CustomButton.Image = null;
            this.TxtQuantity.CustomButton.Location = new System.Drawing.Point(686, 1);
            this.TxtQuantity.CustomButton.Name = "";
            this.TxtQuantity.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtQuantity.CustomButton.TabIndex = 1;
            this.TxtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtQuantity.CustomButton.UseSelectable = true;
            this.TxtQuantity.CustomButton.Visible = false;
            this.TxtQuantity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtQuantity.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtQuantity.Lines = new string[0];
            this.TxtQuantity.Location = new System.Drawing.Point(23, 152);
            this.TxtQuantity.MaxLength = 4;
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.PasswordChar = '\0';
            this.TxtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtQuantity.SelectedText = "";
            this.TxtQuantity.SelectionLength = 0;
            this.TxtQuantity.SelectionStart = 0;
            this.TxtQuantity.ShortcutsEnabled = true;
            this.TxtQuantity.Size = new System.Drawing.Size(720, 35);
            this.TxtQuantity.TabIndex = 43;
            this.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQuantity.UseSelectable = true;
            this.TxtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtQuantity.Click += new System.EventHandler(this.TxtQuantity_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Unidad (€)";
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // 
            // 
            this.TxtPrice.CustomButton.Image = null;
            this.TxtPrice.CustomButton.Location = new System.Drawing.Point(685, 1);
            this.TxtPrice.CustomButton.Name = "";
            this.TxtPrice.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPrice.CustomButton.TabIndex = 1;
            this.TxtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPrice.CustomButton.UseSelectable = true;
            this.TxtPrice.CustomButton.Visible = false;
            this.TxtPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPrice.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtPrice.Lines = new string[0];
            this.TxtPrice.Location = new System.Drawing.Point(24, 228);
            this.TxtPrice.MaxLength = 4;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.SelectionLength = 0;
            this.TxtPrice.SelectionStart = 0;
            this.TxtPrice.ShortcutsEnabled = true;
            this.TxtPrice.Size = new System.Drawing.Size(719, 35);
            this.TxtPrice.TabIndex = 44;
            this.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPrice.UseSelectable = true;
            this.TxtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPrice.Click += new System.EventHandler(this.TxtPrice_Click);
            // 
            // btnErase
            // 
            this.btnErase.ActiveControl = null;
            this.btnErase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnErase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnErase.Location = new System.Drawing.Point(506, 473);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(237, 57);
            this.btnErase.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnErase.TabIndex = 52;
            this.btnErase.Text = "Borrar";
            this.btnErase.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnErase.UseSelectable = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnZero
            // 
            this.btnZero.ActiveControl = null;
            this.btnZero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnZero.Location = new System.Drawing.Point(265, 473);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(235, 57);
            this.btnZero.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnZero.TabIndex = 52;
            this.btnZero.Text = "0";
            this.btnZero.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnZero.UseSelectable = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.ActiveControl = null;
            this.btnPoint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnPoint.Location = new System.Drawing.Point(24, 473);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(235, 57);
            this.btnPoint.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPoint.TabIndex = 53;
            this.btnPoint.Text = ",";
            this.btnPoint.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnPoint.UseSelectable = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnNine
            // 
            this.btnNine.ActiveControl = null;
            this.btnNine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnNine.Location = new System.Drawing.Point(506, 411);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(237, 56);
            this.btnNine.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNine.TabIndex = 52;
            this.btnNine.Text = "9";
            this.btnNine.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNine.UseSelectable = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.ActiveControl = null;
            this.btnEight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnEight.Location = new System.Drawing.Point(265, 411);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(235, 56);
            this.btnEight.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEight.TabIndex = 52;
            this.btnEight.Text = "8";
            this.btnEight.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnEight.UseSelectable = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.ActiveControl = null;
            this.btnSeven.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnSeven.Location = new System.Drawing.Point(24, 411);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(235, 56);
            this.btnSeven.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSeven.TabIndex = 52;
            this.btnSeven.Text = "7";
            this.btnSeven.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSeven.UseSelectable = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            this.btnSix.ActiveControl = null;
            this.btnSix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnSix.Location = new System.Drawing.Point(506, 349);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(237, 56);
            this.btnSix.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSix.TabIndex = 52;
            this.btnSix.Text = "6";
            this.btnSix.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSix.UseSelectable = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.ActiveControl = null;
            this.btnFive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnFive.Location = new System.Drawing.Point(265, 349);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(235, 56);
            this.btnFive.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnFive.TabIndex = 52;
            this.btnFive.Text = "5";
            this.btnFive.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnFive.UseSelectable = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.ActiveControl = null;
            this.btnFour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnFour.Location = new System.Drawing.Point(24, 349);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(235, 56);
            this.btnFour.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnFour.TabIndex = 52;
            this.btnFour.Text = "4";
            this.btnFour.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnFour.UseSelectable = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.ActiveControl = null;
            this.btnTwo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnTwo.Location = new System.Drawing.Point(265, 287);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(235, 56);
            this.btnTwo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnTwo.TabIndex = 52;
            this.btnTwo.Text = "2";
            this.btnTwo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnTwo.UseSelectable = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.ActiveControl = null;
            this.btnOne.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnOne.Location = new System.Drawing.Point(24, 287);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(235, 56);
            this.btnOne.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOne.TabIndex = 51;
            this.btnOne.Text = "1";
            this.btnOne.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnOne.UseSelectable = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnThree
            // 
            this.btnThree.ActiveControl = null;
            this.btnThree.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.btnThree.Location = new System.Drawing.Point(506, 287);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(237, 56);
            this.btnThree.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnThree.TabIndex = 52;
            this.btnThree.Text = "3";
            this.btnThree.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnThree.UseSelectable = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveControl = null;
            this.btnConfirm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirm.ForeColor = System.Drawing.Color.Green;
            this.btnConfirm.Location = new System.Drawing.Point(401, 547);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(342, 70);
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
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(23, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(342, 70);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CbAlcohol
            // 
            this.CbAlcohol.FormattingEnabled = true;
            this.CbAlcohol.ItemHeight = 23;
            this.CbAlcohol.Location = new System.Drawing.Point(23, 82);
            this.CbAlcohol.Name = "CbAlcohol";
            this.CbAlcohol.Size = new System.Drawing.Size(720, 29);
            this.CbAlcohol.TabIndex = 54;
            this.CbAlcohol.UseSelectable = true;
            this.CbAlcohol.SelectionChangeCommitted += new System.EventHandler(this.CbAlcohol_SelectionChangeCommitted);
            // 
            // FrmBottle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 637);
            this.ControlBox = false;
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.CbAlcohol);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmBottle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Venta de botella";
            this.Load += new System.EventHandler(this.frmBottle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtQuantity;
        private MetroFramework.Controls.MetroTextBox TxtPrice;
        private MetroFramework.Controls.MetroTile btnErase;
        private MetroFramework.Controls.MetroTile btnZero;
        private MetroFramework.Controls.MetroTile btnNine;
        private MetroFramework.Controls.MetroTile btnEight;
        private MetroFramework.Controls.MetroTile btnSeven;
        private MetroFramework.Controls.MetroTile btnSix;
        private MetroFramework.Controls.MetroTile btnFive;
        private MetroFramework.Controls.MetroTile btnFour;
        private MetroFramework.Controls.MetroTile btnTwo;
        private MetroFramework.Controls.MetroTile btnOne;
        private MetroFramework.Controls.MetroTile btnThree;
        private MetroFramework.Controls.MetroTile btnConfirm;
        private MetroFramework.Controls.MetroTile btnCancel;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroTile btnPoint;
        private MetroFramework.Controls.MetroComboBox CbAlcohol;
    }
}