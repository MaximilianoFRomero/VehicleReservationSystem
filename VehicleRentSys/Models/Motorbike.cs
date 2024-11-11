using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentSys.Models.Interfaces;

namespace VehicleRentSys.Models
{
    public class Motorbike : Vehicle
    {
        public string license { get; set; }

        public Motorbike(string brand, string model, ICostStrategy rentCost, string license) : base(brand, model, rentCost)
        {
            this.license = license;
        }

        public override string GetLicense()
        {
            return license;
        }
    }
}
