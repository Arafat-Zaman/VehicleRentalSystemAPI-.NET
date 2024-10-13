using Microsoft.EntityFrameworkCore;
using VehicleRentalSystemAPI.Models;

namespace VehicleRentalSystemAPI.Data
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure inheritance for Vehicle types
            modelBuilder.Entity<Vehicle>().HasDiscriminator<string>("VehicleType")
                .HasValue<Car>("Car")
                .HasValue<Bike>("Bike")
                .HasValue<Truck>("Truck");
        }
    }
}
