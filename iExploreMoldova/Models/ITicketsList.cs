namespace iExploreMoldova.Models
{
    public interface ITicketsList
    {
        void AddToTicketsList(Location  location);
        int RemoveFromTicketsList(Location location);
        IEnumerable<Ticket> GetTicketList();
        void ClearTicketList();
        decimal GetTicketListTotal();
        IEnumerable<Ticket> TicketList { get; set; }
    }
}
