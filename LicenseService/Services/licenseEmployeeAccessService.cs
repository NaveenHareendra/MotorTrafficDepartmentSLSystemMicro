using LicenseService.Data;

namespace LicenseService.Services
{
    public class licenseEmployeeAccessService
    {
        protected internal List<Models.license> GetLicenses()
        {
            return licenseMockDataService.Licenses;
        }

        protected internal Models.license? registerLicense(Models.license license)
        {
            licenseMockDataService.Licenses.Add(license);
            return license;
        }


        protected internal Models.license? updateLicense(Models.license license)
        {
            Models.license selectedLicense = licenseMockDataService.Licenses.FirstOrDefault(x => x.id == license.id);

            if (selectedLicense != null)
            {
                selectedLicense.id = license.id;
                selectedLicense.name = license.name;
                selectedLicense.address = license.address;
                selectedLicense.Age = license.Age;
            }

            return selectedLicense;
        }

        protected internal bool? deleteLicense(int id)
        {
            // if issued=1 only
            Models.license selectedLicense = licenseMockDataService.Licenses.FirstOrDefault(x => x.id == id);

            if (!selectedLicense.licenseIssued)
            {
                if (selectedLicense != null)
                {
                    licenseMockDataService.Licenses.Remove(selectedLicense);
                    return true;
                }

            }

            Console.WriteLine("Unable to delete, wrong ID Entered");
            return false;
        }
    }
}
