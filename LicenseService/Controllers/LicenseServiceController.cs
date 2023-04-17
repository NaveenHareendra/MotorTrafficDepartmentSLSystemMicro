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
        public LicenseServiceController(ILicenseService licenseViewService, licenseEmployeeAccessService maintainLicenseConstruct)
        {
            licenseViewService = licenseViewService ?? throw new ArgumentNullException(nameof(licenseViewService));
            licenseMaintain = maintainLicenseConstruct ?? throw new ArgumentNullException(nameof(maintainLicenseConstruct));

        }
        // GET: api/<LicenseServiceController>
        // GET api/<LicenseServiceController>/5
        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("Licensing checks "+ licenseMaintain.GetLicenses());
            return Ok(licenseMaintain.GetLicenses());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return licenseViewService.checkLicense(id) != null? Ok(licenseMaintain.GetLicenses()):NoContent();
        }
        // POST api/<LicenseServiceController>
          [HttpPost]
        public IActionResult Post([FromBody] Models.license license)
        {
            //return Ok(_licenseService.AddLicense(license));

            return Ok(licenseMaintain.registerLicense(license));
        }

        
        // PUT api/<LicenseServiceController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Models.license license)
        {
            return Ok(licenseMaintain.updateLicense(license));
        }

        // DELETE api/<LicenseServiceController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = licenseMaintain.deleteLicense(id);

            return result.HasValue & result == true ? Ok($"license with id:{id} got deleted successfully.")
            : BadRequest($"Unable to delete license with id:{id}");

        }
    }
}
