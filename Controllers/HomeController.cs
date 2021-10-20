using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using wee5e.Models;

namespace wee5e.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Home()
        {
            return RedirectToAction("Registration");
        }

        [HttpGet("registration")]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User usertoreg)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == usertoreg.Email))
                {
                    ModelState.AddModelError("Email", "The email you entered is already in use.");

                    return View("registration");
                }

                PasswordHasher<User> CBHash = new PasswordHasher<User>();
                usertoreg.Password = CBHash.HashPassword(usertoreg, usertoreg.Password);

                _context.Add(usertoreg);
                _context.SaveChanges();

                HttpContext.Session.SetInt32("loggedinuser", usertoreg.UserId);

                return RedirectToAction("registration");
            }
            else
            {
                return View("registration");
            }
        }
    }
}