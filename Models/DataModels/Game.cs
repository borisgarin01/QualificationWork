namespace FinalQualificationWork.Models.DataModels
{
    public class Game
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public float AverageMark { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string Localization { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
    }
}
