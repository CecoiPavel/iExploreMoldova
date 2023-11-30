using iExploreMoldova.Models;

namespace iExploreMoldova.ViewModel
{
    public class TicketsListViewModel
    {
        public TicketsListViewModel(ITicketsList ticketsList, decimal ticketsListTotal)
        {
            TicketsList = ticketsList;
            TicketsListTotal = ticketsListTotal;
        }

        public ITicketsList TicketsList { get; }
        public decimal TicketsListTotal { get; }
    }
}
