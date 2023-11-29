namespace iExploreMoldova.Models.ViewModel
{
    public class LocationsListViewModel
    {
        public IEnumerable<Location> Locations { get;}
        public string? CurrentCategory { get;}

        public LocationsListViewModel(IEnumerable<Location> locations, string? currentCategory)
        {
            Locations = locations;
            CurrentCategory = currentCategory;
        }

    }
}
