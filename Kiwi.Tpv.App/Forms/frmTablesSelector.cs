using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmTablesSelector : MetroForm
    {
        private readonly List<BarTable> _distributedTables;
        public BarTable SelectedTable;

        public FrmTablesSelector(List<BarTable> distributedTables)
        {
            InitializeComponent();
            ViewController.SetSkin(this);
            _distributedTables = distributedTables;
        }

        public FrmTablesSelector()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void frmTablesSelector_Load(object sender, EventArgs e)
        {
            PaintProductButtons();
        }

        private bool IsInDistributedPanel(BarTable table)
        {
            foreach (var distributedTable in _distributedTables)
            {
                if (table.Id == distributedTable.Id)
                {
                    return true;
                }
            }

            return false;
        }

        private void PaintProductButtons()
        {
            var tables = BarTablesController.GetAllActiveWithoutLocation();

            foreach (var table in tables)
            {

                if (_distributedTables != null && IsInDistributedPanel(table)) continue;

                    var btn = new Button
                    {
                        Width = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                        Height = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                        Text = table.Name,
                        Tag = table,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold),
                     
                    };

                    if (table.Type == BarTable.BarTableType.Barra)
                    {
                        btn.Width = (AppGlobal.AppGeneralConfig.TableButtonsDimension / 2) + 10;
                        btn.Height = (AppGlobal.AppGeneralConfig.TableButtonsDimension / 2) + 10;
                    }
                    else
                    {
                        btn.Width = AppGlobal.AppGeneralConfig.TableButtonsDimension;
                        btn.Height = AppGlobal.AppGeneralConfig.TableButtonsDimension;
                    }

                    btn.Click += ButtonProduct_Click;

                    flowLayoutPanelTables.Controls.Add(btn);              
            }
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            SelectedTable = (BarTable)btn.Tag;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
