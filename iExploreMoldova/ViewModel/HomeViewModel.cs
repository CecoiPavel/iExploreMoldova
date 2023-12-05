using iExploreMoldova.Models.Entities;

namespace iExploreMoldova.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Location> TopLocations { get; }

        public HomeViewModel(IEnumerable<Location> availableToVisit)
        {
            TopLocations = availableToVisit;
        }
    }
}
