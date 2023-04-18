using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using com.driverService.Data;
using com.driverService.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace com.driverService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService??throw new ArgumentNullException(nameof(driverService));
        }
        /// <summary>
        /// Get all drivers
        /// </summary>
        /// <returns>return the list of drivers</returns>
        // GET: api/<DriverController>
        [HttpGet("getAllDrivers")]
        public IActionResult Get()
        {
            return Ok(_driverService.GetDrivers());
        }

        /// <summary>
        /// Get driver by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the driver with the passed ID</returns>
        // GET api/<DriverController>/5
        [HttpGet("getDriver/{id}")]
        public IActionResult Get(int id)
        {
            return _driverService.GetDriver(id) != null ? Ok(_driverService.GetDriver(id)) : NoContent();
        }

        /// <summary>
        /// Add Driver
        /// </summary>
        /// <param name="driver"></param>
        /// <returns>Return the added driver</returns>
        // POST api/<DriverController>
        [HttpPost("addDriver")]
        public IActionResult Post([FromBody] Models.Driver driver)
        {
            return Ok(_driverService.AddDriver(driver));
        }

        /// <summary>
        /// Update the driver
        /// </summary>
        /// <param name="id"></param>
        /// <param name="driver"></param>
        /// <returns>Return the updated driver</returns>
        // PUT api/<DriverController>/5
        //[HttpPut("{id}")]
        [HttpPut("updateDriver/{id}")]
        public IActionResult Put([FromBody] Models.Driver driver)
        {
            return Ok(_driverService.UpdateDriver(driver));
        }

        /// <summary>
        /// Delete the driver with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE api/<DriverController>/5
        [HttpDelete("deleteDriver/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _driverService.DeleteDriver(id);

            return result.HasValue & result == true ? Ok($"driver with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the driver with ID:{id}.");
        }
    }
}
