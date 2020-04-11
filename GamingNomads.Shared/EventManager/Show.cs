namespace GamingNomads.Shared.EventManager
{
    public class Show
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public bool IsTentative { get; set; }
        public string URL { get; set; }
        public string DatesText { get; set; }
        public bool Games { get; set; }
        public bool Artemis { get; set; }
        public bool LaserTag { get; set; }
    }
}
