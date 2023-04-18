namespace com.driverService.Data
{
    public static class DriverMockDataService
    {
        public static List<Models.Driver> Drivers = new List<Models.Driver>()
        {
            new Models.Driver { Id = 1, Name = "Kamal", Gender = "Male", NIC = "200014523425", DOB = "12/03/2000", BloodGroup = "B+", Address = "123, Main St, Colombo", Age = 20 },
            new Models.Driver { Id = 2, Name = "Sunil", Gender = "Male", NIC = "199914523425", DOB = "05/09/1999", BloodGroup = "O+", Address = "456, Second St, Malabe", Age = 22 },
            new Models.Driver { Id = 3, Name = "Saman", Gender = "Male", NIC = "200014223425", DOB = "14/02/2000", BloodGroup = "AB+", Address = "789, Third St, Kanduwela", Age = 21 },
            new Models.Driver { Id = 4, Name = "Nimal", Gender = "Male", NIC = "199814523425", DOB = "07/09/1999", BloodGroup = "A-", Address = "321, Fourth st, Gampaha", Age = 23 },
            new Models.Driver { Id = 5, Name = "Amal", Gender = "Male", NIC = "199914325425", DOB = "08/05/1999", BloodGroup = "O-", Address = "654, Fifth St, Colombo 03", Age = 19 }
        };
    }
}
