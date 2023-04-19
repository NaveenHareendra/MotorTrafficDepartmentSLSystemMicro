using com.driverService.Data;
using com.driverService.Models;

namespace com.driverService.Services
{
    public class DriverService:IDriverService
    {
            public List<Models.Driver> GetDrivers() 
            {
                return DriverMockDataService.Drivers;
            }
            public Models.Driver? GetDriver(int Id)
            {
                return DriverMockDataService.Drivers.FirstOrDefault(x => x.Id == Id);
            }
            public Models.Driver? AddDriver(Models.Driver driver)
            {
                DriverMockDataService.Drivers.Add(driver);
                return driver;
            }

            public Models.Driver? UpdateDriver(Models.Driver driver)
            {
                Models.Driver selectedDriver = DriverMockDataService.Drivers.FirstOrDefault(x => x.Id == driver.Id);
                if (selectedDriver != null)
                {
                    selectedDriver.Name = driver.Name;
                    selectedDriver.Gender = driver.Gender;
                    selectedDriver.NIC = driver.NIC;
                    selectedDriver.DOB = driver.DOB;
                    selectedDriver.BloodGroup = driver.BloodGroup;
                    selectedDriver.Address = driver.Address;
                    selectedDriver.Age = driver.Age;
                }

                return selectedDriver;
            }

            public bool? DeleteDriver(int Id)
            {
                Models.Driver selectedDriver = DriverMockDataService.Drivers.FirstOrDefault(x => x.Id == Id);
                if (selectedDriver != null)
                {
                    DriverMockDataService.Drivers.Remove(selectedDriver);
                    return true;
                }
                return false;
            }
        }
}
