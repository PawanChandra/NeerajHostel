using Microsoft.AspNetCore.Mvc;
using NeerajHostel_FrontEnd.Models;

namespace NeerajHostel_FrontEnd.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signin(User args)
        {
            return View();
        }
    }
}
