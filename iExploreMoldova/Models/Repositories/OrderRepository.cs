using System.Collections;
using iExploreMoldova.Models.ApplicationServices;
using iExploreMoldova.Models.Entities;
using iExploreMoldova.Models.Interfaces;

namespace iExploreMoldova.Models.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly iExploreMoldovaDbContext _context;
        private readonly ICartTicket _cartTicket;

        public OrderRepository(iExploreMoldovaDbContext context, ICartTicket cartTicket)
        {
            _context = context;
            _cartTicket = cartTicket;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTimeOffset.Now;

            IEnumerable<Tickets> cartList = _cartTicket.CartList;
            order.OrderTotal = _cartTicket.GetCartTotal();

            order.OrderDetailsList = new List<OrderDetail>();

            //Adding the order with its details to DB

            foreach (var orderDetail in cartList.Select(ticket => new OrderDetail
                     {
                         Amount = ticket.Amount,
                         LocationId = ticket.Location.LocationId,
                         Price = ticket.Location.PriceToVisit
                     }))
            {
                order.OrderDetailsList.Add(orderDetail);
            }

            _context.Orders.Add(order);
            _context.SaveChanges();

        }
    }
}
