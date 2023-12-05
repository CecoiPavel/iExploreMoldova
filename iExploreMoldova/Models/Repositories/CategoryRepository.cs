using iExploreMoldova.Models.ApplicationServices;
using iExploreMoldova.Models.Entities;
using iExploreMoldova.Models.Interfaces;

namespace iExploreMoldova.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly iExploreMoldovaDbContext _context;

        public CategoryRepository(iExploreMoldovaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> allCategories => _context.Categories.OrderBy(c => c.CategoryName);
    }
}
