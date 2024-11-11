using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentSys.Models.Interfaces;
using VehicleRentSys.Models;

namespace VehicleRentSys.Model.Factory
{
    public class TruckFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle(string brand, string model, ICostStrategy baseRentCost, string license)
        {
            return new Truck(brand, model, baseRentCost, license);
        }
    }
}
