using iExploreMoldova.Models;
using iExploreMoldova.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace iExploreMoldova.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationRepository _locationRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IReviewRepository _reviewRepository;

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

        public IActionResult Details(int id)
        {
            var location = _locationRepository.GetLocationById(id);
            if (location == null)
                return NotFound();
            return View(location);
        }
    }
}
