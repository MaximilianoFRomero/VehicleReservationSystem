using VehicleRentSys.Models;

namespace VehicleRentSys.Service
{
    public class GestorReservas
    {
        private List<Reservation> reservationList { get; } = new List<Reservation>();

        public Reservation CreateReservation(Vehicle vehiculo, User usuario, DateTime fechaInicio, DateTime fechaFin)
        {
            var reservation = new Reservation(vehiculo, usuario, fechaInicio, fechaFin);
            reservationList.Add(reservation);
            return reservation;
        }

        public Reservation UpdateReservation(Reservation reservation, DateTime newStartDate, DateTime newEndDate)
        {
            reservation = new Reservation(reservation.vehicle, reservation.user, newStartDate, newEndDate);
            return reservation;
        }

        public void DeleteReservation(Reservation reservation) => reservationList.Remove(reservation);

        public Reservation GetReservation(Vehicle vehicle, User user, DateTime startDate) =>
            reservationList.Find(reservation => reservation.vehicle == vehicle && reservation.user == user && reservation.startDate == startDate);
    }
}
