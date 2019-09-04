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

                DataGridViewCommands.ClearSelection();
                DataGridViewCommands.Rows[_dataGridViewCommandsLastaSelectedIndex].Selected = true;
                TimerRefresh.Start();

            }
            catch (Exception ex)
            {
                TimerRefresh.Start();
                ViewController.ShowError(ex.Message);
            }
        }

        #endregion


    }
}
