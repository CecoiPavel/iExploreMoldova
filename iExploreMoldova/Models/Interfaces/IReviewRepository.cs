using iExploreMoldova.Models.Entities;

namespace iExploreMoldova.Models.Interfaces
{
    public interface IReviewRepository
    {
        public IEnumerable<Review> AllReviews { get; }
    }
}
