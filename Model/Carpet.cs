namespace Dsd601CarpetCalcAsp.Model
{
    public class Carpet
    {
        public Single RoomWidth { get; set; } = 1;
        public Single RoomLength { get; set; } = 1;
        public Single RoomArea { get; set; } = 1;
        public bool HasInstallation { get; set; }
        public bool HasUnderlay { get; set; }
        public int CarpetType { get; set; }
        public Single InstallationCost { get; set; } = 20;
        public Single UnderlayCost { get; set; } = 20;
        public Single FinalCost { get; set; }
        public string Results { get; set; } = "No results";
    }
}
