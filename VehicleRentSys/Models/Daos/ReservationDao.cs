using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentSys.Models;

namespace VehicleRentSys.Model.Dao
{
    public class ReservationDAO
    {
        private List<Reservation> reservations;

        public ReservationDAO()
        {
            reservations = new List<Reservation>();
        }

        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public List<Reservation> ListReservations()
        {
            return reservations;
        }

        public Reservation GetReservationById(int id)
        {
            return reservations.FirstOrDefault(reservation => reservation.Id == id);
        }

        public void UpdateReservation(Reservation updatedReservation)
        {
            var reservation = GetReservationById(updatedReservation.Id);
            if (reservation != null)
            {
                reservation.startDate = updatedReservation.startDate;
                reservation.endDate = updatedReservation.endDate;
                reservation.vehicle = updatedReservation.vehicle;
            }
        }

        public void DeleteReservation(int id)
        {
            var reservation = GetReservationById(id);
            if (reservation != null)
            {
                reservations.Remove(reservation);
            }
        }
    }
}
