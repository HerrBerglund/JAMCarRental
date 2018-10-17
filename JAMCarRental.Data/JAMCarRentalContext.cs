using JAMCarRental.Domain;
using Microsoft.EntityFrameworkCore;

namespace JAMCarRental.Data
{
    public class JamCarRentalContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        //public static readonly LoggerFactory JamCarRentalLoggerFactory
        //    = new LoggerFactory(new[]
        //    {
        //        new ConsoleLoggerProvider((category, level)
        //            => category == DbLoggerCategory.Database.Command.Name
        //               && level == LogLevel.Information, true)
        //    });

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                  .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = JamCarRentalDB; Trusted_Connection = True;");
            //    .EnableSensitiveDataLogging()
            //    .UseLoggerFactory(JamCarRentalLoggerFactory)
        }
    }
}