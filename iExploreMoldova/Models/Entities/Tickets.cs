using System.ComponentModel.DataAnnotations;

namespace iExploreMoldova.Models.Entities
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }
        public virtual Location Location { get; set; }
        public int Amount { get; set; }
        public string? TicketsListId { get; set; }
    }
}
