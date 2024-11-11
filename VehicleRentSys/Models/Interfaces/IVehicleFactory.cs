using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentSys.Models.Interfaces
{
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(string brand, string model, ICostStrategy baseRentCost, string license);
    }
}
