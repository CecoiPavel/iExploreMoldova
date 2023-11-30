namespace iExploreMoldova.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public virtual Location Location { get; set; } 
        public int Amount { get; set; }
        public string? TicketsListId { get; set; }
    }
}
