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
                ViewController.ShowError(ex.Message);
            }
        }

        private void SelectTable(object sender)
        {
            try
            {
                if (sender is MetroTile)
                {
                    SelectedTable = (BarTable)((MetroTile)sender).Tag;
                }

                if (sender is MetroButton)
                {
                    SelectedTable = (BarTable)((MetroButton) sender).Tag;
                }


         
                switch (_windowMode)
                {
                    case WindowMode.Administration:
                        Close();
                        break;

                    case WindowMode.TableSelection:
                        Close();
                        break;

                    case WindowMode.SaleSelection:
                        if (BarTablesController.HasPendingSales(SelectedTable))
                        {
                            var frmTableSales = new FrmTableSales(SelectedTable);
                            frmTableSales.ShowDialog();

                            if (frmTableSales.SelectedSale != null)
                            {
                                AppGlobal.Sale = frmTableSales.SelectedSale;
                                frmTableSales.Dispose();
                                Close();
                            }
                            else
                            {
                                LoadData();
                            }
                        }
                        else
                        {
                            AppGlobal.Sale = new Sale();
                            Close();
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void AddTable()
        {
            try
            {
                var frmTablesSelector = new FrmTablesSelector(_tablesDistributed);
                frmTablesSelector.ShowDialog();

                var selectedTable = frmTablesSelector.SelectedTable;

                if (selectedTable != null)
                {
                    _tablesDistributed.Add(selectedTable);

                    if (File.Exists(selectedTable.ImagePath))
                    {
                        var btn = new MetroButton
                        {
                            Width = AppGlobal.AppGeneralConfig.TableButtonsDimension,
                            Height = AppGlobal.AppGeneralConfig.TableButtonsDimension,
                            Tag = selectedTable,
                            BackgroundImage = Image.FromFile(selectedTable.ImagePath),
                            BackgroundImageLayout = ImageLayout.Stretch
                        };

                        btn.Draggable(true);
                        btn.Click += ButtonTable_Click;

                        panelDistribution.Controls.Add(btn);
                    }
                    else
                    {
                        var btn = new MetroTile
                        {
                            Width = AppGlobal.AppGeneralConfig.TableButtonsDimension,
                            Height = AppGlobal.AppGeneralConfig.TableButtonsDimension,
                            Text = selectedTable.Name,
                            Tag = selectedTable,
                            Style = MetroColorStyle.Silver,
                            TextAlign = ContentAlignment.TopLeft,
                        };

                        btn.Draggable(true);
                        btn.Click += ButtonTable_Click;

                        panelDistribution.Controls.Add(btn);
                    }
                }
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                panelDistribution.BackgroundImage = Common.BytesToImage(AppGlobal.Company.LocalImage);
                panelDistribution.BackgroundImageLayout = ImageLayout.Stretch;
                panelDistribution.Controls.Clear();
                _tablesDistributed = BarTablesController.GetAllActiveWithLocation();

                foreach (var tableDistributed in _tablesDistributed)
                {
                    var hasPendingSales = BarTablesController.HasPendingSales(tableDistributed);

                    double totalPending = 0;
                    if (hasPendingSales)
                    {
                        totalPending = BarTablesController.GetTotalPending(tableDistributed);
                    }

                    var location = tableDistributed.Location.Split(',');
                    if (File.Exists(tableDistributed.ImagePath))
                    {
                        var btn = new MetroButton
                        {
                            Width = AppGlobal.AppGeneralConfig.TableButtonsDimension,
                            Height = AppGlobal.AppGeneralConfig.TableButtonsDimension,
                            Tag = tableDistributed,
                            BackgroundImage = Image.FromFile(tableDistributed.ImagePath),
                            BackgroundImageLayout = ImageLayout.Stretch,
                            Location = new Point(Convert.ToInt32(location[0]), Convert.ToInt32(location[1]))
                        };

                        if (_windowMode == WindowMode.Administration)
                          btn.Draggable(true);

                        btn.Click += ButtonTable_Click;

                        panelDistribution.Controls.Add(btn);
                    }
                    else
                    {
                        var btn = new MetroTile
                        {
                            Width = AppGlobal.AppGeneralConfig.TableButtonsDimension,
                            Height = AppGlobal.AppGeneralConfig.TableButtonsDimension,
                            Text = tableDistributed.Name + Environment.NewLine + totalPending.ToString("F") + "€",
                            Tag = tableDistributed,
                            Style = hasPendingSales ? MetroColorStyle.Red : MetroColorStyle.Green,
                            TextAlign = ContentAlignment.TopLeft,
                            Location = new Point(Convert.ToInt32(location[0]), Convert.ToInt32(location[1]))
                        };

                        if (_windowMode == WindowMode.Administration)
                            btn.Draggable(true);

                        btn.Click += ButtonTable_Click;

                        panelDistribution.Controls.Add(btn);
                    }
                }
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void Save()
        {
            try
            {
                var tablesToSave = new List<BarTable>();
                foreach (var tableControl in panelDistribution.Controls)
                {
                    if (tableControl is MetroTile)
                    {
                        var tableButton = ((MetroTile) tableControl);
                        var table = (BarTable) tableButton.Tag;

                        table.Location = tableButton.Location.X + "," + tableButton.Location.Y;
                        tablesToSave.Add(table);
                    }

                    if (tableControl is MetroButton)
                    {
                        var tableButton = ((MetroButton) tableControl);
                        var table = (BarTable) tableButton.Tag;

                        table.Location = tableButton.Location.X + "," + tableButton.Location.Y;
                        tablesToSave.Add(table);
                    }
                }

                foreach (var tableToSave in tablesToSave)
                {
                    BarTablesController.SaveOrUpdate(tableToSave);
                }

                ViewController.ShowAsterisk(@"Distribución guardada satisfactoriamente.");

            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        #endregion
    }
}