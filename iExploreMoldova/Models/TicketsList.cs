using Microsoft.EntityFrameworkCore;

namespace iExploreMoldova.Models
{
    public class TicketsList: ITicketsList
    {
        private readonly iExploreMoldovaDbContext _db;

        public string? TicketsListId { get; set; }

        public IEnumerable<Ticket> TicketList { get; set; } = default!;

        private TicketsList(iExploreMoldovaDbContext db)
        {
            _db = db;
        }

            //Storing between different requests information about the user by using SESSION

         // Returning a fully created brand new TicketList by passing in the Services Collection 

        public static TicketsList GetTicketsList(IServiceProvider service)
        {
            //Trying to have access to Session service through DI by calling as a parameter the IServices Collection
            ISession? session = service.GetRequiredService<IHttpContextAccessor>
                ()?.HttpContext.Session;
            iExploreMoldovaDbContext context = service.GetService<iExploreMoldovaDbContext>
                () ?? throw new Exception("Error accessing the Tickets list");

             //When user visits the site this code is going to heck if there is already an TicketsListId available for this user
             //if not, then we will create a new GUID and restore that values as the TicketsListId.
            string ticketsId = session?.GetString("TicketsListId") ?? Guid.NewGuid().ToString();

            session?.SetString("TicketsListId", ticketsId);


            //When user is returning, we will bw able to find the existing TicketsListId = and we will use that
            //Returning the Tickets List passing in the DB_Context and TicketsListId from the SESSION
            return new TicketsList(context) { TicketsListId = ticketsId };
        }

        public void AddToTicketsList(Location location)
        {
            var ticket = _db.Tickets.SingleOrDefault(t =>
                t.Location.LocationId == location.LocationId && t.TicketsListId == TicketsListId);
            if (ticket == null)
            {
                ticket = new Ticket
                {
                    TicketsListId = TicketsListId,
                    Location = location,
                    Amount = 1
                };
                _db.Tickets.Add(ticket);
            }
            else
            {
                ticket.Amount++;
            }

            _db.SaveChanges();
        }

        public int RemoveFromTicketsList(Location location)
        {
            var ticket = _db.Tickets.SingleOrDefault(
                t => t.Location.LocationId == location.LocationId && t.TicketsListId == TicketsListId);

            var sessionAmount = 0;

            if (ticket != null)
            {
                if (ticket.Amount > 1)
                {
                    ticket.Amount--;
                    sessionAmount = ticket.Amount;
                }
                else
                {
                    _db.Tickets.Remove(ticket);
                }
            }

            _db.SaveChanges();

            return sessionAmount;
        }

        public IEnumerable<Ticket> GetTicketList()
        {
            return TicketList ??=
                _db.Tickets
                    .Where(t=>t.TicketsListId == TicketsListId)
                    .Include(t=>t.Location)
                    .ToList();
        }

        public void ClearTicketList()
        {
            var ticketsList = _db
                .Tickets
                .Where(l => l.TicketsListId == TicketsListId);

            _db.Tickets.RemoveRange(ticketsList);

            _db.SaveChanges();
        }

        public decimal GetTicketListTotal()
        {
            var total = _db.Tickets
                .Where(t=>t.TicketsListId == TicketsListId)
                .Select(t=>t.Location.PriceToVisit * t.Amount)
                .Sum();
            return total;
        }

    }
}
