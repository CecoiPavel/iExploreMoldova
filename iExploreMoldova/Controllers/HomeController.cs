using iExploreMoldova.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using iExploreMoldova.ViewModel;
using iExploreMoldova.Models.Interfaces;
using iExploreMoldova.Models.Repositories;

namespace iExploreMoldova.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILocationRepository _locationRepository;

        public HomeController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public IActionResult Index()
        {
            var topLocations = _locationRepository.topLocations;
            var homeVieModel = new HomeViewModel(topLocations);
            return View(homeVieModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}