namespace iExploreMoldova.Models.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public string? CategoryIconUrl { get; set; }
        public virtual ICollection<Location> Locations { get; set; }

    }
}
