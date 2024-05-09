using CarsProject.Domain;
using CarsProject.Infrastructure.Context;
using CarsProject.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class CarBrandRepositoryTests
    {
        #region Public Methods

        [Fact]
        public async Task GetBrandVehiclesRepository_ReturnsAllBrandVehicles()
        {
            // Arrange
            var dbContext = GetDbContext();
            var repo = new CarBrandRepository(dbContext);

            // Add some test data
            dbContext.BrandVehicle.Add(new BrandVehicle { Id = 1, NameBrand = "Toyota" });
            dbContext.BrandVehicle.Add(new BrandVehicle { Id = 2, NameBrand = "Mazda" });
            await dbContext.SaveChangesAsync();

            // Act
            var result = await repo.GetBrandVehiclesRepository();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Contains(result, bv => bv.NameBrand == "Toyota");
            Assert.Contains(result, bv => bv.NameBrand == "Mazda");
        }

        #endregion Public Methods

        #region Private Methods

        private ProjectDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ProjectDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryCarBrandDatabase")
                .Options;
            var dbContext = new ProjectDbContext(options);
            return dbContext;
        }

        #endregion Private Methods
    }
}
