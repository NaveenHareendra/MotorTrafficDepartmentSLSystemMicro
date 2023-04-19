using LicenseService.Data;
using LicenseService.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicenseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenseServiceController : ControllerBase
    {
        private readonly ILicenseService licenseViewService;
        private licenseEmployeeAccessService licenseMaintain;
        
        public LicenseServiceController(ILicenseService viewLicenseServiceConstruct, licenseEmployeeAccessService maintainLicenseConstruct)
        {
            licenseViewService = viewLicenseServiceConstruct ?? throw new ArgumentNullException(nameof(licenseViewService));
            licenseMaintain = maintainLicenseConstruct ?? throw new ArgumentNullException(nameof(maintainLicenseConstruct));

        }
        // GET: api/<LicenseServiceController>
        // GET api/<LicenseServiceController>/5
        [HttpGet("getAllLicenses")]
        public IActionResult getAllLicenses()
        {
            Console.WriteLine("Licensing checks "+ licenseMaintain.GetLicenses());
            return Ok(licenseMaintain.GetLicenses());
        }

        [HttpGet("getLicenseid/{id}")]
        public IActionResult Get(int id)
        {

            return licenseViewService.checkLicense(id) != null? Ok(licenseViewService.checkLicense(id)) :BadRequest("No Such License");
        }
        // POST api/<LicenseServiceController>
          
        [HttpPost("registerLicense")]
        public IActionResult Post([FromBody] Models.license license)
        {
            var checkExecution = licenseMaintain.registerLicense(license);

            if (checkExecution == null)
            {
                return BadRequest("Opertion failed, please check the inputs");
            }
            else
            {
                return Ok("Request Successful");
            }

        }

        
        // PUT api/<LicenseServiceController>/5
        [HttpPut("updateLicense/{id}")]
        public IActionResult Put([FromBody] Models.license license)
        {
            var checkExecution = licenseMaintain.updateLicense(license);

            if (checkExecution!=null)
            {
                return Ok("Updated Success");
            }
            return BadRequest("Cannot update into empty fields.");    
        }

        // DELETE api/<LicenseServiceController>/5
        [HttpDelete("deleteLicense/{id}")]
        public IActionResult Delete(int id)
        {
            var result = licenseMaintain.deleteLicense(id);

            return result.HasValue & result == true ? Ok($"license with id:{id} got deleted successfully.")
            : BadRequest($"Unable to delete license with id:{id}");

        }

        [HttpGet("licenseServicesList")]
        public IActionResult GetLicenseServicesLists()
        {
            return Ok(licenseViewService.viewListServices());
        }

        [HttpPost("purchaseServices")]
        public IActionResult purchaseServicesLicenses([FromBody] int[] listOfServiceIds)
        {
            float resultOfCalculation = licenseViewService.calculatePriceTotal(listOfServiceIds);

            if (resultOfCalculation == 0)
            {
                return BadRequest("Something is wrong");
            }
            else
            {
                return Ok("Total Price Of purchased Services: " + resultOfCalculation);
            }

        }
    }
}
