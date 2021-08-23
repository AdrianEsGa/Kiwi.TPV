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
    public partial class FrmTablesDistribution : MetroForm
    {
        private List<BarTable> _tablesDistributed;
        private readonly WindowMode _windowMode;
        public BarTable SelectedTable;

        public enum WindowMode
        {
            Administration = 1,
            TableSelection = 2,
            SaleSelection = 3
        }      

        public FrmTablesDistribution(WindowMode windowMode)
        {
            InitializeComponent();
            ViewController.SetSkin(this);
            _windowMode = windowMode;
        }

        private void frmTablesDistribution_Load(object sender, EventArgs e)
        {
            panelButons.Visible = _windowMode == WindowMode.Administration;

            LoadData();
            BringToFront();

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

        #region Events

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            AddTable();
        }

        private void ButtonTable_Click(object sender, EventArgs e)
        {
            SelectTable(sender);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods 

        private void Remove()
        {
            try
            {
                Save();
                BarTablesController.RemoveDistribution(SelectedTable);
                _tablesDistributed.Remove(SelectedTable);
                LoadData();
                ViewController.ShowAsterisk(@"Mesa eliminada de la distribución satisfactoriamente.");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }
        }

        private void SelectTable(object sender)
        {
            try
            {
                if (sender is Button)
                {
                    SelectedTable = (BarTable)((Button)sender).Tag;
                }

                switch (_windowMode)
                {
                    case WindowMode.TableSelection:
                        Close();
                        break;

                    case WindowMode.SaleSelection:
                        if (BarTablesController.HasSales(SelectedTable))
                        {
                            var frmTableSales = new FrmTableSaleOrders(SelectedTable);
                            frmTableSales.ShowDialog();

                            if (frmTableSales.SelectedSaleOrder != null)
                            {
                                AppGlobal.SaleOrder = frmTableSales.SelectedSaleOrder;
                                frmTableSales.Dispose();
                                Close();
                            }
                            else
                            {
                                SelectedTable = null;
                                LoadData();
                            }
                        }
                        else
                        {
                            AppGlobal.SaleOrder = new SaleOrder();
                            Close();
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }
        }

        private void AddTable()
        {
            try
            {
                var frmTablesSelector = new FrmTablesSelector(_tablesDistributed);
                frmTablesSelector.ShowDialog();

                var selectedTable = frmTablesSelector.SelectedTable;

                if (selectedTable == null) return;
                _tablesDistributed.Add(selectedTable);

                var btn = new Button
                {
                    Width = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                    Height = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                    Text = selectedTable.Name,
                    Tag = selectedTable,                    
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold),                    
                };

                if (selectedTable.Type == BarTable.BarTableType.Barra)
                {
                    btn.Width = (AppGlobal.AppGeneralConfig.TableButtonsDimension / 2) + 10;
                    btn.Height = (AppGlobal.AppGeneralConfig.TableButtonsDimension / 2) + 10;
                }
                else
                {
                    btn.Width = AppGlobal.AppGeneralConfig.TableButtonsDimension;
                    btn.Height = AppGlobal.AppGeneralConfig.TableButtonsDimension;
                }

                btn.Draggable(true);
                btn.Click += ButtonTable_Click;

                panelDistribution.Controls.Add(btn);
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }
        }

        private void LoadData()
        {
            try
            {
                Visible = false;

                panelDistribution.BackgroundImage = Common.BytesToImage(AppGlobal.Company.LocalImage);
                panelDistribution.BackgroundImageLayout = ImageLayout.Stretch;
                panelDistribution.Controls.Clear();
                _tablesDistributed = BarTablesController.GetAllActiveWithLocation();

                foreach (var tableDistributed in _tablesDistributed)
                {
                    var hasPendingSales = BarTablesController.HasSales(tableDistributed);

                    double totalPending = 0;
                    if (hasPendingSales)
                    {
                        totalPending = BarTablesController.GetSaleOrdersTotal(tableDistributed);
                    }

                    var location = tableDistributed.Location.Split(',');

                    var btn = new Button
                    {
                        Width = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                        Height = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                        Text = tableDistributed.Name + Environment.NewLine + totalPending.ToString("F") + "€",
                        Tag = tableDistributed,
                        BackColor = hasPendingSales ? Color.FromArgb(209, 17, 65) : Color.FromArgb(0, 177, 89),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold),
                        Location = new Point(Convert.ToInt32(location[0]), Convert.ToInt32(location[1]))
                    };

                    if (tableDistributed.Type == BarTable.BarTableType.Barra)
                    {
                        btn.Width = (AppGlobal.AppGeneralConfig.TableButtonsDimension / 2) + 10;
                        btn.Height = (AppGlobal.AppGeneralConfig.TableButtonsDimension / 2) + 10;
                    }
                    else
                    {
                        btn.Width = AppGlobal.AppGeneralConfig.TableButtonsDimension;
                        btn.Height = AppGlobal.AppGeneralConfig.TableButtonsDimension;
                    }

                    if (_windowMode == WindowMode.Administration)
                        btn.Draggable(true);

                    btn.Click += ButtonTable_Click;

                    panelDistribution.Controls.Add(btn);

                    Visible = true;

                }
            }
            catch (Exception ex)
            {
                Visible = true;
                ViewController.ShowError(ex);
            }
        }

        private void Save()
        {
            try
            {
                var tablesToSave = new List<BarTable>();
                foreach (var tableControl in panelDistribution.Controls)
                {
                    if (!(tableControl is Button)) continue;

                    var tableButton = ((Button) tableControl);
                    var table = (BarTable) tableButton.Tag;

                    table.Location = tableButton.Location.X + "," + tableButton.Location.Y;
                    tablesToSave.Add(table);
                }

                foreach (var tableToSave in tablesToSave)
                {
                    BarTablesController.SaveOrUpdate(tableToSave);
                }

                ViewController.ShowAsterisk(@"Distribución guardada satisfactoriamente.");

            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }
        }

        #endregion
    }
}