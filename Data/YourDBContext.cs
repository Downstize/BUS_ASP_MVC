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
        public DbSet<BusTypeModel.BusType> BusTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransportCompanyModel.TransportCompany>().ToTable("transport_company");
            modelBuilder.Entity<BusTypeModel.BusType>().ToTable("model");
        }
    }
}