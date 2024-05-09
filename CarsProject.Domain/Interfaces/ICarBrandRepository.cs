namespace CarsProject.Domain.Interfaces
{
    public interface ICarBrandRepository
    {
        #region Public Methods

        Task<IEnumerable<BrandVehicle>> GetBrandVehiclesRepository();

        #endregion Public Methods
    }
}