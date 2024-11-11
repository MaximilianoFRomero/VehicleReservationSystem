using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentSys.Models.Interfaces;

namespace VehicleRentSys.Models.Strategies
{
    public class TruckStrategy : ICostStrategy
    {
        public double CalculateCost(int days, double baseRentCost)
        {
            return days*baseRentCost;
        }
    }
}
