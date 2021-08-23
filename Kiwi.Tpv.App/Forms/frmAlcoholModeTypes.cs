using System;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmAlcoholModeTypes : MetroForm
    {
        public AlcoholModeTypes SelectedAlcoholModeType;

        public FrmAlcoholModeTypes()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        #region Events

        private void BtnCombined_Click(object sender, EventArgs e)
        {
            SelectType(AlcoholModeTypes.Combined);
        }

        private void BtnCup_Click(object sender, EventArgs e)
        {
            SelectType(AlcoholModeTypes.Cup);
        }

        private void BtnShot_Click(object sender, EventArgs e)
        {
            SelectType(AlcoholModeTypes.Shot);
        }

        #endregion


        #region Methods

        private void SelectType(AlcoholModeTypes type)
        {
            SelectedAlcoholModeType = type;
            Close();
        }

        #endregion
    }
}
