namespace iExploreMoldova.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> allCategories { get; }
    }
}
