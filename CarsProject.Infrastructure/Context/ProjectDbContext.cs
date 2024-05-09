using CarsProject.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarsProject.Infrastructure.Context
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }


        #region Public Properties

        public DbSet<BrandVehicle> BrandVehicle { get; set; }

        #endregion Public Properties

        #region Protected Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BrandVehicle>().HasData(
                new BrandVehicle { Id = 1, NameBrand = "Toyota" },
                new BrandVehicle { Id = 2, NameBrand = "Mazda" },
                new BrandVehicle { Id = 3, NameBrand = "JAC" },
                new BrandVehicle { Id = 4, NameBrand = "Mitsubishi" },
                new BrandVehicle { Id = 5, NameBrand = "Datsun" }
            );
        }

        #endregion Protected Methods
    }
}