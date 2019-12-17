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

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            Comment = TxtComment.Text.Trim();
            Confirmed = true;
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Confirmed = false;
            Close();
        }
    }
}
