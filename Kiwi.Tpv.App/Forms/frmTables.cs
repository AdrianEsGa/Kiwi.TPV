using System;
using System.Windows.Forms;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;


namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmTables : MetroForm
    {
        private BarTable _selectedTable;

        public FrmTables()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void FrmTables_Load(object sender, EventArgs e)
        {
            _selectedTable = new BarTable();
            BindingToControls();
            tabTables.SelectedTab = tabTables.TabPages[0];
            CbBarTableType.Items.Add(BarTable.BarTableType.Barra);
            CbBarTableType.Items.Add(BarTable.BarTableType.Mesa);
        }

        #region Events

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewTables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewTables.CurrentRow == null) return;
            _selectedTable = (BarTable) DataGridViewTables.CurrentRow.DataBoundItem;

            if (_selectedTable == null) return;

            BindingToControls();

            tabTables.SelectedTab = tabTables.TabPages[0];
        }

        private void btnDistribucion_Click(object sender, EventArgs e)
        {
            var frmTablesDistribution = new FrmTablesDistribution(FrmTablesDistribution.WindowMode.Administration);
            frmTablesDistribution.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        private void TxtTableName_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void TxtTableName_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        private void FrmTables_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        #endregion

        #region Methods 

        private void Save()
        {
            try
            {
                if (!ValidateData())
                {
                    ViewController.ShowWarning("Revisa los datos y vuelve a intentarlo.");
                    return;
                }

                BindingFromControls();
                _selectedTable = BarTablesController.SaveOrUpdate(_selectedTable);
                BindingToControls();

                ViewController.ShowAsterisk( @"Mesa guardada satisfactoriamente.");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }
        }

        private void Remove()
        {
            if (_selectedTable == null || _selectedTable.Id == 0)
            {
                ViewController.ShowWarning(@"¿Que estas intentando eliminar? Lo siento, pero no puedes.");
                return;
            }

            try
            {
                BarTablesController.Remove(_selectedTable);
                NewData();

                ViewController.ShowAsterisk(@"Mesa eliminada satisfactoriamente.");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }
        }

        private void Search()
        {
            try
            {
                DataGridViewTables.DataSource = BarTablesController.GetAll();
                DataGridViewTables.ClearSelection();
                tabTables.SelectedTab = tabTables.TabPages[1];
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex);
            }
        }

        private void NewData()
        {
            _selectedTable = new BarTable();
            BindingToControls();
        }

        private void BindingToControls()
        {
            TxtTableId.Text = _selectedTable.Id.ToString();
            txtCode.Text = _selectedTable.Code.ToString();
            TxtTableName.Text = _selectedTable.Name;
            chkActive.Checked = _selectedTable.Active;
            CbBarTableType.SelectedItem = _selectedTable.Type;
        }

        private void BindingFromControls()
        {
            _selectedTable.Name = TxtTableName.Text;
            _selectedTable.Code = Convert.ToInt32(txtCode.Text);
            _selectedTable.Active = chkActive.Checked;
            _selectedTable.Type = (BarTable.BarTableType)CbBarTableType.SelectedItem;
        }

        private bool ValidateData()
        {
            return !string.IsNullOrEmpty(txtCode.Text);
        }


        #endregion


    }
}