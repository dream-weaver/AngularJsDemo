using Airlines.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Airlines.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=AirlineDBContext")
        {
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Flight>()
             .HasMany<City>(c => c.Cities)
             .WithRequired(c => c.Flight)
             .HasForeignKey<int>(c => c.FlightID);
        }
    }
}
