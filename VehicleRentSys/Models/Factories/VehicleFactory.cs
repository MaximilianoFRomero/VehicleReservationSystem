using VehicleRentSys.Models;
using VehicleRentSys.Models.Interfaces;

namespace VehicleRentSys.Model.Factory
{
    public abstract class VehicleFactory : IVehicleFactory
    {
        public abstract Vehicle CreateVehicle(string brand, string model, ICostStrategy baseRentCost, string license);
    }
}