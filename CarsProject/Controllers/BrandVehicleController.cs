using CarsProject.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarsProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandVehicleController : ControllerBase
    {
        #region Private Fields

        private readonly ICarBrandService _service;

        #endregion Private Fields

        #region Public Constructors

        public BrandVehicleController(ICarBrandService service)
        {
            _service = service;
        }

        #endregion Public Constructors

        #region Public Methods

        [HttpGet(Name = "GetBrands")]
        public async Task<IActionResult> GetBrands()
        {
            var response = await _service.GetBrandVehiclesService();
            return Ok(response);
        }

        #endregion Public Methods
    }
}