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
    public partial class FrmTableSaleOrders : MetroForm
    {
        public SaleOrder SelectedSaleOrder;
        private readonly BarTable _selectedTable;
        private List<SaleOrder> _pendingSaleOrders;

        public FrmTableSaleOrders()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        public FrmTableSaleOrders(BarTable table)
        {
            InitializeComponent();
            ViewController.SetSkin(this);
            _selectedTable = table;
        }

        #region General Events 

        private void frmTableSaleOrders_Load(object sender, EventArgs e)
        {
           LoadData();
        }

        private void DataGridViewTableSaleOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewTableSales.CurrentRow == null) return;
            SelectedSaleOrder = (SaleOrder)DataGridViewTableSales.CurrentRow.DataBoundItem;
            Close();
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            SelectedSaleOrder = new SaleOrder();
            Close();
        }

        private void btnPaySelectedSaleOrder_Click(object sender, EventArgs e)
        {
            if (SelectedSaleOrder == null || SelectedSaleOrder.Id == 0) return;
            PaySelectedSaleOrder();
        }

        private void btnMoveAllToOtherTable_Click(object sender, EventArgs e)
        {
            MoveAllSaleOrdersToOtherTable();
        }

        private void DataGridViewTableSaleOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowSaleOrderDetails();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMoveToPendingSaleOrders_Click(object sender, EventArgs e)
        {
            MoveToPendingSaleOrders();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SelectedSaleOrder = null;
            Close();
        }

        #endregion

        #region Private Methods

        private void LoadData()
        {
            try
            {
                DataGridViewTableSales.DataSource = null;
                DataGridViewTableSaleDetails.DataSource = null;

                _pendingSaleOrders = SaleOrdersController.GetByTable(_selectedTable, false);
           
                DataGridViewTableSales.DataSource = _pendingSaleOrders;
        
                if (DataGridViewTableSales.Rows.Count > 0)
                {
                    DataGridViewTableSales.ClearSelection();
                    DataGridViewTableSales.Rows[0].Selected = true;
                    ShowSaleOrderDetails();
                }
              
                txtTotalPending.Text = _selectedTable.Name + " - Total: " + _pendingSaleOrders.Sum( x => x.Total).ToString("F") + " €"; 
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void ShowSaleOrderDetails()
        {
            if (DataGridViewTableSales.CurrentRow == null) return;

            SelectedSaleOrder = (SaleOrder)DataGridViewTableSales.CurrentRow.DataBoundItem;

            if (SelectedSaleOrder == null) return;

            DataGridViewTableSaleDetails.DataSource = SelectedSaleOrder.Details;
        }

        private void PaySelectedSaleOrder()
        {
            try
            {
                var frmEmployeeSelector = new FrmEmployeeSelector();
                frmEmployeeSelector.ShowDialog();

                if (frmEmployeeSelector.SelectedEmployee != null)
                {                  
                    var frmConfirmPay = new FrmConfirmPay(frmEmployeeSelector.SelectedEmployee, SelectedSaleOrder);
                    frmConfirmPay.ShowDialog();
                    frmConfirmPay.Dispose();
                    SelectedSaleOrder = null;
                    Close();
                }

                frmEmployeeSelector.Dispose();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void MoveAllSaleOrdersToOtherTable()
        {

            try
            {
                var frmTablesDistribution = new FrmTablesDistribution(FrmTablesDistribution.WindowMode.TableSelection);
                frmTablesDistribution.ShowDialog();

                if (frmTablesDistribution.SelectedTable == null) return;

                foreach (var pendingSale in _pendingSaleOrders)
                {
                    pendingSale.Table = frmTablesDistribution.SelectedTable;
                    SaleOrdersController.SaveOrUpdate(pendingSale);
                }

                frmTablesDistribution.Dispose();

                SelectedSaleOrder = null;

                Close();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void MoveToPendingSaleOrders()
        {
            try
            {
                if (SelectedSaleOrder == null) return;

                var frmComment = new FrmComment();
                frmComment.ShowDialog();

                if (!frmComment.Confirmed) return;

                SelectedSaleOrder.IsPending = true;
                SelectedSaleOrder.PendingComment = frmComment.Comment;
                SaleOrdersController.SaveOrUpdate(SelectedSaleOrder);
                LoadData();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        #endregion




    }
}
