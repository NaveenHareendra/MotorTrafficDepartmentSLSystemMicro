

namespace LicenseService.Services
{
    public interface ILicenseService
    {
        Models.license? checkLicense(int id);

        List<Models.licenseServicesList> viewListServices();

        float calculatePriceTotal(int[] serviceId);

    }
}
