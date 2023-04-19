namespace LicenseService.Data
{
    public class licenseServiceListMockData
    {
        public static List<Models.licenseServicesList> serviceLists = new List<Models.licenseServicesList>()
        {
            new Models.licenseServicesList() {
                id=1,
                serviceName="Request 'L' Large 11x9 Size Board",
                servicePrice=1000
            },

            new Models.licenseServicesList() {
                id=2,
                serviceName="Request 'L' small 5x4 Size Board",
                servicePrice=500
            },

            new Models.licenseServicesList() {
                id=3,
                serviceName="Add new vehicle class to existing license",
                servicePrice=2500
            },
        };
    }
}
