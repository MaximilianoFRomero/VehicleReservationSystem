using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentSys.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public User user { get; set; }
        public Vehicle vehicle { get; set; }
        public int reservedDays { get; set; }

        public Reservation(Vehicle vehicle, User user, DateTime startDate, DateTime endDate)
        {
            this.vehicle = vehicle;
            this.user = user;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public int CalculateReservedDays() => (endDate - startDate).Days;
    }
}
