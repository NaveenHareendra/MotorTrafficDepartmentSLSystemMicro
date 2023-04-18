using LicenseService.Data;

namespace LicenseService.Services
{
    public class licenseEmployeeAccessService
    {
        public List<Models.license> GetLicenses()
        {
            return licenseMockDataService.Licenses;
        }

        protected internal Models.license? registerLicense(Models.license license)
        {
            licenseMockDataService.Licenses.Add(license);

            if((license.id != 0) &&(license.Age>16) &&(license.address != null) &&(license.name != null) &&(license.licenseIssued != null))
            {

                return license;
            }
            return null;
        }


        protected internal Models.license? updateLicense(Models.license license)
        {
            Models.license selectedLicense = licenseMockDataService.Licenses.FirstOrDefault(x => x.id == license.id);
            
            if((license.id != 0) && (license.name != null) && (license.address != null) && (license.Age > 16) && (selectedLicense.licenseIssued!=null))
            {
                if (selectedLicense != null)
                {
                    selectedLicense.id = license.id;
                    selectedLicense.name = license.name;
                    selectedLicense.address = license.address;
                    selectedLicense.Age = license.Age;
                    selectedLicense.licenseIssued = license.licenseIssued;
                }
                return selectedLicense;
            }

            return null;


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
