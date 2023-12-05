using iExploreMoldova.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace iExploreMoldova.Controllers
{
    public class OrderController : Controller
    {
       private readonly IOrderRepository _orderRepository;
       private readonly ICartTicket _cartTicket;

       public OrderController(IOrderRepository orderRepository, ICartTicket cartTicket)
        {
            _orderRepository = orderRepository;
            _cartTicket = cartTicket;
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
