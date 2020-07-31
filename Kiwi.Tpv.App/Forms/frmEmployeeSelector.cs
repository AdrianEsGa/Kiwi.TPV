using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Forms
{
    public partial class FrmEmployeeSelector : MetroForm
    {
        private List<Employee> _activeEmployees;
        public Employee SelectedEmployee;

        public FrmEmployeeSelector()
        {
            InitializeComponent();
            ViewController.SetSkin(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEmployeeSelector_Load(object sender, EventArgs e)
        {
            PaintEmployees();
        }

        private void PaintEmployees()
        {
            try
            {
                flowLayoutPanelEmployees.Controls.Clear();

                _activeEmployees = EmployeeController.GetAllActive();

                foreach (var employee in _activeEmployees)
                {

                    if (employee.Image != null)
                    {
                        PaintEmployeeImageButtons(employee);
                    }
                    else
                    {
                        PaintEmployeeButtons(employee);
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void PaintEmployeeImageButtons(Employee employee)
        {
            var buttonSize = 100;
            var btn = new MetroButton
            {
                Width = buttonSize,
                Height = buttonSize,
                Tag = employee,
                BackgroundImage = Common.BytesToImage(employee.Image),
                BackgroundImageLayout = ImageLayout.Stretch
            };
            btn.Click += ButtonEmployee_Click;
            flowLayoutPanelEmployees.Controls.Add(btn);
        }

        private void PaintEmployeeButtons(Employee employee)
        {
            var buttonSize = 100;
            var btn = new Button
            {
                Width = buttonSize,
                Height = buttonSize,
                Text = employee.Name,
                Tag = employee,
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular)
            };


            btn.Click += ButtonEmployee_Click;
            flowLayoutPanelEmployees.Controls.Add(btn);
        }

        private void ButtonEmployee_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            SelectedEmployee = (Employee)btn.Tag;
            Close();
        }
    }
}
