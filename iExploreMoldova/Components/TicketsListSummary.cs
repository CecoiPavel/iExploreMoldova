using iExploreMoldova.Models.Interfaces;
using iExploreMoldova.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace iExploreMoldova.Components
{
    public class TicketsListSummary: ViewComponent
    {
        private readonly ICartTicket _cartTicket;

        public TicketsListSummary(ICartTicket cartTicket)
        {
            _cartTicket = cartTicket;
        }

        public IViewComponentResult Invoke()
        {
            var items = _cartTicket.GetCart();
            _cartTicket.CartList = items;

            var ticketsListViewModel = new TicketsListViewModel(_cartTicket,
                _cartTicket.GetCartTotal());

            return View(ticketsListViewModel);
        }
    }
}
