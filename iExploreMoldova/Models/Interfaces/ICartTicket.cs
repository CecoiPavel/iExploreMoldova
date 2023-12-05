using iExploreMoldova.Models.Entities;

namespace iExploreMoldova.Models.Interfaces
{
    public interface ICartTicket
    {
        void AddToCart(Location location);
        int RemoveFromCart(Location location);
        IEnumerable<Entities.Tickets> GetCart();
        void ClearCart();
        decimal GetCartTotal();
        IEnumerable<Entities.Tickets> CartList { get; set; }
    }
}
