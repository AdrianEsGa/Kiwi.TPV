using System;
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

        public FrmProductSelector(ProductType typeToLoad)
        {
            InitializeComponent();
            ViewController.SetSkin(this);
            _typeToLoad = typeToLoad;
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
                case ProductType.Varios:
                    Text = "Varios";
                    break;
            }

            PaintProductButtons();
        }

        private void PaintProductButtons()
        {
            var products = ProductController.GetAllActiveAndNotShowInMainView(_typeToLoad);

            foreach (var product in products)
            {

                if (File.Exists(product.ImagePath))
                {
                    var btn = new MetroButton
                    {
                        Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension + 25,
                        Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                        Tag = product,
                        BackgroundImage = Image.FromFile(product.ImagePath),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    btn.Click += ButtonProduct_Click;

                    flowLayoutPanelProducts.Controls.Add(btn);
                }
                else
                {
                    var btn = new MetroTile
                    {
                        Width = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension + 25,
                        Height = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                        TileTextFontWeight = MetroTileTextWeight.Regular,
                        TileTextFontSize = MetroTileTextSize.Small,
                        Text = product.Name,
                        Tag = product,
                        Style = MetroColorStyle.Silver,
                        TextAlign = ContentAlignment.TopLeft,
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
            FrmMain.Instance.AddProductToSale(SelectedProduct);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
