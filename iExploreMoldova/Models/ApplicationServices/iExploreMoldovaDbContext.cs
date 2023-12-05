using iExploreMoldova.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace iExploreMoldova.Models.ApplicationServices
{
    public class iExploreMoldovaDbContext : DbContext
    {

        public iExploreMoldovaDbContext(DbContextOptions<iExploreMoldovaDbContext> options)
            : base(options)
        {

        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
 

    }
}
