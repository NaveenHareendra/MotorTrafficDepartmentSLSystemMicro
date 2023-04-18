using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.DriverOtherServices.Data;
using Sliit.MTIT.DriverOtherServices.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.DriverOtherServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverOtherServicesController : ControllerBase
    {
        private readonly IDriverOtherServices _driverOtherServices;

        public DriverOtherServicesController(IDriverOtherServices driverOtherServices)
        {
            _driverOtherServices = driverOtherServices ?? throw new ArgumentNullException(nameof(driverOtherServices));
        }

        /// <summary>
        /// Get all DriverOtherServices
        /// </summary>
        /// <returns>return the list of DriverOtherServices</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok (_driverOtherServices.GetDriverOtherServices());
        }

        /// <summary>
        /// Get DriverOtherServices by DealerId
        /// </summary>
        /// <param name="DealerId"></param>
        /// <returns>Return the DriverOtherServices with the passed DealerId</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int DealerId)
        {
            return _driverOtherServices.GetDriverOtherService(DealerId) != null ? Ok(_driverOtherServices.GetDriverOtherService(DealerId)) : NoContent();
        }
        /// <summary>
        /// Add DriverOtherServices
        /// </summary>
        /// <param name="DriverOtherServices"></param>
        [HttpPost]
        public IActionResult Post([FromBody] Models.DriverOtherService driverOtherService)
        {
            return Ok(_driverOtherServices.AddDriverOtherService(driverOtherService));
        }

        /// <summary>
        /// Update the DriverOtherServices
        /// </summary>
        /// <param name="DriverOtherServices"></param>
        /// <return>Return the update DriverOtherServices</return>
        [HttpPut]
        public IActionResult Put([FromBody] Models.DriverOtherService driverOtherService)
        {
            return Ok(_driverOtherServices.UpdateDriverOtherService(driverOtherService));
        }

        /// <summary>
        /// Delete the DriverOtherServices with the passed DealerId
        /// </summary>
        /// <param name="DealerId"></param>
        /// <return></return>>
        [HttpDelete("{id}")]
        public IActionResult Delete(int DealerId)
        {
            var result = _driverOtherServices.DeleteDriverOtherService(DealerId);
            return result.HasValue & result == true ? Ok($"DriverOtherServices wih ID:{DealerId} got deleted successfukky.")
                : BadRequest($"Unable to delete the DriverOtherServices with ID:{DealerId}.");
        }
    }
}
