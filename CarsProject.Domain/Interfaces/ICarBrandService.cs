namespace CarsProject.Domain.Interfaces
{
    public interface ICarBrandService
    {
        #region Public Methods

        Task<IEnumerable<BrandVehicle>> GetBrandVehiclesService();

        #endregion Public Methods
    }
}