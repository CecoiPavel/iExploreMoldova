namespace iExploreMoldova.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int LocationId { get; set; }
        public string? ReviewUserName { get; set; }
        public int ReviewRating { get; set; }
        public string? ReviewComment { get; set; }
        public virtual Location Location { get; set; }
    }
}
