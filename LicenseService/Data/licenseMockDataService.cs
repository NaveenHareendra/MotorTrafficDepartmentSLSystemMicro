namespace LicenseService.Data
{
    public class licenseMockDataService
    {
        public static List<Models.license> Licenses = new List<Models.license>()
        {
            new Models.license() {
                id=1, 
                name="Naveen",
                address="172/1, Niwanthidiya Pili", 
                Age=23,
                licenseIssued=false

                
                
            },

            new Models.license() {
                id=2,
                name="yashmika",
                address="Makubura",
                Age=23,
                licenseIssued=true,
                vehicleClasses=new List<string> {"A1","B1" },
                licenseIssuedDate=new DateTime(2023, 03, 31)
            },

            new Models.license() {
                id=3,
                name="kaveen",
                address="Bokundara",
                Age=30,
                licenseIssued=true,
                vehicleClasses= new List<string>{"A1","B1" },
                licenseIssuedDate=new DateTime(2023, 03, 31)
            }
        };
    }
}
