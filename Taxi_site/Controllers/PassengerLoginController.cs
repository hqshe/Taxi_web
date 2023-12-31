using Microsoft.AspNetCore.Mvc;
using Taxi_site.Data;
using Taxi_site.Models;

namespace Taxi_site.Controllers
{
    public class PassengerLoginController : Controller
    {
        public static RegisteredPassenger regpass;
        private Taxi_siteDbContext dbcx;

        public PassengerLoginController(Taxi_siteDbContext dbcx)
        {
            this.dbcx = dbcx;
        }

        public IActionResult PassengerLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PassengerLogin(RegisteredPassenger regpass)
        {
            // Перевірка чи існує користувач із введеними ім'ям та паролем
            var userExists = dbcx.RegisteredPassengers.FirstOrDefault(v => v.Email == regpass.Email && v.Password == regpass.Password);

            if (userExists != null)
            {
                // Користувач знайдений, перенаправляємо його на головну сторінку
                PassengerProfileController.regpass = userExists;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Неправильне ім'я користувача або пароль");
                ModelState.AddModelError(string.Empty, "Або Ваш акаунт не є зареєстрований");
                return View();
            }

        }
    }
}
