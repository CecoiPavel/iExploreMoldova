using Microsoft.EntityFrameworkCore;

namespace iExploreMoldova.Models
{
    public class LocationRepository: ILocationRepository
    {
       private readonly iExploreMoldovaDbContext _context;

       public LocationRepository(iExploreMoldovaDbContext context)
       {
           _context = context;
       }

       public IEnumerable<Location> alLocations
       {
           get
           {
               return _context.Locations.Include(l => l.Category);
           }
       }

       public IEnumerable<Location> topLocations
       {
           get
           {
               return _context.Locations.Include(l => l.Category).Where(t=>t.TopLocation);
           } 
       }
       public Location? GetLocationById(int id)
       {
           return _context.Locations.FirstOrDefault(l => l.LocationId == id);
        }
    }
}
