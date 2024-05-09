using CarsProject.Domain;
using CarsProject.Domain.Interfaces;
using CarsProject.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CarsProject.Infrastructure.Repositories
{
    public class CarBrandRepository : ICarBrandRepository
    {
        #region Private Fields

        private readonly ProjectDbContext _projectDbContext;

        #endregion Private Fields

        #region Public Constructors

        public CarBrandRepository(ProjectDbContext context)
        {
            _projectDbContext = context;
        }

        #endregion Public Constructors

        #region Public Methods

        public async Task<IEnumerable<BrandVehicle>> GetBrandVehiclesRepository()
        {
            var listado = await _projectDbContext.BrandVehicle.ToListAsync();
            return listado;
        }

        #endregion Public Methods
    }
}