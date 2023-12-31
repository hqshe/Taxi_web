using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taxi_site.Data;
using Taxi_site.Models;

namespace Taxi_site.Controllers
{
    public class PassengerRegistrationController : Controller
    {
        private Taxi_siteDbContext dtbs;

        public PassengerRegistrationController(Taxi_siteDbContext dtbs)
        {
            this.dtbs = dtbs;
        }

        public IActionResult PassengerRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PassengerRegistration(RegisteredPassenger regispass)
        {
            if (ModelState.IsValid)
            {
                bool usExist = dtbs.RegisteredPassengers.Any(p => p.Email == regispass.Email);

                if (!usExist)
                {
                    dtbs.RegisteredPassengers.Add(regispass);
                    dtbs.SaveChanges();

                    RegisteredPassenger registereduser = dtbs.RegisteredPassengers.FirstOrDefault(p => p.Email == regispass.Email);

                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}