namespace iExploreMoldova.Models
{
    public interface IReviewRepository
    {
        public IEnumerable<Review> AllReviews { get; }
    }
}
