namespace Sliit.MTIT.DriverOtherServices.Services
{
    public interface IDriverOtherServices
    {
        List<Models.DriverOtherService> GetDriverOtherServices();
        Models.DriverOtherService? GetDriverOtherService(int DealerId);
        Models.DriverOtherService? AddDriverOtherService(Models.DriverOtherService driverOtherService);
        Models.DriverOtherService UpdateDriverOtherService(Models.DriverOtherService driverOtherService);
        bool? DeleteDriverOtherService(int DealerId);
    }
}
