using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Kiwi.Tpv.App.Properties;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Controls;
using MetroFramework.Forms;


namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmProducts : MetroForm
    {
        private const char SignoDecimal = '.'; // Carácter separador decimal
        private string _prevTextBoxValue; // Variable que almacena el valor anterior del Textbox
        private Product _selectedProduct;

        public FrmProducts()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            CbProductType.Items.Add(ProductType.Alcohol);
            CbProductType.Items.Add(ProductType.Refresco);
            CbProductType.Items.Add(ProductType.Cerveza);
            CbProductType.Items.Add(ProductType.Cafes);
            CbProductType.Items.Add(ProductType.Tes);
            CbProductType.Items.Add(ProductType.Cocktails);
            CbProductType.Items.Add(ProductType.Infusiones);
            CbProductType.Items.Add(ProductType.Vinos);
            CbProductType.Items.Add(ProductType.Comidas);

            CbProductSubType.Items.Add(ProductSubType.Whisky);
            CbProductSubType.Items.Add(ProductSubType.Ginebra);
            CbProductSubType.Items.Add(ProductSubType.Ron);
            CbProductSubType.Items.Add(ProductSubType.Vodka);
            CbProductSubType.Items.Add(ProductSubType.Generico);

            cbSaleTaxTypes.DataSource = TaxTypeController.GetAll();
            cbPurchaseTaxTypes.DataSource = TaxTypeController.GetAll();

            _selectedProduct = new Product();
            BindingToControls();
            tabProducts.SelectedTab = tabProducts.TabPages[0];




        }

        #region Events

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void CbProductType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch ((ProductType)CbProductType.SelectedItem)
            {
                case ProductType.Alcohol:
                    CbProductSubType.Visible = true;
                    lblDayPrice.Text = "Precio combi. (Día)";
                    lblNightPrice.Text = "Precio combi. (Noche)";
                    AlcoholPricesPanel.Visible = true;
                    SodaPrices.Visible = false;
                    break;
                case ProductType.Refresco:
                    CbProductSubType.Visible = false;
                    SodaPrices.Visible = true;
                    AlcoholPricesPanel.Visible = false;
                    break;
                default:
                    CbProductSubType.Visible = false;
                    CbProductSubType.SelectedItem = ProductSubType.Generico;
                    lblDayPrice.Text = "Precio (Día)";
                    lblNightPrice.Text = "Precio (Noche)";
                    AlcoholPricesPanel.Visible = false;
                    SodaPrices.Visible = false;
                    break;
            }
        }

        private void DataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewProducts.CurrentRow == null) return;
            _selectedProduct = (Product) DataGridViewProducts.CurrentRow.DataBoundItem;

            if (_selectedProduct == null) return;

            BindingToControls();

            tabProducts.SelectedTab = tabProducts.TabPages[0];
        }

        private void pictureBoxProductImage_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = Resources.ImageFilters
            };

            if (file.ShowDialog() != DialogResult.OK) return;
            pictureBoxProductImage.BackgroundImage = Image.FromFile(file.FileName);
            pictureBoxProductImage.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxProductImage.Text = String.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        #endregion

        #region Methods 

        private void Search()
        {
            DataGridViewProducts.DataSource = ProductController.GetAll();
            DataGridViewProducts.ClearSelection();

            foreach (var column in DataGridViewProducts.Columns)
            {
                if (column is DataGridViewImageColumn)
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
            }

            tabProducts.SelectedTab = tabProducts.TabPages[1];
        }

        private void Save()
        {
            try
            {
                if (!ValidateData())
                {
                    ViewController.ShowWarning("Revisa los datos y vuelve a intentarlo.");
                    return;
                }

                BindingFromControls();
                _selectedProduct = ProductController.SaveOrUpdate(_selectedProduct);
                BindingToControls();

                ViewController.ShowAsterisk(@"Producto guardado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void Remove()
        {
            if (_selectedProduct == null || _selectedProduct.Id == 0)
            {
                ViewController.ShowWarning( @"¿Que estas intentando eliminar? Lo siento, pero no puedes.");
                return;
            }

            try
            {
                ProductController.Remove(_selectedProduct);
                NewData();

                ViewController.ShowAsterisk( @"Producto eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);

            }
        }

        private void NewData()
        {
            _selectedProduct = new Product();
            pictureBoxProductImage.Image = null;
            BindingToControls();
        }

        private void BindingToControls()
        {
            try
            {
                TxtProductId.Text = _selectedProduct.Id.ToString();
                CbProductType.SelectedItem = _selectedProduct.Type;
                CbProductSubType.SelectedItem = _selectedProduct.SubType;
                TxtProductName.Text = _selectedProduct.Name;        
                
                TxtSaleNightPrice.Text = _selectedProduct.SaleNightPrice.ToString(CultureInfo.InvariantCulture);
                TxtSaleDayPrice.Text = _selectedProduct.SaleDayPrice.ToString(CultureInfo.InvariantCulture);

                TxtSaleCupNightPrice.Text = _selectedProduct.SaleCupNightPrice.ToString(CultureInfo.InvariantCulture);
                TxtSaleCupDayPrice.Text = _selectedProduct.SaleCupDayPrice.ToString(CultureInfo.InvariantCulture);

                TxtSaleShotNightPrice.Text = _selectedProduct.SaleShotNightPrice.ToString(CultureInfo.InvariantCulture);
                TxtSaleShotDayPrice.Text = _selectedProduct.SaleShotDayPrice.ToString(CultureInfo.InvariantCulture);

                TxtSaleCombinedPrice.Text = _selectedProduct.SaleCombinedPrice.ToString(CultureInfo.InvariantCulture);

                TxtPurchasePrice.Text = _selectedProduct.PurchasePrice.ToString(CultureInfo.InvariantCulture);
                txtSaleUnits.Text = _selectedProduct.SaleUnits.ToString(CultureInfo.InvariantCulture);
                txtPurchaseUnits.Text = _selectedProduct.PurchaseUnits.ToString(CultureInfo.InvariantCulture);
                chkActive.Checked = _selectedProduct.Active;
                chkShowInMainView.Checked = _selectedProduct.ShowInMainView;
                cbSaleTaxTypes.SelectedIndex =
                    cbSaleTaxTypes.FindStringExact(
                        _selectedProduct.SaleTaxType.Percentaje.ToString(CultureInfo.InvariantCulture));

                cbPurchaseTaxTypes.SelectedIndex =
                    cbPurchaseTaxTypes.FindStringExact(
                        _selectedProduct.PurchaseTaxType.Percentaje.ToString(CultureInfo.InvariantCulture));

                pictureBoxProductImage.BackgroundImage = null;
                if (_selectedProduct.Image != null)
                {
                    pictureBoxProductImage.BackgroundImage = Common.BytesToImage(_selectedProduct.Image);
                    pictureBoxProductImage.BackgroundImageLayout = ImageLayout.Center;
                    pictureBoxProductImage.Text = String.Empty;
                }

                if (CbProductType.SelectedItem != null)
                {
                    switch ((ProductType) CbProductType.SelectedItem)
                    {
                        case ProductType.Alcohol:
                            CbProductSubType.Visible = true;
                            lblDayPrice.Text = "Precio combi. (Día)";
                            lblNightPrice.Text = "Precio combi. (Noche)";
                            AlcoholPricesPanel.Visible = true;
                            SodaPrices.Visible = false;
                            break;
                        case ProductType.Refresco:
                            SodaPrices.Visible = true;
                            CbProductSubType.Visible = false;
                            AlcoholPricesPanel.Visible = false;
                            break;
                        default:
                            CbProductSubType.Visible = false;
                            CbProductSubType.SelectedItem = ProductSubType.Generico;
                            lblDayPrice.Text = "Precio (Día)";
                            lblNightPrice.Text = "Precio (Noche)";
                            AlcoholPricesPanel.Visible = false;
                            SodaPrices.Visible = false;
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }

        }

        private void BindingFromControls()
        {
            _selectedProduct.Type = (ProductType) CbProductType.SelectedItem;
            _selectedProduct.SubType = (ProductSubType?) CbProductSubType.SelectedItem ?? ProductSubType.Generico;
            _selectedProduct.Name = TxtProductName.Text;

            _selectedProduct.Image = pictureBoxProductImage.BackgroundImage != null ? Common.ImageToBytes(pictureBoxProductImage.BackgroundImage) : null;

            _selectedProduct.SaleNightPrice = Convert.ToDouble(TxtSaleNightPrice.Text.Replace('.', ','));
            _selectedProduct.SaleDayPrice = Convert.ToDouble(TxtSaleDayPrice.Text.Replace('.', ','));

            _selectedProduct.SaleCupNightPrice = Convert.ToDouble(TxtSaleCupNightPrice.Text.Replace('.', ','));
            _selectedProduct.SaleCupDayPrice = Convert.ToDouble(TxtSaleCupDayPrice.Text.Replace('.', ','));

            _selectedProduct.SaleShotNightPrice = Convert.ToDouble(TxtSaleShotNightPrice.Text.Replace('.', ','));
            _selectedProduct.SaleShotDayPrice = Convert.ToDouble(TxtSaleShotDayPrice.Text.Replace('.', ','));

            _selectedProduct.SaleCombinedPrice = Convert.ToDouble(TxtSaleCombinedPrice.Text.Replace('.', ','));

            _selectedProduct.SaleTaxType = (TaxType) cbSaleTaxTypes.SelectedItem;
            _selectedProduct.PurchasePrice = Convert.ToDouble(TxtPurchasePrice.Text.Replace('.', ','));
            _selectedProduct.PurchaseTaxType = (TaxType) cbPurchaseTaxTypes.SelectedItem;
            _selectedProduct.SaleUnits = Convert.ToDouble(txtSaleUnits.Text.Replace('.', ','));
            _selectedProduct.PurchaseUnits = Convert.ToDouble(txtPurchaseUnits.Text.Replace('.', ','));
            _selectedProduct.Active = chkActive.Checked;
            _selectedProduct.ShowInMainView = chkShowInMainView.Checked;
        }

        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(TxtSaleNightPrice.Text)) return false;
            if (string.IsNullOrEmpty(TxtProductName.Text)) return false;
            return CbProductType.SelectedItem != null;
        }

        #endregion

        #region Numeric TextBox Validations And Window Keyboard

        private void NumericKeyPressValidation(object sender, KeyPressEventArgs e)
        {
            var textBox = (MetroTextBox)sender;
            // Si el carácter pulsado no es un carácter válido se anula
            e.Handled = !char.IsDigit(e.KeyChar) // No es dígito
                        && !char.IsControl(e.KeyChar) // No es carácter de control (backspace)
                        &&
                        (e.KeyChar != SignoDecimal // No es signo decimal o es la 1ª posición o ya hay un signo decimal
                         || textBox.SelectionStart == 0
                         || textBox.Text.Contains(SignoDecimal.ToString()));
        }

        private void NumericTextChangedValidation(object sender, EventArgs e)
        {
            var textBox = (MetroTextBox)sender;
            // Comprueba si el valor del TextBox se ajusta a un valor válido
            if (Regex.IsMatch(textBox.Text, @"^(?:\d+\.?\d*)?$"))
            {
                // Si es válido se almacena el valor actual en la variable privada
                _prevTextBoxValue = textBox.Text;
            }
            else
            {
                // Si no es válido se recupera el valor de la variable privada con el valor anterior
                // Calcula el nº de caracteres después del cursor para dejar el cursor en la misma posición
                var charsAfterCursor = textBox.Text.Length - textBox.SelectionStart - textBox.SelectionLength;
                // Recupera el valor anterior
                textBox.Text = _prevTextBoxValue;
                // Posiciona el cursor en la misma posición
                textBox.SelectionStart = Math.Max(0, textBox.Text.Length - charsAfterCursor);
            }
        }

        private void TxtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            NumericTextChangedValidation(sender, e);
        }

        private void TxtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericKeyPressValidation(sender, e);
        }

        private void TxtSalePrice_TextChanged(object sender, EventArgs e)
        {
            NumericTextChangedValidation(sender, e);
        }

        private void TxtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericKeyPressValidation(sender, e);
        }

        private void TxtSaleDayPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericKeyPressValidation(sender, e);
        }

        private void TxtSaleDayPrice_TextChanged(object sender, EventArgs e)
        {
            NumericTextChangedValidation(sender, e);
        }

        private void txtSaleUnits_TextChanged(object sender, EventArgs e)
        {
            NumericTextChangedValidation(sender, e);
        }

        private void txtSaleUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericKeyPressValidation(sender, e);
        }

        private void txtPurchaseUnits_TextChanged(object sender, EventArgs e)
        {
            NumericTextChangedValidation(sender, e);
        }

        private void txtPurchaseUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericKeyPressValidation(sender, e);
        }

        private void TxtSaleCupNightPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericKeyPressValidation(sender, e);
        }

        private void TxtSaleCupNightPrice_TextChanged(object sender, EventArgs e)
        {
            NumericTextChangedValidation(sender, e);
        }

        private void TxtSaleCupDayPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericKeyPressValidation(sender, e);
        }

        private void TxtSaleCupDayPrice_TextChanged(object sender, EventArgs e)
        {
            NumericTextChangedValidation(sender, e);
        }

        private void TxtSaleShotNightPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericKeyPressValidation(sender, e);
        }

        private void TxtSaleShotNightPrice_TextChanged(object sender, EventArgs e)
        {
            NumericTextChangedValidation(sender, e);
        }

        private void TxtSaleShotDayPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericKeyPressValidation(sender, e);
        }

        private void TxtSaleShotDayPrice_TextChanged(object sender, EventArgs e)
        {
            NumericTextChangedValidation(sender, e);
        }

        private void TxtProductName_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void TxtSaleNightPrice_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void TxtSaleDayPrice_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void TxtSaleCupNightPrice_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void TxtSaleCupDayPrice_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void TxtSaleShotNightPrice_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void TxtSaleShotDayPrice_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void TxtSaleCombinedPrice_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void TxtProductName_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        private void TxtSaleNightPrice_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        private void TxtSaleDayPrice_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        private void TxtSaleCupNightPrice_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        private void TxtSaleCupDayPrice_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        private void TxtSaleShotNightPrice_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        private void TxtSaleShotDayPrice_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        private void TxtSaleCombinedPrice_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }



        #endregion

        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            pictureBoxProductImage.BackgroundImage = null;
        }
    }
}