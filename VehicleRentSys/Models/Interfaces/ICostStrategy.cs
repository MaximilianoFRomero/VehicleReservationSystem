using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentSys.Models.Interfaces
{
    public interface ICostStrategy
    {
        double CalculateCost(int days, double BaseRentCost);
    }
}
