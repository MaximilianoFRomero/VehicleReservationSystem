using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentSys.Models.Interfaces;
using VehicleRentSys.Models;

namespace VehicleRentSys.Service
{
    public class VehicleManager
    {
        private List<Vehicle> vehicleList { get; } = new List<Vehicle>();
        private IVehicleFactory vehicleFactory;

        public VehicleManager(IVehicleFactory vehicleFactory)
        {
            this.vehicleFactory = vehicleFactory;
        }

        public void SetVehicleFactory(IVehicleFactory vehicleFactory) => this.vehicleFactory = vehicleFactory;

        public Vehicle CreateVehicle(string brand, string model, int id, ICostStrategy baseRentCost, string license)
        {
            var vehicle = vehicleFactory.CreateVehicle(brand, model, baseRentCost, license);
            vehicleList.Add(vehicle);
            return vehicle;
        }

        public void UpdateVehicle(Vehicle vehicle, string newBrand, string newModel, ICostStrategy newBaseRentCost)
        {
            vehicle.brand = newBrand;
            vehicle.model = newModel;
            vehicle.rentCost = newBaseRentCost;
        }

        public void DeleteVehicle(Vehicle vehicle) => vehicleList.Remove(vehicle);

        public Vehicle GetVehicle(string license) => vehicleList.Find(vehicle => vehicle.GetLicense() == license);
    }
}
