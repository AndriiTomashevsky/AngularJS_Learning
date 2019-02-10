using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJS.Models
{
    public class ReservationRepository
    {
        static ReservationRepository reservationRepository = new ReservationRepository();

        static List<Reservation> reservations = new List<Reservation>()
        {
            new Reservation(){ ReservationId=1,ClientName="Adam",Location="Board Room"},
            new Reservation(){ReservationId=2,ClientName="Jacqui",Location="Lecture Hall"},
            new Reservation(){ ReservationId=3,ClientName="Russell",Location="Meeting Room 1"}
        };

        internal Reservation GetReservation(int reservationId)
        {
            Reservation reservation = reservations.Find(r => r.ReservationId == reservationId);

            return reservation;
        }

        public static ReservationRepository Singleton()
        {
            return reservationRepository;
        }

        internal void Add(Reservation reservation)
        {
            reservation.ReservationId = reservations.Count + 1;
            reservations.Add(reservation);
        }

        internal void Remove(int reservationId)
        {
            Reservation deletedReservation = GetReservation(reservationId);
            reservations.Remove(deletedReservation);
        }

        public IEnumerable<Reservation> Reservations
        {
            get { return reservations; }
        }
    }
}