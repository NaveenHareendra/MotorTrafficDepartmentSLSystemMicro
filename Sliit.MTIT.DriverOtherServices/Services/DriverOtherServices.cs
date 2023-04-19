using Sliit.MTIT.DriverOtherServices.Data;
using Sliit.MTIT.DriverOtherServices.Models;

namespace Sliit.MTIT.DriverOtherServices.Services
{
    public class DriverOtherServicesSevice : IDriverOtherServices
    {
        public List<Models.DriverOtherService> GetDriverOtherServices ()
        {
            return DriverOtherServicesMockDataService.OtherServicesData;
        }

        public Models.DriverOtherService? GetDriverOtherService(int DealerID)
        {
            return DriverOtherServicesMockDataService.OtherServicesData.FirstOrDefault(x => x.DealerId == DealerID);
        }

        public Models.DriverOtherService? AddDriverOtherService(Models.DriverOtherService driverOtherService)
        { 
            DriverOtherServicesMockDataService.OtherServicesData.Add(driverOtherService);
            return driverOtherService;
        }

        public Models.DriverOtherService? UpdateDriverOtherService(Models.DriverOtherService driverServices)
        {
            Models.DriverOtherService selectedDriveOtherServices = DriverOtherServicesMockDataService.OtherServicesData.FirstOrDefault(x => x.DealerId == driverServices.DealerId);
            Console.WriteLine("selectedDriveOtherServices" + selectedDriveOtherServices.DealerName);
            if (selectedDriveOtherServices != null) 
            {
                selectedDriveOtherServices.DealerName = driverServices.DealerName;
                selectedDriveOtherServices.DealerContactNo = driverServices.DealerContactNo;
                selectedDriveOtherServices.OwnerName = driverServices.OwnerName;
                selectedDriveOtherServices.OwnerNIC = driverServices.OwnerNIC;
 
            }

            Console.WriteLine("Dealer new name: " + driverServices.DealerId); 
            Console.WriteLine("Dealer name: "+selectedDriveOtherServices.DealerId);
            return selectedDriveOtherServices;
        }

        public bool? DeleteDriverOtherService(int DealerId)
        { 
            Models.DriverOtherService selectedDriverOtherService = DriverOtherServicesMockDataService.OtherServicesData.FirstOrDefault(x => x.DealerId == DealerId);
            if (selectedDriverOtherService != null)
            { 
                DriverOtherServicesMockDataService.OtherServicesData.Remove(selectedDriverOtherService);
                return true;
            }
            return false;
        }
    }
}

