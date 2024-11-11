using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentSys.Models.Interfaces;

namespace VehicleRentSys.Models
{
    public abstract class Vehicle
    {
        public string brand { get; set; }
        public string model { get; set; }
        public ICostStrategy rentCost { get; set; }

        public Vehicle(string brand, string model, ICostStrategy rentCost)
        {
            this.brand = brand;
            this.model = model;
            this.rentCost = rentCost;
        }

        public abstract string GetLicense();
    }
}
