using Sliit.MTIT.DriverOtherServices.Data;
using Sliit.MTIT.DriverOtherServices.Models;

namespace Sliit.MTIT.DriverOtherServices.Services
{
    public class DriverOtherServicesSevice : IDriverOtherServices
    {
        public List<Models.DriverOtherService> GetDriverOtherServices ()
        {
            return DriverOtherServicesMockDataService.DriverOtherServices;
        }

        public Models.DriverOtherService? GetDriverOtherService(int DealerID)
        {
            return DriverOtherServicesMockDataService.DriverOtherServices.FirstOrDefault(x => x.DealerId == DealerID);
        }

        public Models.DriverOtherService? AddDriverOtherService(Models.DriverOtherService driverOtherService)
        { 
            DriverOtherServicesMockDataService.DriverOtherServices.Add(driverOtherService);
            return driverOtherService;
        }

        public Models.DriverOtherService? UpdateDriverOtherService(Models.DriverOtherService driverOtherService)
        {
            Models.DriverOtherService selectedDriveOtherServices = DriverOtherServicesMockDataService.DriverOtherServices.FirstOrDefault(x => x.DealerId == driverOtherService.DealerId);
            if (selectedDriveOtherServices == null) 
            {
                selectedDriveOtherServices.DealerName = driverOtherService.DealerName;
                selectedDriveOtherServices.DealerContactNo = driverOtherService.DealerContactNo;
                selectedDriveOtherServices.OwnerName = driverOtherService.OwnerName;
                selectedDriveOtherServices.OwnerNIC = driverOtherService.OwnerNIC;
                return selectedDriveOtherServices;
            }

            return selectedDriveOtherServices;
        }

        public bool? DeleteDriverOtherService(int DealerId)
        { 
            Models.DriverOtherService selectedDriverOtherService = DriverOtherServicesMockDataService.DriverOtherServices.FirstOrDefault(x => x.DealerId == DealerId);
            if (selectedDriverOtherService != null)
            { 
                DriverOtherServicesMockDataService.DriverOtherServices.Remove(selectedDriverOtherService);
                return true;
            }
            return false;
        }
    }
}

