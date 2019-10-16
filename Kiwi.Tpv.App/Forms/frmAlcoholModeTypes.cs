using System;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class frmAlcoholModeTypes : MetroForm
    {
        public AlcoholModeTypes SelectedAlcoholModeType;

        public frmAlcoholModeTypes()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void BtnCombined_Click(object sender, EventArgs e)
        {
            SelectedAlcoholModeType = AlcoholModeTypes.Combined;
            Close();
        }

        private void BtnCup_Click(object sender, EventArgs e)
        {
            SelectedAlcoholModeType = AlcoholModeTypes.Cup;
            Close();
        }

        private void BtnShot_Click(object sender, EventArgs e)
        {
            SelectedAlcoholModeType = AlcoholModeTypes.Shot;
            Close();
        }
    }
}
