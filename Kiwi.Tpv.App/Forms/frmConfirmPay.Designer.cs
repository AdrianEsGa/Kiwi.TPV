namespace Kiwi.Tpv.App.Forms
{
    partial class FrmConfirmPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmPay));
            this.txtTotalToPay = new MetroFramework.Controls.MetroTextBox();
            this.btnConfirmCash = new MetroFramework.Controls.MetroTile();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.btnInvite = new MetroFramework.Controls.MetroTile();
            this.btnDisccount = new MetroFramework.Controls.MetroTile();
            this.btnConfirmCreditCard = new MetroFramework.Controls.MetroTile();
            this.btnConfirmCashTicket = new MetroFramework.Controls.MetroTile();
            this.btnConfirmCreditCardTicket = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // txtTotalToPay
            // 
            this.txtTotalToPay.BackColor = System.Drawing.SystemColors.ControlDark;
            // 
            // 
            // 
            this.txtTotalToPay.CustomButton.Image = null;
            this.txtTotalToPay.CustomButton.Location = new System.Drawing.Point(601, 2);
            this.txtTotalToPay.CustomButton.Name = "";
            this.txtTotalToPay.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtTotalToPay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalToPay.CustomButton.TabIndex = 1;
            this.txtTotalToPay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalToPay.CustomButton.UseSelectable = true;
            this.txtTotalToPay.CustomButton.Visible = false;
            this.txtTotalToPay.Enabled = false;
            this.txtTotalToPay.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTotalToPay.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTotalToPay.ForeColor = System.Drawing.Color.Green;
            this.txtTotalToPay.Lines = new string[] {
        "0"};
            this.txtTotalToPay.Location = new System.Drawing.Point(23, 69);
            this.txtTotalToPay.MaxLength = 32767;
            this.txtTotalToPay.Name = "txtTotalToPay";
            this.txtTotalToPay.PasswordChar = '\0';
            this.txtTotalToPay.ReadOnly = true;
            this.txtTotalToPay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalToPay.SelectedText = "";
            this.txtTotalToPay.SelectionLength = 0;
            this.txtTotalToPay.SelectionStart = 0;
            this.txtTotalToPay.ShortcutsEnabled = true;
            this.txtTotalToPay.Size = new System.Drawing.Size(639, 40);
            this.txtTotalToPay.TabIndex = 1;
            this.txtTotalToPay.Text = "0";
            this.txtTotalToPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalToPay.UseSelectable = true;
            this.txtTotalToPay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalToPay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConfirmCash
            // 
            this.btnConfirmCash.ActiveControl = null;
            this.btnConfirmCash.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmCash.Location = new System.Drawing.Point(24, 212);
            this.btnConfirmCash.Name = "btnConfirmCash";
            this.btnConfirmCash.Size = new System.Drawing.Size(307, 109);
            this.btnConfirmCash.Style = MetroFramework.MetroColorStyle.Green;
            this.btnConfirmCash.TabIndex = 4;
            this.btnConfirmCash.Text = "Confirmar Efectivo";
            this.btnConfirmCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmCash.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnConfirmCash.UseSelectable = true;
            this.btnConfirmCash.Click += new System.EventHandler(this.btnConfirmCash_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(24, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(639, 72);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInvite
            // 
            this.btnInvite.ActiveControl = null;
            this.btnInvite.Location = new System.Drawing.Point(356, 127);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(307, 57);
            this.btnInvite.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnInvite.TabIndex = 3;
            this.btnInvite.Text = "Invitar";
            this.btnInvite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInvite.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnInvite.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnInvite.UseSelectable = true;
            this.btnInvite.Click += new System.EventHandler(this.btnInvite_Click);
            // 
            // btnDisccount
            // 
            this.btnDisccount.ActiveControl = null;
            this.btnDisccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDisccount.ForeColor = System.Drawing.Color.Coral;
            this.btnDisccount.Location = new System.Drawing.Point(24, 127);
            this.btnDisccount.Name = "btnDisccount";
            this.btnDisccount.Size = new System.Drawing.Size(307, 57);
            this.btnDisccount.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnDisccount.TabIndex = 2;
            this.btnDisccount.Text = "Dto 1€";
            this.btnDisccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDisccount.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDisccount.UseSelectable = true;
            this.btnDisccount.Click += new System.EventHandler(this.btnDisccount_Click);
            // 
            // btnConfirmCreditCard
            // 
            this.btnConfirmCreditCard.ActiveControl = null;
            this.btnConfirmCreditCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmCreditCard.Location = new System.Drawing.Point(356, 212);
            this.btnConfirmCreditCard.Name = "btnConfirmCreditCard";
            this.btnConfirmCreditCard.Size = new System.Drawing.Size(307, 109);
            this.btnConfirmCreditCard.Style = MetroFramework.MetroColorStyle.Green;
            this.btnConfirmCreditCard.TabIndex = 6;
            this.btnConfirmCreditCard.Text = "Confirmar Tarjeta";
            this.btnConfirmCreditCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmCreditCard.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnConfirmCreditCard.UseSelectable = true;
            this.btnConfirmCreditCard.Click += new System.EventHandler(this.btnConfirmCreditCard_Click);
            // 
            // btnConfirmCashTicket
            // 
            this.btnConfirmCashTicket.ActiveControl = null;
            this.btnConfirmCashTicket.Location = new System.Drawing.Point(24, 349);
            this.btnConfirmCashTicket.Name = "btnConfirmCashTicket";
            this.btnConfirmCashTicket.Size = new System.Drawing.Size(307, 71);
            this.btnConfirmCashTicket.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnConfirmCashTicket.TabIndex = 7;
            this.btnConfirmCashTicket.Text = "Confirmar Efectivo Ticket";
            this.btnConfirmCashTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmCashTicket.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnConfirmCashTicket.UseSelectable = true;
            this.btnConfirmCashTicket.Click += new System.EventHandler(this.btnConfirmCashTicket_Click);
            // 
            // btnConfirmCreditCardTicket
            // 
            this.btnConfirmCreditCardTicket.ActiveControl = null;
            this.btnConfirmCreditCardTicket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmCreditCardTicket.ForeColor = System.Drawing.Color.Green;
            this.btnConfirmCreditCardTicket.Location = new System.Drawing.Point(356, 349);
            this.btnConfirmCreditCardTicket.Name = "btnConfirmCreditCardTicket";
            this.btnConfirmCreditCardTicket.Size = new System.Drawing.Size(307, 71);
            this.btnConfirmCreditCardTicket.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnConfirmCreditCardTicket.TabIndex = 8;
            this.btnConfirmCreditCardTicket.Text = "Confirmar Tarjeta Ticket";
            this.btnConfirmCreditCardTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmCreditCardTicket.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnConfirmCreditCardTicket.UseSelectable = true;
            this.btnConfirmCreditCardTicket.Click += new System.EventHandler(this.btnConfirmCreditCardTicket_Click);
            // 
            // FrmConfirmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 542);
            this.ControlBox = false;
            this.Controls.Add(this.txtTotalToPay);
            this.Controls.Add(this.btnConfirmCreditCardTicket);
            this.Controls.Add(this.btnConfirmCashTicket);
            this.Controls.Add(this.btnConfirmCreditCard);
            this.Controls.Add(this.btnDisccount);
            this.Controls.Add(this.btnInvite);
            this.Controls.Add(this.btnConfirmCash);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmConfirmPay";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Finalizar venta";
            this.Load += new System.EventHandler(this.FrmConfirmPay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtTotalToPay;
        private MetroFramework.Controls.MetroTile btnConfirmCash;
        private MetroFramework.Controls.MetroTile btnCancel;
        private MetroFramework.Controls.MetroTile btnInvite;
        private MetroFramework.Controls.MetroTile btnDisccount;
        private MetroFramework.Controls.MetroTile btnConfirmCreditCard;
        private MetroFramework.Controls.MetroTile btnConfirmCashTicket;
        private MetroFramework.Controls.MetroTile btnConfirmCreditCardTicket;
    }
}