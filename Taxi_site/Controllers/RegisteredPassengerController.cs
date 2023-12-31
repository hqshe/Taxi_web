using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Taxi_site.Data;
using Taxi_site.Models;

namespace Taxi_site.Controllers
{
    public class RegisteredPassengerController : Controller
    {
        private Taxi_siteDbContext dbContext_;
        private static RegisteredPassenger UserPassenger;

        public RegisteredPassengerController(Taxi_siteDbContext dbcontext)
        {
            dbContext_ = dbcontext;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(RegisteredPassenger model)
        {
            var user = dbContext_.RegisteredPassengers.FirstOrDefault(e => e.FullName == model.FullName && e.Password == model.Password);
            if (user != null)
            {
                RegisteredPassengerController.UserPassenger = user;
                return RedirectToAction("Profile", "User");
            }
            return View(model);
        }
    }
}
