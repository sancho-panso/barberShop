using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace barberShopProject20201006.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dovanos()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
    }
}