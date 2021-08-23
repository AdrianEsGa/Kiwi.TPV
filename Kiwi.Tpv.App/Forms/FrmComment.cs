using Kiwi.Tpv.App.Util;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmComment : MetroForm
    {
        public bool Confirmed;
        public string Comment;

        public FrmComment()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        #region Events

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            Confirm();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Cancel();
        }

        #endregion


        #region Methods

        private void Confirm()
        {
            Comment = TxtComment.Text.Trim();
            Confirmed = true;
            Close();
        }

        private void Cancel()
        {
            Confirmed = false;
            Close();
        }

        #endregion
    }
}
