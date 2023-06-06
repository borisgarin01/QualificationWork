namespace FinalQualification.Models.DataModels
{
    public class CriticTextReview
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public Game Game { get; set; }
        public long GameId { get; set; }
        public Critic Critic { get; set; }
        public long CriticId { get; set; }
    }
}