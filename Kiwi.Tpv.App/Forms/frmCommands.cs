using System;
using System.Windows.Forms;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmCommands : MetroForm
    {
        private Command _selectedCommand;
        private int _dataGridViewCommandsLastaSelectedIndex;

        public FrmCommands()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void FrmCommands_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #region General Events

        private void btnActions_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_selectedCommand.Status)
                {
                    case CommandStatus.Pendiente:
                        _selectedCommand.Status = CommandStatus.EnProceso;
                        _selectedCommand.Station = AppGlobal.Station;
                        break;

                    case CommandStatus.EnProceso:
                        _selectedCommand.Status = CommandStatus.Finalizado;
                        CreateSale();
                        break;
                }

                CommandController.Update(_selectedCommand);
                EstablishButtonAction();
                _dataGridViewCommandsLastaSelectedIndex = 0;
                DataGridViewCommands.ClearSelection();
                DataGridViewCommands.ClearSelection();
                DataGridViewCommands.DataSource = null;
                DataGridViewCommandDetails.DataSource = null;
                LoadData();
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DataGridViewCommands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TimerRefresh.Stop();
                ShowCommandDetails();
                TimerRefresh.Start();
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

        private void FrmCommands_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerRefresh.Stop();
            TimerRefresh.Enabled = false;
        }

        #endregion

        #region Private Events

        private void LoadData()
        {
            try
            {
                TimerRefresh.Stop();

                DataGridViewCommands.DataSource =
                    CommandController.GetPendingOrInProcessWithStation(AppGlobal.Station);

                HideDatagridViewDefaultImages();

                if (DataGridViewCommands.Rows.Count > 0)
                {
                    DataGridViewCommands.ClearSelection();
                    _dataGridViewCommandsLastaSelectedIndex = DataGridViewCommands.CurrentCell.RowIndex;
                    DataGridViewCommands.Rows[_dataGridViewCommandsLastaSelectedIndex].Selected = true;
                    ShowCommandDetails();
                }
                else
                {
                    btnActions.Visible = false;
                }

                TimerRefresh.Start();

            }
            catch (Exception ex)
            {
                TimerRefresh.Start();
                ViewController.ShowError(ex.Message);
            }
        }
 
        private void ShowCommandDetails()
        {
            if (DataGridViewCommands.CurrentRow == null) return;

            _selectedCommand = (Command)DataGridViewCommands.CurrentRow.DataBoundItem;

            if (_selectedCommand == null) return;

            _dataGridViewCommandsLastaSelectedIndex = DataGridViewCommands.CurrentCell.RowIndex;
            DataGridViewCommandDetails.DataSource = _selectedCommand.Details;

            HideDatagridViewDefaultImages();

            EstablishButtonAction();
        }

        private void EstablishButtonAction()
        {
            btnActions.Visible = true;

            switch (_selectedCommand.Status)
            {
                case CommandStatus.Pendiente:
                    btnActions.Style = MetroColorStyle.Orange;
                    btnActions.Text = "En proceso";
                    break;

                case CommandStatus.EnProceso:
                    btnActions.Style = MetroColorStyle.Blue;
                    btnActions.Text = "Finalizada";
                    break;

            }
        }

        private void CreateSale()
        {
            try
            {
                var newSaleOrder = new SaleOrder
                {
                    Date = EnvironmentController.GetServerDate(),
                    Station = AppGlobal.Station,
                    Table = _selectedCommand.Table,
                };

                foreach (var commandDetail in _selectedCommand.Details)
                {
                   commandDetail.Product.Quantity = commandDetail.Quantity;
                    newSaleOrder.Add(commandDetail.Product, AppGlobal.SaleMode, AlcoholModeTypes.Default);
                }

                SaleOrdersController.SaveOrUpdate(newSaleOrder);           
                PrinterController.PrintSaleOrder(newSaleOrder);
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void HideDatagridViewDefaultImages()
        {

            foreach (var column in DataGridViewCommands.Columns)
            {
                if (column is DataGridViewImageColumn)
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
            }

            foreach (var column in DataGridViewCommandDetails.Columns)
            {
                if (column is DataGridViewImageColumn)
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
            }
        }

        #endregion

    }
}
