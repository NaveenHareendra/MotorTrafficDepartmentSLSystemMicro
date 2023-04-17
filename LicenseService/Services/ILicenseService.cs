using LicenseService.Data;

namespace LicenseService.Services
{
    public interface ILicenseService
    {
        Models.license? checkLicense(int id);

    }
}
