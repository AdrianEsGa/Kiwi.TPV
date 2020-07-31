using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Kiwi.Tpv.App.Properties;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework;
using MetroFramework.Controls;

namespace Kiwi.Tpv.App.Util
{

    public static class MainViewProductButtonsController
    {
        private static List<Product> _products = new List<Product>();
        public static void PaintProducts()
        {
            try
            {
      
                ClearFlowLayouts();

                InitializeFlowLayouts();

                _products = ProductController.GetAllActive();

                foreach (var product in _products)
                {
                    if (product.Image != null)
                    {
                        PaintProductImageButtons(product);
                    }
                    else
                    {
                        PaintProductButtons(product);
                    }
                }

                PaintProductBottleTile();
                PaintProductSecondaryMenus();

            }
            catch (Exception)
            {
                // ignored
            }

        }

        public static void InitializeFlowLayouts()
        {
            FrmMain.Instance.flowLayoutPanelAlcohol.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelAlcohol.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelAlcohol.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FrmMain.Instance.flowLayoutPanelSoda.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelSoda.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelSoda.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FrmMain.Instance.flowLayoutPanelBeer.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelBeer.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelBeer.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FrmMain.Instance.flowLayoutPanelCafes.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelCafes.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelCafes.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FrmMain.Instance.flowLayoutPanelTes.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelTes.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelTes.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FrmMain.Instance.flowLayoutPanelInfusiones.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelInfusiones.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelInfusiones.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FrmMain.Instance.flowLayoutPanelCocktails.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelCocktails.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelCocktails.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FrmMain.Instance.flowLayoutPanelVinos.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelVinos.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelVinos.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FrmMain.Instance.flowLayoutPanelVarious.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelVarious.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelVarious.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FrmMain.Instance.flowLayoutPanelSecondaryMenus.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelSecondaryMenus.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelSecondaryMenus.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }

        private static void ClearFlowLayouts()
        {
            FrmMain.Instance.flowLayoutPanelAlcohol.Controls.Clear();
            FrmMain.Instance.flowLayoutPanelSoda.Controls.Clear();
            FrmMain.Instance.flowLayoutPanelBeer.Controls.Clear();
            FrmMain.Instance.flowLayoutPanelCafes.Controls.Clear();
            FrmMain.Instance.flowLayoutPanelInfusiones.Controls.Clear();
            FrmMain.Instance.flowLayoutPanelTes.Controls.Clear();
            FrmMain.Instance.flowLayoutPanelCocktails.Controls.Clear();
            FrmMain.Instance.flowLayoutPanelVinos.Controls.Clear();
            FrmMain.Instance.flowLayoutPanelVarious.Controls.Clear();
            FrmMain.Instance.flowLayoutPanelSecondaryMenus.Controls.Clear();
        }

        private static void PaintProductImageButtons(Product product)
        {
            var btn = new MetroButton
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = product,
                BackgroundImage = Common.BytesToImage(product.Image),
                BackgroundImageLayout = ImageLayout.Stretch
            };

            btn.Click += FrmMain.Instance.ButtonProduct_Click;

            switch (product.Type)
            {
                case ProductType.Alcohol:
                    FrmMain.Instance.flowLayoutPanelAlcohol.Controls.Add(btn);
                    break;
                case ProductType.Refresco:
                    FrmMain.Instance.flowLayoutPanelSoda.Controls.Add(btn);
                    break;
                case ProductType.Cerveza:
                    FrmMain.Instance.flowLayoutPanelBeer.Controls.Add(btn);
                    break;
                case ProductType.Cafes:
                    FrmMain.Instance.flowLayoutPanelCafes.Controls.Add(btn);
                    break;
                case ProductType.Tes:
                    FrmMain.Instance.flowLayoutPanelTes.Controls.Add(btn);
                    break;
                case ProductType.Infusiones:
                    FrmMain.Instance.flowLayoutPanelInfusiones.Controls.Add(btn);
                    break;
                case ProductType.Cocktails:
                    FrmMain.Instance.flowLayoutPanelCocktails.Controls.Add(btn);
                    break;
                case ProductType.Vinos:
                    FrmMain.Instance.flowLayoutPanelVinos.Controls.Add(btn);
                    break;
                case ProductType.Varios:
                    FrmMain.Instance.flowLayoutPanelVarious.Controls.Add(btn);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static void PaintProductButtons(Product product)
        {
            var btn = new Button
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Text = product.Name,
                Tag = product,
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular)
            };

            btn.Click += FrmMain.Instance.ButtonProduct_Click;

