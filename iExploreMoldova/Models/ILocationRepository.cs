namespace iExploreMoldova.Models
{
    public interface ILocationRepository
    {
        IEnumerable<Location> alLocations { get; }
        IEnumerable<Location> topLocations { get; }
        IEnumerable<Location> highReviewLocations { get; }
        Location? GetLocationById(int id);
    }
}
