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
        [HttpGet("RegisteredDealerList")]
        public IActionResult Get()
        {
            return Ok (_driverOtherServices.GetDriverOtherServices());
        }

        /// <summary>
        /// Get DriverOtherServices by DealerId
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the DriverOtherServices with the passed DealerId</returns>
        [HttpGet("SelectRegisteredDealer/{id}")]
        public IActionResult Get(int id)
        {
            return _driverOtherServices.GetDriverOtherService(id) != null ? Ok(_driverOtherServices.GetDriverOtherService(id)) : NoContent();
        }
        /// <summary>
        /// Add DriverOtherServices
        /// </summary>
        /// <param name="DriverOtherServices"></param>
        [HttpPost("AddDealer")]
        public IActionResult Post([FromBody] Models.DriverOtherService driverOtherService)
        {
            return Ok(_driverOtherServices.AddDriverOtherService(driverOtherService));
        }

        /// <summary>
        /// Update the DriverOtherServices
        /// </summary>
        /// <param name="DriverOtherServices"></param>
        /// <param name="id"></param>
        /// <return>Return the update DriverOtherServices</return>
        [HttpPut("UpdateRegisteredDealer/{id}")]
        public IActionResult Put([FromBody] Models.DriverOtherService driverOtherService)
        {
            return Ok(_driverOtherServices.UpdateDriverOtherService(driverOtherService));
        }

        /// <summary>
        /// Delete the DriverOtherServices with the passed DealerId
        /// </summary>
        /// <param name="id"></param>
        /// <return></return>>
        [HttpDelete("DeleteRegisteredDealer/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _driverOtherServices.DeleteDriverOtherService(id);
            return result.HasValue & result == true ? Ok($"DriverOtherServices wih ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the DriverOtherServices with ID:{id}.");
        }
    }
}
