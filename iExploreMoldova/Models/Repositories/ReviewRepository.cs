using iExploreMoldova.Models.ApplicationServices;
using iExploreMoldova.Models.Entities;
using iExploreMoldova.Models.Interfaces;

namespace iExploreMoldova.Models.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly iExploreMoldovaDbContext _context;

        public ReviewRepository(iExploreMoldovaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Review> AllReviews => _context.Reviews.OrderBy(r => r.ReviewRating);
    }
}
