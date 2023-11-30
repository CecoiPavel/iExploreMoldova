using iExploreMoldova.Models;
using iExploreMoldova.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace iExploreMoldova.Controllers
{
    public class TicketsListController : Controller
    {
        private readonly ILocationRepository _locationRepository;
        private readonly ITicketsList _ticketsList;

        public TicketsListController(ILocationRepository locationRepository, ITicketsList ticketsList)
        {
            _locationRepository = locationRepository;
            _ticketsList = ticketsList;
        }

        public IActionResult Index()
        {
            var items = _ticketsList.GetTicketList();
            _ticketsList.TicketList = items;

            var ticketsListViewModel = new TicketsListViewModel(_ticketsList, 
                _ticketsList.GetTicketListTotal());

            return View(ticketsListViewModel);
        }

        //If selected Location is not null, we will call the RemoveFromTicketsList method passing in the selectedLocation
        public RedirectToActionResult AddToTicketsList(int locationId)
        {
            var selectedLocation = _locationRepository.allLocations.FirstOrDefault(l => l.LocationId == locationId);

            if (selectedLocation != null)
            {
                _ticketsList.AddToTicketsList(selectedLocation);
            }
            
            //Redirecting to the Index after the TicketsList
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromTicketsList(int locationId)
        {
            var selectedLocation = _locationRepository.allLocations.FirstOrDefault(l => l.LocationId == locationId);

            if (selectedLocation != null)
            {
                _ticketsList.RemoveFromTicketsList(selectedLocation);
            }

            return RedirectToAction("Index");
        }
    }
}
