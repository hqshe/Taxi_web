using Microsoft.AspNetCore.Mvc;
using Taxi_site.Data;
using Taxi_site.Models;

namespace Taxi_site.Controllers
{
    public class PassengerProfileController : Controller
    {
        public static RegisteredPassenger? regpass;
        private Taxi_siteDbContext dbcx;

        public PassengerProfileController(Taxi_siteDbContext dbcx)
        {
            this.dbcx = dbcx;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            regpass = null;
            return RedirectToAction("Index", "Home");
        }
    }
}
