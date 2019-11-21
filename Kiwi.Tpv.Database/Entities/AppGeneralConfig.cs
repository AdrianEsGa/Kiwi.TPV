namespace Kiwi.Tpv.Database.Entities
{
    public class AppGeneralConfig
    {
        public string AdminPassword { get; set; }
        public int ProductButtonsDimension { get; set; }
        public int EmployeeButtonsDimension { get; set; }
        public int TableButtonsDimension { get; set; }
        public string BackgroundImage { get; set; }
        public bool SystemJoke { get; set; }
        public int JokeInit { get; set; }
        public int JokeEnd { get; set; }
        public int JokeInterval { get; set; }
        public bool ShowJokeReport { get; set; }
        public Station ServerStation { get; set; }
        public string DbBackupFilePath { get; set; }

    }
}