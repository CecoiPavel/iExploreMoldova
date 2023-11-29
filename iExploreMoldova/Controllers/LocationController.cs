using iExploreMoldova.Models;
using iExploreMoldova.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace iExploreMoldova.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationRepository _locationRepository;
        private readonly ICategoryRepository _categoryRepository;

        public LocationController(ILocationRepository locationRepository, ICategoryRepository categoryRepository)
        {
            _locationRepository = locationRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            LocationsListViewModel locationsListViewModel = new LocationsListViewModel
            (_locationRepository.alLocations, "Rural locations");
            return View(locationsListViewModel);
        }
    }
}
