using iExploreMoldova.Models.Entities;

namespace iExploreMoldova.Models.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
