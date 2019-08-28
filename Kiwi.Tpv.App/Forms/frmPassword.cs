using System;
using System.Windows.Forms;
using Kiwi.Tpv.App.Util;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmPassword : MetroForm
    {
        public bool ValidPassword;

        public FrmPassword()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ValidatePassword();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            txtPassword.Select();
        }

        private void ValidatePassword()
        {
            if (AppGlobal.AppGeneralConfig.AdminPassword.Trim() != txtPassword.Text.Trim()) return;
            ValidPassword = true;
            Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int) Keys.Enter)
                ValidatePassword();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}