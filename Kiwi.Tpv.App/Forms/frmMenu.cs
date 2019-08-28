using Kiwi.Tpv.App.Util;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmMenu : MetroForm
    {
        public FrmMenu()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void btnEmployess_Click(object sender, System.EventArgs e)
        {
            var frmEmployees = new FrmEmployees();
            frmEmployees.ShowDialog();
        }

        private void btnProducts_Click(object sender, System.EventArgs e)
        {
            var frmProducts = new FrmProducts();
            frmProducts.ShowDialog();
        }

        private void btnHistory_Click(object sender, System.EventArgs e)
        {
            var frmHistory = new FrmHistory();
            frmHistory.ShowDialog();
        }

        private void btnConfig_Click(object sender, System.EventArgs e)
        {
            var frmConfig = new FrmConfiguration();
            frmConfig.ShowDialog();
        }

        private void btnTables_Click(object sender, System.EventArgs e)
        {
            var frmTables = new FrmTables();
            frmTables.ShowDialog();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
