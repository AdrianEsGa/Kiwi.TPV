using System;
using System.Globalization;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmBottle : MetroForm
    {
        private TxtFocusState _focusIn;
        private string _price;
        private string _quantity;
        public Product Bottle;

        public FrmBottle()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        #region Events

        private void frmBottle_Load(object sender, EventArgs e)
        {
            CbAlcohol.DataSource = ProductController.GetAllActive(ProductType.Alcohol);
            _focusIn = TxtFocusState.None;
            Bottle = null;
            CbAlcohol.SelectedItem = null;
            RefreshTextBox();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            WriteValue("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            WriteValue("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            WriteValue("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            WriteValue("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            WriteValue("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            WriteValue("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            WriteValue("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            WriteValue("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            WriteValue("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            WriteValue("0");
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            WriteValue(",");
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            EraseTextBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CbAlcohol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TxtQuantity.Focus();
            _focusIn = TxtFocusState.Quantity;
        }

        private void TxtQuantity_Click(object sender, EventArgs e)
        {
            _focusIn = TxtFocusState.Quantity;
        }

        private void TxtPrice_Click(object sender, EventArgs e)
        {
            _focusIn = TxtFocusState.Price;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (_quantity == "0" || _price == "0" || CbAlcohol.SelectedItem == null) return;
                Bottle = (Product) CbAlcohol.SelectedItem;
                Bottle.Name = "Botella " + Bottle.Name;
                Bottle.Quantity = Convert.ToInt16(_quantity);
                Bottle.SalePrice = Convert.ToDouble(_price);
                Bottle.Type = ProductType.Botella;
                Close();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        #endregion

        #region Methods

        private void WriteValue(string value)
        {
            switch (_focusIn)
            {
                case TxtFocusState.None:
                    return;
                case TxtFocusState.Quantity:
                    if (_quantity.Length == 3) return;
                    _quantity += value;
                    break;

                case TxtFocusState.Price:
                    if (_price.Length == 5) return;
                    _price += value;
                    break;
            }

            RefreshTextBox();
        }

        private void RefreshTextBox()
        {
            TxtQuantity.Text = Convert.ToDouble(_quantity).ToString(CultureInfo.InvariantCulture);
            TxtPrice.Text = _price;
            _quantity = TxtQuantity.Text;
            _price = TxtPrice.Text;
        }

        private void EraseTextBox()
        {
            switch (_focusIn)
            {
                case TxtFocusState.Quantity:
                    _quantity = "0";
                    TxtQuantity.Focus();
                    break;

                case TxtFocusState.Price:
                    _price = "0";
                    TxtPrice.Focus();
                    break;
            }

            RefreshTextBox();
        }


        #endregion

        private enum TxtFocusState
        {
            None,
            Quantity,
            Price
        }
    }
}