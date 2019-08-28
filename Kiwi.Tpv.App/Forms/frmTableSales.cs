using System;
using System.Windows.Forms;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmTableSales : MetroForm
    {
        public Sale SelectedSale;
        private readonly BarTable _selectedTable;

        public FrmTableSales()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        public FrmTableSales(BarTable table)
        {
            InitializeComponent();
            ViewController.SetSkin(this);
            _selectedTable = table;
        }

        private void frmTableSales_Load(object sender, EventArgs e)
        {
            try
            {
                DataGridViewTableSales.DataSource = SalesController.GetPendingsByTable(_selectedTable);
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);  
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewTableSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewTableSales.CurrentRow == null) return;
            SelectedSale = (Sale)DataGridViewTableSales.CurrentRow.DataBoundItem;
            Close();
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            SelectedSale = new Sale();
            Close();
        }
    }
}
