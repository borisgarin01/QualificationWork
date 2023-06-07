namespace FinalQualificationWork.Models.DataModels
{
    public class Trailer
    {
        public long Id { get; set; }
        public string Url { get; set; }
        public Game Game { get; set; }
        public long GameId { get; set; }
    }
}