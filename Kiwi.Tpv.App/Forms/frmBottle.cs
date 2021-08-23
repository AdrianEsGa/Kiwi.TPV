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
            try
            {
                InitialLoad();
            }
            catch(Exception ex)
            {
                ViewController.ShowError(ex);
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue("1");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }          
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue("2");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }           
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue("3");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }         
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue("4");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }        
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue("5");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }          
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue("6");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }          
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue("7");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }          
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue("8");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }          
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue("9");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }          
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue("0");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }         
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            try
            {
                WriteValue(",");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }       
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            try
            {
                EraseTextBox();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }
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
                Confirm();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }
        }

        #endregion

        #region Methods

        private void InitialLoad()
        {
            CbAlcohol.DataSource = ProductController.GetAllActive(ProductType.Alcohol);
            _focusIn = TxtFocusState.None;
            Bottle = null;
            CbAlcohol.SelectedItem = null;
            RefreshTextBox();
        }

        private void Confirm()
        {
            if (_quantity == "0" || _price == "0" || CbAlcohol.SelectedItem == null) return;
            Bottle = (Product)CbAlcohol.SelectedItem;
            Bottle.Name = "Botella " + Bottle.Name;
            Bottle.Quantity = Convert.ToInt16(_quantity);
            Bottle.SalePrice = Convert.ToDouble(_price);
            Bottle.Type = ProductType.Botella;
            Close();
        }

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