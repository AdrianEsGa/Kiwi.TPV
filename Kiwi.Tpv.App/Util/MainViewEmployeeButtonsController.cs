using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Kiwi.Tpv.Database.Controllers;
using Kiwi.Tpv.Database.Entities;
using MetroFramework.Controls;

namespace Kiwi.Tpv.App.Util
{
    public static class MainViewEmployeeButtonsController
    {
        private static List<Employee> _employees = new List<Employee>();

        public static void PaintEmployees()
        {
            try
            {

                FrmMain.Instance.flowLayoutPanelEmployees.Controls.Clear();

                InitializeFlowLayouts();

                _employees = EmployeeController.GetAllActive();

                foreach (var employee in _employees)
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

        private static void InitializeFlowLayouts()
        {
            FrmMain.Instance.flowLayoutPanelEmployees.AutoScroll = false;
            FrmMain.Instance.flowLayoutPanelEmployees.AutoSize = true;
            FrmMain.Instance.flowLayoutPanelEmployees.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private static void PaintEmployeeImageButtons(Employee employee)
        {
            var btn = new MetroButton
            {
                Width = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                Tag = employee,
                BackgroundImage = Common.BytesToImage(employee.Image),
                BackgroundImageLayout = ImageLayout.Stretch
            };
            btn.Click += FrmMain.Instance.ButtonEmployee_Click;
            FrmMain.Instance.flowLayoutPanelEmployees.Controls.Add(btn);
        }

        private static void PaintEmployeeButtons(Employee employee)
        {
            var btn = new Button
            {
                Width = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                Height = AppGlobal.AppGeneralConfig.EmployeeButtonsDimension,
                Text = employee.Name,
                Tag = employee,
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular),
            };

            btn.Click += FrmMain.Instance.ButtonEmployee_Click;
            FrmMain.Instance.flowLayoutPanelEmployees.Controls.Add(btn);
        }
    }
}
