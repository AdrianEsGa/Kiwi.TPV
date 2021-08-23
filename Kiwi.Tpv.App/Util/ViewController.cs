using System;
using System.Diagnostics;
using System.Windows.Forms;
using Kiwi.Tpv.App.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Drawing.Html;
using MetroFramework.Forms;
using NLog;

namespace Kiwi.Tpv.App.Util
{
    public static class ViewController
    {
        private static Process _windowKeyboard;
        private static readonly FrmPopUp FrmPopUp = new FrmPopUp() {Opacity = 0.8, ShowInTaskbar = false};
        public static MetroStyleManager SkinManager;

        public static void ShowPopUp()
        {
            FrmPopUp.spinnerProgress.Visible = false;
            FrmPopUp.Visible = true;
        }

        public static void ShowPopUpWithSpinner()
        {
            FrmPopUp.spinnerProgress.Visible = true;
            FrmPopUp.Visible = true;
        }

        public static void HidePopUp()
        {
            FrmPopUp.Visible = false;
            AppGlobal.MainForm.BringToFront();
        }

        public static void SetSkin(MetroForm form)
        {
            SkinManager = new MetroStyleManager
            {
                Owner = form,
                Style = MetroColorStyle.Red
            };
        }

        public static void ShowAsterisk(string message)
        {
            MetroMessageBox.Show(AppGlobal.MainForm, message, "Ooouuu yeah!!",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void ShowWarning(string message)
        {
            MetroMessageBox.Show(AppGlobal.MainForm, message, "Ayy calmurcio!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowError(Exception exception)
        {
            NLog.Instance.Error(exception);
            MetroMessageBox.Show(AppGlobal.MainForm, exception.Message, "Ooouuu shit!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWindowKeyboard()
        {
            try
            {
                // _windowKeyboard =  Process.Start("osk.exe");
                _windowKeyboard = Process.Start(@"C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe");
            }
            catch (Exception)
            {
                //ignored
            }
        }

        public static void HideWindowKeyboard()
        {
            try
            {
                _windowKeyboard.Kill();
                _windowKeyboard.Close();
                _windowKeyboard.Dispose();
                _windowKeyboard = null;
            }
            catch (Exception)
            {
                //ignored
            }
        }

        public static void ShowToolTip(string title, string message, Form parent, int x, int y, int delay)
        {
            var toolTip = new ToolTip
            {
                ToolTipTitle = title,
                ToolTipIcon = ToolTipIcon.Info,
                UseFading = true,
                UseAnimation = true,
                IsBalloon = true,
                ShowAlways = true,
                //AutoPopDelay = 5000,
                //InitialDelay = 1000,
                //ReshowDelay = 500
            };

            toolTip.Show(message, parent, x, y, delay);
        }
    }
}
