using bus_project.Models;
using Microsoft.EntityFrameworkCore;

namespace bus_project.Data
{
    public class YourDbContext : DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
        {
        }

        public DbSet<TransportCompanyModel.TransportCompany> TransportCompanies { get; set; }
        public DbSet<BusTypeModel> BusTypes { get; set; }
        public DbSet<VehicleModel.Vehicle> VehicleTypes { get; set; }
        public DbSet<StopModel.Stop> StopsAmmount { get; set; }
        public DbSet<RouteModel> RoutesList { get; set; }
        public DbSet<PointModel.Point> PointsList { get; set; }
        public DbSet<DriverModel.Driver> DriversList { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransportCompanyModel.TransportCompany>().ToTable("transport_company");
            modelBuilder.Entity<BusTypeModel>().ToTable("model");
            modelBuilder.Entity<VehicleModel.Vehicle>().ToTable("vehicle");
            modelBuilder.Entity<StopModel.Stop>().ToTable("stop");
            modelBuilder.Entity<RouteModel>().ToTable("route");
            modelBuilder.Entity<PointModel.Point>().ToTable("point");
            modelBuilder.Entity<DriverModel.Driver>().ToTable("driver");
        }
    }
}