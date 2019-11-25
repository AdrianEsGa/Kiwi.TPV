using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmTableSales : MetroForm
    {
        public Sale SelectedSale;
        private readonly BarTable _selectedTable;
        private List<Sale> _pendingSales;
        private Sale _selectedSale;

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

        #region General Events 

        private void frmTableSales_Load(object sender, EventArgs e)
        {
           LoadData();
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

        private void btnPayAllSales_Click(object sender, EventArgs e)
        {
            PayAllSales();
        }

        private void btnPaySelectedSale_Click(object sender, EventArgs e)
        {
            PaySelectedSale();
        }

        private void btnMoveAllToOtherTable_Click(object sender, EventArgs e)
        {
            MoveAllSalesToOtherTable();
        }

        private void DataGridViewTableSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewTableSales.CurrentRow == null) return;

            _selectedSale = (Sale)DataGridViewTableSales.CurrentRow.DataBoundItem;

            if (_selectedSale == null) return;

            DataGridViewTableSaleDetails.DataSource = _selectedSale.Details;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Private Methods

        private void LoadData()
        {
            try
            {
                _pendingSales = SalesController.GetPendingsByTable(_selectedTable);
                DataGridViewTableSales.DataSource = _pendingSales;
                DataGridViewTableSaleDetails.DataSource = null;
                txtTotalPending.Text = _selectedTable.Name + " - Total: " + _pendingSales.Sum(pendingSale => pendingSale.Total).ToString("F") + " €"; 
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void PaySelectedSale()
        {
            try
            {
                var frmEmployeeSelector = new FrmEmployeeSelector();
                frmEmployeeSelector.ShowDialog();

                if (frmEmployeeSelector.SelectedEmployee != null)
                {
                    AppGlobal.Sale.Employee = frmEmployeeSelector.SelectedEmployee;
                    _selectedSale.Employee = frmEmployeeSelector.SelectedEmployee;
                    AppGlobal.Sale = _selectedSale;
                    var frmConfirmPay = new FrmConfirmPay(true);
                    frmConfirmPay.ShowDialog();
                    frmConfirmPay.Dispose();
                    AppGlobal.Sale = new Sale();
                    Close();
                }

                frmEmployeeSelector.Dispose();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void PayAllSales()
        {
            try
            {
                var frmEmployeeSelector = new FrmEmployeeSelector();
                frmEmployeeSelector.ShowDialog();

                if (frmEmployeeSelector.SelectedEmployee != null)
                {
                    AppGlobal.Sale.Employee = frmEmployeeSelector.SelectedEmployee;

                    foreach (var pendingSale in _pendingSales)
                    {
                        pendingSale.Employee = frmEmployeeSelector.SelectedEmployee;
                        AppGlobal.Sale = pendingSale;
                        var frmConfirmPay = new FrmConfirmPay(true);
                        frmConfirmPay.ShowDialog();
                        frmConfirmPay.Dispose();
                    }

                    AppGlobal.Sale = new Sale();
                    Close();
                }

                frmEmployeeSelector.Dispose();             
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void MoveAllSalesToOtherTable()
        {

            try
            {
                var frmTablesDistribution = new FrmTablesDistribution(FrmTablesDistribution.WindowMode.TableSelection);
                frmTablesDistribution.ShowDialog();

                if (frmTablesDistribution.SelectedTable == null) return;

                foreach (var pendingSale in _pendingSales)
                {
                    pendingSale.Table = frmTablesDistribution.SelectedTable;
                    SalesController.SaveOrUpdate(pendingSale);
                }

                frmTablesDistribution.Dispose();

                Close();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        #endregion

    }
}
