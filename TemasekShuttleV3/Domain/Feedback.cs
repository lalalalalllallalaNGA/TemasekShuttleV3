namespace TemasekShuttleV3.Domain
{
    public class Feedback : BaseDomainModel
    {
        public int FeedbackRating { get; set; }
        public string? FeedbackContent { get; set; }
        public int BookingId { get; set; } //FK
    }
}
