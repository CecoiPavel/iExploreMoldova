using iExploreMoldova.Models.Interfaces;
using iExploreMoldova.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace iExploreMoldova.Controllers
{
    public class CartTicketController : Controller
    {
        private readonly ILocationRepository _locationRepository;
        private readonly ICartTicket _cartTicket;

        public CartTicketController(ILocationRepository locationRepository, ICartTicket cartTicket)
        {
            _locationRepository = locationRepository;
            _cartTicket = cartTicket;
        }

        public IActionResult Index()
        {
            var items = _cartTicket.GetCart();
            _cartTicket.CartList = items;

            var ticketsListViewModel = new TicketsListViewModel(_cartTicket, 
                _cartTicket.GetCartTotal());

            return View(ticketsListViewModel);
        }

        //If selected Location is not null, we will call the RemoveFromCart method passing in the selectedLocation
        public RedirectToActionResult AddToTicketsList(int locationId)
        {
            var selectedLocation = _locationRepository.allLocations.FirstOrDefault(l => l.LocationId == locationId);

            if (selectedLocation != null)
            {
                _cartTicket.AddToCart(selectedLocation);
            }
            
            //Redirecting to the Index after the CartTicketRepository
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromTicketsList(int locationId)
        {
            var selectedLocation = _locationRepository.allLocations.FirstOrDefault(l => l.LocationId == locationId);

            if (selectedLocation != null)
            {
                _cartTicket.RemoveFromCart(selectedLocation);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearTicketCart()
        {
            _cartTicket.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
