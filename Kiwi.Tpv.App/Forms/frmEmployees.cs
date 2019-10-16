using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Kiwi.Tpv.App.Properties;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;


namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmEmployees : MetroForm
    {
        private Employee _selectedEmployee;

        public FrmEmployees()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            LoadData();
            tabEmployees.SelectedTab = tabEmployees.TabPages[0];        
            TxtName.Validated += TxtName_Validated;
        }

        #region Events

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataGridViewEmployees.DataSource = EmployeeController.GetAll();
            DataGridViewEmployees.ClearSelection();

            foreach (var column in DataGridViewEmployees.Columns)
            {
                if (column is DataGridViewImageColumn)
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
            }

            tabEmployees.SelectedTab = tabEmployees.TabPages[1];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewEmployees.CurrentRow == null) return;
            _selectedEmployee = (Employee)DataGridViewEmployees.CurrentRow.DataBoundItem;

            if (_selectedEmployee == null) return;

            BindingToControls();

            tabEmployees.SelectedTab = tabEmployees.TabPages[0];
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = Resources.ImageFilters
            };

            if (file.ShowDialog() != DialogResult.OK) return;
            pictureBoxImage.BackgroundImage = Image.FromFile(file.FileName);
            pictureBoxImage.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImage.Text = String.Empty;
        }

        private void TxtName_Validated(object sender, EventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            _selectedEmployee = new Employee();
            BindingToControls();
        }

        private void Save()
        {
            try
            {
                if (!ValidateData())
                {
                    ViewController.ShowWarning(@"Revisa los datos y vuelve a intentarlo.");                
                    return;
                }

                BindingFromControls();
                _selectedEmployee = EmployeeController.SaveOrUpdate(_selectedEmployee);
                BindingToControls();

                ViewController.ShowAsterisk( @"Empleado guardado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                ViewController.ShowError( ex.Message);
            }
        }

        private void Remove()
        {
            if (_selectedEmployee == null || _selectedEmployee.Id == 0)
            {
                ViewController.ShowWarning(@"¿Que estas intentando eliminar? Lo siento, pero no puedes.");
                return;
            }

            try
            {
                EmployeeController.Remove(_selectedEmployee);
                New();
                ViewController.ShowAsterisk(@"Empleado eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }

        private void New()
        {
            _selectedEmployee = new Employee();
            pictureBoxImage.Image = null;
            BindingToControls();
        }

        private void BindingToControls()
        {
            TxtId.Text = _selectedEmployee.Id.ToString();
            TxtName.Text = _selectedEmployee.Name;
            chkActive.Checked = _selectedEmployee.Active;

            pictureBoxImage.BackgroundImage = null;

            if (_selectedEmployee.Image != null)
            {
                pictureBoxImage.BackgroundImage = Common.BytesToImage(_selectedEmployee.Image);
                pictureBoxImage.BackgroundImageLayout = ImageLayout.Center;
                pictureBoxImage.Text = String.Empty;
            }
        }

        private void BindingFromControls()
        {
            _selectedEmployee.Name = TxtName.Text;

            if (pictureBoxImage.BackgroundImage != null)
            {
                _selectedEmployee.Image = Common.ImageToBytes(pictureBoxImage.BackgroundImage);
            }

            _selectedEmployee.Active = chkActive.Checked;
        }

        private bool ValidateData()
        {
            return !string.IsNullOrEmpty(TxtName.Text);
        }

        #endregion

        private void TxtName_Click(object sender, EventArgs e)
        {
            ViewController.ShowWindowKeyboard();
        }

        private void FrmEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewController.HideWindowKeyboard();
        }
    }
}