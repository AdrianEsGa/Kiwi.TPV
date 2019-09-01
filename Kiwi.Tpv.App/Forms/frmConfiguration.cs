using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Kiwi.Tpv.App.Properties;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.App.Util.Configurations;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using Kiwi.Tpv.Database.Repositories;
using MetroFramework.Forms;
using Settings = Kiwi.Tpv.App.Util.Configurations.Settings;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmConfiguration : MetroForm
    {
        public FrmConfiguration()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
            tabConfig.SelectedTab = tabConfig.TabPages[0];
        }

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveConfiguracion();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = Resources.ImageFilters
            };

            if (file.ShowDialog() == DialogResult.OK)
                TxtBackImagePath.Text = file.FileName;
        }

        private void btnOpenBox_Click(object sender, EventArgs e)
        {
            CashDrawerController.Open();
        }

        private void btnJokeImage_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = Resources.ImageFilters
            };

            if (file.ShowDialog() == DialogResult.OK)
                txtJokeImage.Text = file.FileName;
        }

        private void btnLoadJokeImage_Click(object sender, EventArgs e)
        {
            var imag = Image.FromFile(txtJokeImage.Text);
            SystemRepository.Insert(Common.ImageToBytes(imag));
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
        }

        private void btnSelectCompanyAppLogo_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = Resources.ImageFilters
            };

            if (file.ShowDialog() == DialogResult.OK)
                picBoxAppLogo.Image = Image.FromFile(file.FileName);
        }

        private void btnSelectCompanyReportsLogo_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = Resources.ImageFilters
            };

            if (file.ShowDialog() == DialogResult.OK)
                picBoxReportsLogo.Image = Image.FromFile(file.FileName);
        }

        private void btnRemoveCompanyReportsLogo_Click(object sender, EventArgs e)
        {
            picBoxReportsLogo.Image = null;
        }

        private void btnRemoveCompanyAppLogo_Click(object sender, EventArgs e)
        {
            picBoxAppLogo.Image = null;
        }

        private void cbActualStation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectCompanyLocalImage_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = Resources.ImageFilters
            };

            if (file.ShowDialog() == DialogResult.OK)
                picBoxReportsLocalImage.Image = Image.FromFile(file.FileName);
        }

        private void btnRemoveCompanyLocalImage_Click(object sender, EventArgs e)
        {
            picBoxReportsLocalImage.Image = null;
        }
        #endregion

        #region Methods

        private void LoadConfiguration()
        {
            try
            {
                txtAdminPassword.Text = AppGlobal.AppGeneralConfig.AdminPassword;
                txtProductButtonsDimension.Text = AppGlobal.AppGeneralConfig.ProductButtonsDimension.ToString();
                txtEmployeeButtonsDimension.Text = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension.ToString();
                txtTableButtonsDimensions.Text = AppGlobal.AppGeneralConfig.TableButtonsDimension.ToString();
                TxtBackImagePath.Text = AppGlobal.AppGeneralConfig.BackgroundImage;
                chkShowJokeReport.Checked = AppGlobal.AppGeneralConfig.ShowJokeReport;

                TxtCompanyName.Text = AppGlobal.Company.Name;
                txtCompanyCif.Text = AppGlobal.Company.Cif;
                chkCombinationControl.Checked = AppGlobal.Company.CombinationControl;

                DataGridViewStations.DataSource = StationController.GetAll();
                DataGridViewStations.ClearSelection();
                cbActualStation.DataSource = StationController.GetAll();
                cbActualStation.SelectedIndex = cbActualStation.FindStringExact(AppGlobal.Station.ToString());

                cbPrinter.DataSource = RawPrinterHelper.GetPrinters();
                cbPrinter.SelectedIndex = cbPrinter.FindStringExact(AppGlobal.Station.PrintterComPort);
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }

            try
            {
                picBoxAppLogo.Image = Common.BytesToImage(AppGlobal.Company.AppLogo);
                picBoxReportsLogo.Image = Common.BytesToImage(AppGlobal.Company.ReportsLogo);
                picBoxReportsLocalImage.Image = Common.BytesToImage(AppGlobal.Company.LocalImage);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void SaveConfiguracion()
        {
            try
            {
                AppGlobal.AppGeneralConfig.AdminPassword = txtAdminPassword.Text.Trim();
                AppGlobal.AppGeneralConfig.ProductButtonsDimension =
                    Convert.ToInt16(txtProductButtonsDimension.Text.Trim());
                AppGlobal.AppGeneralConfig.EmployeeButtonsDimension =
                    Convert.ToInt16(txtEmployeeButtonsDimension.Text.Trim());
                AppGlobal.AppGeneralConfig.TableButtonsDimension =
                    Convert.ToInt16(txtTableButtonsDimensions.Text.Trim());
                AppGlobal.AppGeneralConfig.BackgroundImage = TxtBackImagePath.Text.Trim();
                AppGlobal.AppGeneralConfig.ShowJokeReport = chkShowJokeReport.Checked;
                AppCommonController.SaveOrUpdate(AppGlobal.AppGeneralConfig);


                var station = (Station) cbActualStation.SelectedItem;
                Settings.StationCode = station.Code.ToString();
                GlobalConfigurationRepository.Save();

                if (cbPrinter.SelectedItem != null)
                    station.PrintterComPort = cbPrinter.SelectedItem.ToString();

                StationController.Update(station);

                AppGlobal.Company.Name = TxtCompanyName.Text.Trim();
                AppGlobal.Company.Cif = txtCompanyCif.Text.Trim();
                AppGlobal.Company.CombinationControl = chkCombinationControl.Checked;
                AppGlobal.Company.AppLogo = Common.ImageToBytes(picBoxAppLogo.Image);
                AppGlobal.Company.ReportsLogo = Common.ImageToBytes(picBoxReportsLogo.Image);
                AppGlobal.Company.LocalImage = Common.ImageToBytes(picBoxReportsLocalImage.Image);
                CompanyController.SaveOrUpdate(AppGlobal.Company);

                ViewController.ShowAsterisk(@"Configuración guardada satisfactoriamente.");

            }
            catch (Exception ex)
            {
                ViewController.ShowError( ex.Message);
            }

        }

        private void btnTestPrintter_Click(object sender, EventArgs e)
        {
            PrinterController.PrintSale(new Sale());
        }

        #endregion



    }
}
