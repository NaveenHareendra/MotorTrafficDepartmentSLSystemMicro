using Vehicle.Registration.Data;
using Vehicle.Registration.Models;

namespace Vehicle.Registration.Services
{
    public class VehicleService : IVehicleService
    {
        public List<Models.Vehicle> GetVehicles()
        {
            return VehicleDataService.Vehicles;
        }

        public Models.Vehicle? GetVehicle(int id)
        {
            return VehicleDataService.Vehicles.FirstOrDefault(x => x.Id == id);
        }

        public Models.Vehicle? AddVehicle(Models.Vehicle vehicle)
        {
            VehicleDataService.Vehicles.Add(vehicle);
            return vehicle;
        }

        public Models.Vehicle? UpdateVehicle(Models.Vehicle vehicle)
        {
            Models.Vehicle selectedVehicle = VehicleDataService.Vehicles.FirstOrDefault(x => x.Id == vehicle.Id);
            if (selectedVehicle != null)
            {
                selectedVehicle.Vehiclebrand = vehicle.Vehiclebrand;
                selectedVehicle.Vehiclemodel = vehicle.Vehiclemodel;
                selectedVehicle.Vehicletype = vehicle.Vehicletype;
                selectedVehicle.Vehicleowner = vehicle.Vehicleowner;
                selectedVehicle.Vehiclenumber = vehicle.Vehiclenumber;
                return selectedVehicle;
            }

            return selectedVehicle;
        }

        public bool? DeleteVehicle(int id)
        {
            Models.Vehicle selectedVehicle = VehicleDataService.Vehicles.FirstOrDefault(x => x.Id == id);
            if (selectedVehicle != null)
            {
                VehicleDataService.Vehicles.Remove(selectedVehicle);
                return true;
            }
            return false;
        }

    }
}
