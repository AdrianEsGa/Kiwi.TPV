using Kiwi.Tpv.Database.Entities;
using MetroFramework.Forms;

namespace Kiwi.Tpv.App
{
    public static class AppGlobal
    {
        public static MetroForm MainForm;
        public static AppGeneralConfig AppGeneralConfig;
        public static Company Company;
        public static Station Station;
        public static Sale Sale;
        public static BarTable Table;

        public static bool JokeSystemActive;
        public static int JokeSystemCounter = 1;

        public static SaleMode SaleMode = SaleMode.Day;
    }
}