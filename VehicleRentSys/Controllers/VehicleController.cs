using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentSys.Model.Dao;
using VehicleRentSys.Models;

namespace VehicleRentSys.Controller
{
    public class VehicleController
    {
        private VehicleDAO vehicleDAO;

        public VehicleController()
        {
            vehicleDAO = new VehicleDAO();
        }

        public void AddNewVehicle(Vehicle vehicle)
        {
            vehicleDAO.AddVehicle(vehicle);
        }

        public List<Vehicle> GetAllVehicles()
        {
            return vehicleDAO.GetAllVehicles();
        }

    }
}
