using System;
using Kiwi.Tpv.App.Util;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmReportViewer : MetroForm
    {
        public FrmReportViewer()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            reportViewer.ProcessingMode = ProcessingMode.Local;
            BringToFront();
        }

        public void ViewReport()
        {
            Show();
            reportViewer.RefreshReport();
            BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}