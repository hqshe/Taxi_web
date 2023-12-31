using Taxi_site.Models;
using Microsoft.EntityFrameworkCore;
namespace Taxi_site.Data
{
    public class Taxi_siteDbContext : DbContext
    {
        public Taxi_siteDbContext(DbContextOptions<Taxi_siteDbContext> options):base(options)
        {
                
        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<PassengerBonus> PassengerBonuses { get; set; }
        public DbSet<DriverBonus> DriverBonuses { get; set; }
        public DbSet<DriverDeal> DriverDeals { get; set; }
        public DbSet<PassengerDeal> PassengerDeals { get; set; }
        public DbSet<PassengerPunishment> PassengerPunishments { get; set; }
        public DbSet<DriverPunishment> DriverPunishments { get; set; }
        public DbSet<RegisteredDriver> RegisteredDrivers { get; set; }
        public DbSet<RegisteredPassenger> RegisteredPassengers { get; set; }
        public DbSet<Order> Orders { get; set; }    

    }
}
