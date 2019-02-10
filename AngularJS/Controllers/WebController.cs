using AngularJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AngularJS.Controllers
{
    public class WebController : ApiController
    {
        ReservationRepository reservationRepository = ReservationRepository.Singleton();

        public IEnumerable<Reservation> GetReservations()
        {
            return reservationRepository.Reservations;
        }

        public Reservation GetReservation(int id)
        {
            return reservationRepository.GetReservation(id);
        }
    }
}