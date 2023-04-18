namespace Vehicle.Registration.Services
{
    public interface IVehicleService
    {
        List<Models.Vehicle> GetVehicles();
        Models.Vehicle? GetVehicle(int id);
        Models.Vehicle? AddVehicle(Models.Vehicle vehicle);
        Models.Vehicle? UpdateVehicle(Models.Vehicle vehicle);
        bool? DeleteVehicle(int id);
    } 
}
