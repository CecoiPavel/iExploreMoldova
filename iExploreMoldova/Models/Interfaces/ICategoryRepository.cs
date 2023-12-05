using iExploreMoldova.Models.Entities;

namespace iExploreMoldova.Models.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> allCategories { get; }
    }
}