            switch (product.Type)
            {
                case ProductType.Alcohol:
                    FrmMain.Instance.flowLayoutPanelAlcohol.Controls.Add(btn);
                    break;
                case ProductType.Refresco:
                    FrmMain.Instance.flowLayoutPanelSoda.Controls.Add(btn);
                    break;
                case ProductType.Cerveza:
                    FrmMain.Instance.flowLayoutPanelBeer.Controls.Add(btn);
                    break;
                case ProductType.Cafes:
                    FrmMain.Instance.flowLayoutPanelCafes.Controls.Add(btn);
                    break;
                case ProductType.Tes:
                    FrmMain.Instance.flowLayoutPanelTes.Controls.Add(btn);
                    break;
                case ProductType.Infusiones:
                    FrmMain.Instance.flowLayoutPanelInfusiones.Controls.Add(btn);
                    break;
                case ProductType.Cocktails:
                    FrmMain.Instance.flowLayoutPanelCocktails.Controls.Add(btn);
                    break;
                case ProductType.Vinos:
                    FrmMain.Instance.flowLayoutPanelVinos.Controls.Add(btn);
                    break;
                case ProductType.Varios:
                    FrmMain.Instance.flowLayoutPanelVarious.Controls.Add(btn);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static void PaintProductBottleTile()
        {
            //Create button botella
            var btnBottle = new Button()
            {
                Width = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.ProductButtonsDimension,
                Tag = "Bottle",
                Text = Resources.Botella,
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular)
            };

            btnBottle.Click += FrmMain.Instance.ButtonProduct_Click;

            FrmMain.Instance.flowLayoutPanelAlcohol.Controls.Add(btnBottle);
        }

        private static void PaintProductSecondaryMenus()
        {

            //Create button Alcohol
            var btnAlcohol = new Button()
            {
                Width = 65,
                Height = 40,
                Tag = "Alcohol",
                Text = "Alcohol",
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                FlatAppearance = { BorderColor = Color.FromArgb(209, 17, 65), BorderSize = 1 }
            };

            btnAlcohol.Click += FrmMain.Instance.ButtonProduct_Click;

            FrmMain.Instance.flowLayoutPanelSecondaryMenus.Controls.Add(btnAlcohol);

            //Create button Refrescos
            var btnRefrescos = new Button()
            {
                Width = 65,
                Height = 40,
                Tag = "Refrescos",
                Text = "Refrescos",
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                FlatAppearance = { BorderColor = Color.FromArgb(209, 17, 65), BorderSize = 1 }
            };

            btnRefrescos.Click += FrmMain.Instance.ButtonProduct_Click;

            FrmMain.Instance.flowLayoutPanelSecondaryMenus.Controls.Add(btnRefrescos);

            //Create button Cervezas
            var btnCervezas = new Button()
            {
                Width = 65,
                Height = 40,
                Tag = "Cervezas",
                Text = "Cervezas",
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                FlatAppearance = { BorderColor = Color.FromArgb(209, 17, 65), BorderSize = 1 }
            };

            btnCervezas.Click += FrmMain.Instance.ButtonProduct_Click;

            FrmMain.Instance.flowLayoutPanelSecondaryMenus.Controls.Add(btnCervezas);

            //Create button Cafes
            var btnCafes = new Button()
            {
                Width = 65,
                Height = 40,
                Tag = "Cafes",
                Text = "Cafés",
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                FlatAppearance = { BorderColor = Color.FromArgb(209, 17, 65), BorderSize = 1 }
            };

            btnCafes.Click += FrmMain.Instance.ButtonProduct_Click;

            FrmMain.Instance.flowLayoutPanelSecondaryMenus.Controls.Add(btnCafes);

            //Create button Tes
            var btnTes = new Button()
            {
                Width = 65,
                Height = 40,
                Tag = "Tes",
                Text = "Tés",
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                FlatAppearance = { BorderColor = Color.FromArgb(209, 17, 65), BorderSize = 1 }
            };

            btnTes.Click += FrmMain.Instance.ButtonProduct_Click;

            FrmMain.Instance.flowLayoutPanelSecondaryMenus.Controls.Add(btnTes);

            //Create button Cocktails
            var btnCocktails = new Button()
            {
                Width = 65,
                Height = 40,
                Tag = "Cocktails",
                Text = "Cocktails",
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                FlatAppearance = { BorderColor = Color.FromArgb(209, 17, 65), BorderSize = 1 }
            };

            btnCocktails.Click += FrmMain.Instance.ButtonProduct_Click;

            FrmMain.Instance.flowLayoutPanelSecondaryMenus.Controls.Add(btnCocktails);

            //Create button Infusiones
            var btnInfusiones = new Button()
            {
                Width = 65,
                Height = 40,
                Tag = "Infusiones",
                Text = "Infusiones",
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                FlatAppearance = { BorderColor = Color.FromArgb(209, 17, 65), BorderSize = 1 }
            };

            btnInfusiones.Click += FrmMain.Instance.ButtonProduct_Click;

            FrmMain.Instance.flowLayoutPanelSecondaryMenus.Controls.Add(btnInfusiones);

            //Create button Vinos
            var btnVinos = new Button()
            {
                Width = 65,
                Height = 40,
                Tag = "Vinos",
                Text = "Vinos",
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                FlatAppearance = { BorderColor = Color.FromArgb(209, 17, 65), BorderSize = 1 }
            };

            btnVinos.Click += FrmMain.Instance.ButtonProduct_Click;

            FrmMain.Instance.flowLayoutPanelSecondaryMenus.Controls.Add(btnVinos);

            //Create button Varios
            var btnVarios = new Button()
            {
                Width = 65,
                Height = 40,
                Tag = "Varios",
                Text = "Varios",
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                FlatAppearance = { BorderColor = Color.FromArgb(209, 17, 65), BorderSize = 1 }
            };

            btnVarios.Click += FrmMain.Instance.ButtonProduct_Click;

            FrmMain.Instance.flowLayoutPanelSecondaryMenus.Controls.Add(btnVarios);
        }

    }
}
