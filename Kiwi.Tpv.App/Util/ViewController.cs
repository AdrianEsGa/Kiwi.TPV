using System.Windows.Forms;
using Kiwi.Tpv.App.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App.Util
{
    public static class ViewController
    {
        private static readonly FrmPopUp FrmPopUp = new FrmPopUp() {Opacity = 0.8, ShowInTaskbar = false};

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
            var skinManager = new MetroStyleManager
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
            MetroMessageBox.Show(AppGlobal.MainForm, message,
                "Ayy calmurcio!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowError(string message)
        {
            MetroMessageBox.Show(AppGlobal.MainForm, message, "Ooouuu shit!!", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
        }
    }
}
