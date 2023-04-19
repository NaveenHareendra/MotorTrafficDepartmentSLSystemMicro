
using LicenseService.Data;

namespace LicenseService.Services
{
    public class customerService: ILicenseService
    {

        public Models.license? checkLicense(int id)
        {
            return licenseMockDataService.Licenses.FirstOrDefault(x=>x.id==id);
        }

        public List<Models.licenseServicesList> viewListServices()
        {
            return licenseServiceListMockData.serviceLists;
        }

        public float calculatePriceTotal(int[] serviceId)
        {
            float total=0;

            for(int currentId=0; currentId<serviceId.Length; currentId++)
            {
                Models.licenseServicesList selectedLicense = licenseServiceListMockData.serviceLists.FirstOrDefault(x => x.id == serviceId[currentId]);

                if (selectedLicense == null)
                {
                    currentId=serviceId.Length;
                    return 0;

                }
                else
                {
                    total += selectedLicense.servicePrice;

                }

            }
            return total;

        }
    }
}
