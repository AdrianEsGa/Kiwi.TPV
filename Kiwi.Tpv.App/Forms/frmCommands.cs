using System;
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
        private int _dataGridViewCommandsLastaSelectedIndex = 0;

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

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void TimerRefresh_Tick(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void DataGridViewCommands_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (DataGridViewCommands.CurrentRow == null) return;

            TimerRefresh.Stop();

            _selectedCommand = (Command)DataGridViewCommands.CurrentRow.DataBoundItem;

            if (_selectedCommand == null) return;

            _dataGridViewCommandsLastaSelectedIndex = DataGridViewCommands.CurrentCell.RowIndex;
            DataGridViewCommandDetails.DataSource = _selectedCommand.Details;

            EstablishButtonAction();

            TimerRefresh.Start();

        }

        #endregion

        #region Private Events

        private void EstablishButtonAction()
        {
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

                case CommandStatus.Finalizado:
                    btnActions.Style = MetroColorStyle.Green;
                    btnActions.Text = "Servida";
                    break;
            }
        }

        private void LoadData()
        {
            try
            {
                TimerRefresh.Stop();

                DataGridViewCommands.DataSource =
                    CommandController.GetPendingAndInProcessOrFinalizedWithStation(AppGlobal.Station);

                if (DataGridViewCommands.Rows.Count > 0)
                {
                    DataGridViewCommands.ClearSelection();
                    DataGridViewCommands.Rows[_dataGridViewCommandsLastaSelectedIndex].Selected = true;
                }

                TimerRefresh.Start();

            }
            catch (Exception ex)
            {
                TimerRefresh.Start();
                ViewController.ShowError(ex.Message);
            }
        }


        #endregion

        private void btnActions_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_selectedCommand.Status)
                {
                    case CommandStatus.Pendiente:
                        _selectedCommand.Status = CommandStatus.EnProceso;
                        break;

                    case CommandStatus.EnProceso:
                        _selectedCommand.Status = CommandStatus.Finalizado;
                        break;

                    case CommandStatus.Finalizado:
                        _selectedCommand.Status = CommandStatus.Servido;
                        break;
                }

                CommandController.Update(_selectedCommand);
                EstablishButtonAction();
                _dataGridViewCommandsLastaSelectedIndex = 0;
                DataGridViewCommands.ClearSelection();
                DataGridViewCommands.ClearSelection();
                DataGridViewCommands.DataSource = null;
                DataGridViewCommandDetails.DataSource = null;
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }
    }
}
