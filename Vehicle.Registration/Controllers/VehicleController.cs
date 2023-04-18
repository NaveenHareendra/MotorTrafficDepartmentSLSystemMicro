using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Vehicle.Registration.Data;
using Vehicle.Registration.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vehicle.Registration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService ?? throw new ArgumentNullException(nameof(vehicleService));
        }

        /// Get all Vehicle
        [HttpGet("getallVehicle")]
        public IActionResult Get()
        {
            return Ok(_vehicleService.GetVehicles());
        }

        /// Get Vehicle by ID
        [HttpGet("getVehicle/{id}")]
        public IActionResult Get(int id)
        {
            return _vehicleService.GetVehicle(id) != null ? Ok(_vehicleService.GetVehicle(id)) : NoContent();
        }

        /// Add Vehicle
        [HttpPost("addVehicle")]
        public IActionResult Post([FromBody] Models.Vehicle vehicle)
        {
            return Ok(_vehicleService.AddVehicle(vehicle));
        }

        /// Update the Vehicle
        [HttpPut("updateVehicle/{id}")]
        public IActionResult Put([FromBody] Models.Vehicle vehicle)
        {
            return Ok(_vehicleService.UpdateVehicle(vehicle));
        }

        /// Delete the Vehicle with the passed ID
        [HttpDelete("deleteVehicle/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _vehicleService.DeleteVehicle(id);

            return result.HasValue & result == true ? Ok($"Vehicle with ID:{id} deleted successfully.")
                : BadRequest($"Unable to delete the Vehicle with ID:{id}.");
        }
    }
}
