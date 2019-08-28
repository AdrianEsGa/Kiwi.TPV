using System;
using System.ComponentModel;
using System.Windows.Forms;
using Kiwi.Tpv.App.Properties;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmConfirmPay : MetroForm
    {
        private BackgroundWorker _worker;
        public bool OperationFinalized;

        public FrmConfirmPay()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
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
            ViewController.HidePopUp();
            Close();
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
            OperationFinalized = false;
            Close();
        }

        private void btnConfirmCash_Click(object sender, EventArgs e)
        {
            AppGlobal.Sale.PayType = PayType.Cash;
            AppGlobal.Sale.Ticket = false;
            ViewController.ShowPopUpWithSpinner();
            if (!_worker.IsBusy)
            _worker.RunWorkerAsync();
        }

        private void btnConfirmCreditCard_Click(object sender, EventArgs e)
        {
            AppGlobal.Sale.PayType = PayType.CreditCard;
            AppGlobal.Sale.Ticket = false;
            ViewController.ShowPopUpWithSpinner();
            if(!_worker.IsBusy)
            _worker.RunWorkerAsync();
        }

        private void btnConfirmCashTicket_Click(object sender, EventArgs e)
        {
            AppGlobal.Sale.PayType = PayType.Cash;
            AppGlobal.Sale.Ticket = true;
            ViewController.ShowPopUpWithSpinner();
            if (!_worker.IsBusy)
            _worker.RunWorkerAsync();
        }

        private void btnConfirmCreditCardTicket_Click(object sender, EventArgs e)
        {
            AppGlobal.Sale.PayType = PayType.CreditCard;
            AppGlobal.Sale.Ticket = true;
            ViewController.ShowPopUpWithSpinner();
            if(!_worker.IsBusy)
            _worker.RunWorkerAsync();
        }

        #endregion

        #region Methods

        private void Initialize()
        {
            try
            {
                AppGlobal.Sale.Total = AppGlobal.Sale.TotalPriceDetails();
                AppGlobal.Sale.Disscount = 0;
                txtTotalToPay.Text = AppGlobal.Sale.Total.ToString("F") + Resources.Euro;
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
                var isJoke = false;

                AppGlobal.Sale.Paid = true;

                if (IsPosibleToMakeJokeSale())
                {
                    if (AppGlobal.JokeSystemCounter == AppGlobal.AppGeneralConfig.JokeInterval)
                        isJoke = true;
                    else AppGlobal.JokeSystemCounter++;
                }

                if (isJoke)
                {
                    SalesController.SaveOrUpdateJoke(AppGlobal.Sale);
                    AppGlobal.JokeSystemCounter = 1;
                }
                else
                {
                    SalesController.SaveOrUpdate(AppGlobal.Sale);
                }

                if (AppGlobal.Sale.Ticket && !isJoke)
                {
                    PrinterController.PrintSale(AppGlobal.Sale);
                }

                if (Math.Abs(AppGlobal.Sale.Total) > 0 && AppGlobal.Sale.PayType == PayType.Cash)
                    CashDrawerController.Open();

                OperationFinalized = true;
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void Disscount()
        {
            try
            {
                if (AppGlobal.Sale.Total < 1) return;
                AppGlobal.Sale.Total -= 1;
                AppGlobal.Sale.Disscount = AppGlobal.Sale.Disscount + 1;
                txtTotalToPay.Text = AppGlobal.Sale.Total + Resources.Euro;
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
                AppGlobal.Sale.Total = 0;
                AppGlobal.Sale.Disscount = AppGlobal.Sale.TotalPriceDetails();
                AppGlobal.Sale.PayType = PayType.Cash;
                AppGlobal.Sale.Ticket = false;
                ViewController.ShowPopUpWithSpinner();
                if (!_worker.IsBusy)
                _worker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private bool IsPosibleToMakeJokeSale()
        {
            return AppGlobal.Sale.Id == 0 && AppGlobal.JokeSystemActive && AppGlobal.Sale.PayType == PayType.Cash &&
                   AppGlobal.Sale.Total > 0;
        }
        #endregion

    }
}