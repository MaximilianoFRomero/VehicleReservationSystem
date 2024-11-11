using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentSys.Models;

namespace VehicleRentSys.Model.Dao
{
    public class VehicleDAO
    {
        private List<Vehicle> vehicleList;

        public VehicleDAO()
        {
            vehicleList = new List<Vehicle>();
        }


        public void AddVehicle(Vehicle vehicle)
        {
            vehicleList.Add(vehicle);
        }

        public List<Vehicle> GetAllVehicles()
        {
            return vehicleList;
        }

        public Vehicle GetVehicleByLicense(string license)
        {
            return vehicleList.FirstOrDefault(vehicle => vehicle.GetLicense() == license);
        }


        public void UpdateVehicle(Vehicle updatedVehicle)
        {
            var vehicle = GetVehicleByLicense(updatedVehicle.GetLicense());
            if (vehicle != null)
            {
                vehicle.brand = updatedVehicle.brand;
                vehicle.model = updatedVehicle.model;
                vehicle.rentCost = updatedVehicle.rentCost;
            }
        }

        public void DeleteVehicle(string license)
        {
            var vehicle = GetVehicleByLicense(license);
            if (vehicle != null)
            {
                vehicleList.Remove(vehicle);
            }
        }
    }
}
