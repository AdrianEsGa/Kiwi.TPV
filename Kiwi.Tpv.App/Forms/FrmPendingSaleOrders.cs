using System;
using System.Collections.Generic;
using System.Linq;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmPendingSaleOrders : MetroForm
    {
        private SaleOrder _selectedSaleOrder;
        private List<SaleOrder> _pendingSaleOrders;

        public FrmPendingSaleOrders()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void FrmPendingSaleOrders_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DataGridViewTableSales_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            ShowSaleOrderDetails();
        }

        private void btnPaySelectedSale_Click(object sender, EventArgs e)
        {
            PaySelectedSaleOrder();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #region Private Methods

        private void LoadData()
        {
            try
            {
                DataGridViewTableSales.DataSource = null;
                DataGridViewTableSaleDetails.DataSource = null;

                _pendingSaleOrders = SaleOrdersController.GetAll(true);

                DataGridViewTableSales.DataSource = _pendingSaleOrders;

                if (DataGridViewTableSales.Rows.Count > 0)
                {
                    DataGridViewTableSales.ClearSelection();
                    DataGridViewTableSales.Rows[0].Selected = true;
                    ShowSaleOrderDetails();
                }

                txtTotalPending.Text = "Total: " + _pendingSaleOrders.Sum(x => x.Total).ToString("F") + " €";
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void ShowSaleOrderDetails()
        {
            if (DataGridViewTableSales.CurrentRow == null) return;

            _selectedSaleOrder = (SaleOrder)DataGridViewTableSales.CurrentRow.DataBoundItem;

            if (_selectedSaleOrder == null) return;

            DataGridViewTableSaleDetails.DataSource = _selectedSaleOrder.Details;
        }

        private void PaySelectedSaleOrder()
        {
            try
            {
                if (_selectedSaleOrder == null) return;

                var frmEmployeeSelector = new FrmEmployeeSelector();
                frmEmployeeSelector.ShowDialog();

                if (frmEmployeeSelector.SelectedEmployee != null)
                {
                    var frmConfirmPay = new FrmConfirmPay(frmEmployeeSelector.SelectedEmployee, _selectedSaleOrder);
                    frmConfirmPay.ShowDialog();
                    frmConfirmPay.Dispose();
                    _selectedSaleOrder = null;
                    LoadData();
                }

                frmEmployeeSelector.Dispose();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        #endregion
    }
}
