using AngularJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJS.Controllers
{
    public class HomeController : Controller
    {
        ReservationRepository reservationRepository = ReservationRepository.Singleton();

        public ActionResult Index()
        {
            return View(reservationRepository.Reservations);
        }

        public ActionResult Add(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                reservationRepository.Add(reservation);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(reservationRepository.Reservations);
            }
        }

        public ActionResult Remove(int reservationId)
        {
            reservationRepository.Remove(reservationId);

            return RedirectToAction(nameof(Index));
        }
    }
}