using iExploreMoldova.Models.Interfaces;

namespace iExploreMoldova.ViewModel
{
    public class TicketsListViewModel
    {
        public TicketsListViewModel(ICartTicket cartTicket, decimal ticketsListTotal)
        {
            CartTicket = cartTicket;
            TicketsListTotal = ticketsListTotal;
        }

        public ICartTicket CartTicket { get; }
        public decimal TicketsListTotal { get; }
    }
}
