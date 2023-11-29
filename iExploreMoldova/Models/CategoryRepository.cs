namespace iExploreMoldova.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly iExploreMoldovaDbContext _context;

        public CategoryRepository(iExploreMoldovaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> allCategories => _context.Categories.OrderBy(c=>c.CategoryName);
    }
}
