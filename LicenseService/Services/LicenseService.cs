using LicenseService.Data;

namespace LicenseService.Services
{
    public class licenseService: ILicenseService
    {

        public Models.license? checkLicense(int id)
        {
            return licenseMockDataService.Licenses.FirstOrDefault(x=>x.id==id);
        }


    }
}
