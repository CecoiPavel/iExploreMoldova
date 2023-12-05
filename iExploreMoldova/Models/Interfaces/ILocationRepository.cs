using iExploreMoldova.Models.Entities;

namespace iExploreMoldova.Models.Interfaces
{
    public interface ILocationRepository
    {
        IEnumerable<Location> allLocations { get; }
        IEnumerable<Location> topLocations { get; }
        IEnumerable<Location> highReviewLocations { get; }
        Location? GetLocationById(int id);
    }
}
