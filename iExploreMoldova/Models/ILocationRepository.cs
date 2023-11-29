namespace iExploreMoldova.Models
{
    public interface ILocationRepository
    {
        IEnumerable<Location> alLocations { get; }
        IEnumerable<Location> topLocations { get; }
        Location? GetLocationById(int id);
    }
}
