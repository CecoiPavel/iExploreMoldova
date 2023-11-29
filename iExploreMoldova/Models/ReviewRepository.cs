namespace iExploreMoldova.Models
{
    public class ReviewRepository: IReviewRepository
    {
        private readonly iExploreMoldovaDbContext _context;

        public ReviewRepository(iExploreMoldovaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Review> AllReviews => _context.Reviews.OrderBy(r => r.ReviewRating);
    }
}
