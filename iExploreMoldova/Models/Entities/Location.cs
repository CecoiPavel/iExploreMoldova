using Microsoft.Extensions.Hosting;

namespace iExploreMoldova.Models.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string? LocationName { get; set; }
        public string? LocationDescription { get; set; }
        public string? LocationAddress { get; set; }
        public string? LocationImageUrl { get; set; }
        public decimal PriceToVisit { get; set; }
        public bool TopLocation { get; set; }
        public bool AvailableToVisit { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
