using System;
using System.Collections.Generic;
using System.ComponentModel;
using Kiwi.Tpv.App.Properties;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmConfirmPay : MetroForm
    {
       
        private SaleOrder _allSaleOrder;
        private SaleOrder _individualSaleOrder;
        private BackgroundWorker _worker;
        private bool _printTicket;
        private readonly Employee _employee;
        private bool _confirmationSuccess;
        private PayMode _payMode = PayMode.All;

        private SaleOrder FinalSaleOrder
        {
            get { return _payMode == PayMode.Individual ? _individualSaleOrder : _allSaleOrder; }
        }

        public FrmConfirmPay(Employee employee, SaleOrder saleOrder)
        {
            InitializeComponent();
            ViewController.SetSkin(this);     
            _employee = employee;
            _allSaleOrder = saleOrder;
            SaleOrdersController.SaveOrUpdate(_allSaleOrder);
        }

        private void FrmConfirmPay_Load(object sender, EventArgs e)
        {
            Initialize();
            _worker = new BackgroundWorker();
            _worker.DoWork += DoWork;
            _worker.RunWorkerCompleted += RunWorkerCompleted;
        }

        #region Events

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!_confirmationSuccess) return;

            if (_payMode == PayMode.Individual)
            {
                FinalizeProductSelection();
            }
            else
            {
                AppGlobal.SaleOrder = new SaleOrder();
                Close();
            }
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            ConfirmPay();
        }

        private void btnDisccount_Click(object sender, EventArgs e)
        {
            Disscount();
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            Invite();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AppGlobal.SaleOrder = SaleOrdersController.GetById(_allSaleOrder.Id);
            Close();
        }

        private void btnConfirmCash_Click(object sender, EventArgs e)
        {
            FinalSaleOrder.PayType = PayType.Cash;
            _printTicket = false;
            ViewController.ShowPopUpWithSpinner();
            if (!_worker.IsBusy)
            _worker.RunWorkerAsync();
        }

        private void btnConfirmCreditCard_Click(object sender, EventArgs e)
        {
            FinalSaleOrder.PayType = PayType.CreditCard;
            _printTicket = false;
            ViewController.ShowPopUpWithSpinner();
            if(!_worker.IsBusy)
            _worker.RunWorkerAsync();
        }

        private void btnConfirmCashTicket_Click(object sender, EventArgs e)
        {
            FinalSaleOrder.PayType = PayType.Cash;
            _printTicket = true;
            ViewController.ShowPopUpWithSpinner();
            if (!_worker.IsBusy)
            _worker.RunWorkerAsync();
        }

        private void btnConfirmCreditCardTicket_Click(object sender, EventArgs e)
        {
            FinalSaleOrder.PayType = PayType.CreditCard;
            _printTicket = true;
            ViewController.ShowPopUpWithSpinner();
            if(!_worker.IsBusy)
            _worker.RunWorkerAsync();
        }

        private void DataGridViewSaleOrderDetails_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var selectedSaleOrderDetail = (SaleOrderDetail) DataGridViewSaleOrderDetails.CurrentRow?.DataBoundItem;

            if (selectedSaleOrderDetail == null) return;

            SelectProduct(selectedSaleOrderDetail);

        }

        private void btnRemoveProductSelection_Click(object sender, EventArgs e)
        {
            FinalizeProductSelection();
        }
        #endregion

        #region Methods

        private void SelectProduct(SaleOrderDetail saleOrderDetail)
        {
            if (_payMode == PayMode.All && _allSaleOrder.Details.Count == 1 && saleOrderDetail.Quantity == 1)
            {
                return;
            }

            if (_payMode == PayMode.All)
            {
                _individualSaleOrder = _allSaleOrder.Copy();
                _payMode = PayMode.Individual;
                PanelProductsToPay.Visible = true;
            }

            _allSaleOrder.RemoveOneUnit(saleOrderDetail);

            var selectionSaleOrderDetail = saleOrderDetail.Copy();

            _individualSaleOrder.AddOneUnit(selectionSaleOrderDetail);

            RefreshDataGridViews();
            RefreshTotal();
        }

        private void RefreshDataGridViews()
        {

            DataGridViewSaleOrderDetails.DataSource = null;
            DataGridViewSaleOrderDetails.DataSource = _allSaleOrder.Details;

            if (_payMode == PayMode.All) return;

            DataGridViewSelectionSaleOrderDetails.DataSource = null;
            DataGridViewSelectionSaleOrderDetails.DataSource = _individualSaleOrder.Details;
        }

        private void RefreshTotal()
        { 
            txtTotalToPay.Text = FinalSaleOrder.Total.ToString("F") + Resources.Euro;
        }

        private void Initialize()
        {
            try
            {
                DataGridViewSaleOrderDetails.DataSource = _allSaleOrder.Details;
                DataGridViewSaleOrderDetails.ClearSelection();
                txtTotalToPay.Text = _allSaleOrder.Total.ToString("F") + Resources.Euro;
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void ConfirmPay()
        {
            try
            {
                _confirmationSuccess = false;

                _allSaleOrder.Employee = _employee;

                if (_payMode == PayMode.Individual)
                    _individualSaleOrder.Employee = _employee;

                var paySaleOrder = _payMode == PayMode.Individual ? _individualSaleOrder : _allSaleOrder;
                var pendingSaleOrder = _payMode == PayMode.Individual ? _allSaleOrder : null;
     
                var confirmedSale = AppGlobal.SalesController.MakeSale(paySaleOrder, pendingSaleOrder, _printTicket);

                if (AppGlobal.SalesController.PrintTicket)               
                    PrinterController.PrintSale(confirmedSale);
                
                if (AppGlobal.SalesController.OpenCashDrawer)
                    CashDrawerController.Open();

                _confirmationSuccess = true;
            }
            catch (Exception ex)
            {
                _confirmationSuccess = false;
                ViewController.ShowError(ex.Message);
            }
        }

        private void Disscount()
        {
            try
            {
                if (FinalSaleOrder.Total < 1) return;
                FinalSaleOrder.Disscount = FinalSaleOrder.Disscount + 1;
                txtTotalToPay.Text = FinalSaleOrder.Total.ToString("F") + Resources.Euro;
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void Invite()
        {
            try
            {
                FinalSaleOrder.Disscount = FinalSaleOrder.Total;
                FinalSaleOrder.PayType = PayType.Cash;

                ViewController.ShowPopUpWithSpinner();
                if (!_worker.IsBusy)
                _worker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void FinalizeProductSelection()
        {
            PanelProductsToPay.Visible = false;
            _payMode = PayMode.All;
            _allSaleOrder = SaleOrdersController.GetById(_allSaleOrder.Id);
            RefreshDataGridViews();
            RefreshTotal();
        }

        #endregion


        private enum PayMode
        {
            All = 1,
            Individual = 2
        }

    }
}