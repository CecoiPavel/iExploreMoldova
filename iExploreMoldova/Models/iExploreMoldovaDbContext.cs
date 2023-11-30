using System.Configuration;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace iExploreMoldova.Models
{
    public class iExploreMoldovaDbContext: DbContext
    {

        public iExploreMoldovaDbContext(DbContextOptions<iExploreMoldovaDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Ticket> Tickets { get; set; }


    }
}
