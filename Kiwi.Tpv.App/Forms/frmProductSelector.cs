using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmProductSelector : MetroForm
    {
        public Product SelectedProduct;
        private readonly ProductType _typeToLoad;
        private bool _combination;

        public FrmProductSelector(ProductType typeToLoad, bool combination)
        {
            InitializeComponent();
            ViewController.SetSkin(this);
            _typeToLoad = typeToLoad;
            _combination = combination;

        }

        private void frmProductSelector_Load(object sender, EventArgs e)
        {
          
            switch (_typeToLoad)
            {
                case ProductType.Alcohol:
                    Text = "Alcohol";
                    break;
                case ProductType.Cerveza:
                    Text = "Cervezas";
                    break;
                case ProductType.Refresco:
                    Text = "Refrescos";
                    break;
                case ProductType.Cafes:
                    Text = "Cafés";
                    break;
                case ProductType.Tes:
                    Text = "Tés";
                    break;
                case ProductType.Cocktails:
                    Text = "Cocktails";
                    break;
                case ProductType.Comidas:
                    Text = "Comidas";
                    break;
            }

            PaintProductButtons();

            try
            {
                PictureBoxLogo.BackgroundImage = Common.BytesToImage(AppGlobal.Company.AppLogo);
                PictureBoxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch
            {
                // ignored
            }
        }

        private void PaintProductButtons()
        {
            var buttonSize = 90;
            var products = _combination ? ProductController.GetAllActive(_typeToLoad) 
                : ProductController.GetAllActiveAndNotShowInMainView(_typeToLoad);

            foreach (var product in products)
            {

                if (product.Image != null)
                {
                    var btn = new MetroButton
                    {
                        Width = buttonSize,
                        Height = buttonSize,
                        Tag = product,
                        BackgroundImage = Common.BytesToImage(product.Image),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    btn.Click += ButtonProduct_Click;

                    flowLayoutPanelProducts.Controls.Add(btn);
                }
                else
                {
                    var btn = new Button
                    {
                        Width = buttonSize,
                        Height = buttonSize,
                        Text = product.Name,
                        Tag = product,
                        BackColor = Color.DimGray,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular)
                    };

                    btn.Click += ButtonProduct_Click;

                    flowLayoutPanelProducts.Controls.Add(btn);
                }     
            }
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            SelectedProduct = (Product)btn.Tag;
            SelectedProduct.Quantity = 1;

            if (_combination) {SelectedProduct.SaleDayPrice = SelectedProduct.SaleCombinedPrice; SelectedProduct.SaleNightPrice = SelectedProduct.SaleCombinedPrice; }

            var alcoholModeType = AlcoholModeTypes.Default;
            if (AppGlobal.Company.CombinationControl && SelectedProduct.Type == ProductType.Alcohol)
            {
                ViewController.ShowPopUp();

                var frmAlcoholModeTypes = new FrmAlcoholModeTypes();
                frmAlcoholModeTypes.ShowDialog();
                alcoholModeType = frmAlcoholModeTypes.SelectedAlcoholModeType;

                if (alcoholModeType == AlcoholModeTypes.Combined && AppGlobal.Company.CombinationControlWithSoda)
                {
                    var frmProductSelector = new FrmProductSelector(ProductType.Refresco, true);
                    frmProductSelector.ShowDialog();
                }

                ViewController.HidePopUp();
            }

            FrmMain.Instance.AddProductToSale(SelectedProduct, alcoholModeType);
            FrmMain.Instance.RefreshScreen();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
