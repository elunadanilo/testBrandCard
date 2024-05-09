using CarsProject.Domain;
using CarsProject.Domain.Interfaces;

namespace CarsProject.Infrastructure.Services
{
    public class CarBrandService : ICarBrandService
    {
        #region Private Fields

        private readonly ICarBrandRepository _carBrandRepository;

        #endregion Private Fields

        #region Public Constructors

        public CarBrandService(ICarBrandRepository carBrandRepository)
        {
            _carBrandRepository = carBrandRepository;
        }

        #endregion Public Constructors

        #region Public Methods

        public async Task<IEnumerable<BrandVehicle>> GetBrandVehiclesService()
        {
            return await _carBrandRepository.GetBrandVehiclesRepository();
        }

        #endregion Public Methods
    }
}