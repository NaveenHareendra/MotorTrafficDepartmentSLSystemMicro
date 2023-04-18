namespace Vehicle.Registration.Data
{
    public class VehicleDataService
    {
        public static List<Models.Vehicle> Vehicles = new List<Models.Vehicle>()
        {
            new Models.Vehicle{Id=1,Vehiclebrand="BMW",Vehiclemodel="740le",Vehiclenumber="CBE-5698",Vehicleowner="Kasun",Vehicletype="Luxury Car"},
            new Models.Vehicle{Id=2,Vehiclebrand="Mercedes-Benz",Vehiclemodel="S 650",Vehiclenumber="CAW-2335",Vehicleowner="Amala",Vehicletype="Luxury Car"},
            new Models.Vehicle{Id=3,Vehiclebrand="Toyota",Vehiclemodel="Crown",Vehiclenumber="CBJ-2643",Vehicleowner="Nimal",Vehicletype="Luxury Car"},
        };
    }
}
