using barberShopProject20201006.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace barberShopProject20201006.Controllers
{
    public class BookingController: Controller
    {
        public IActionResult Booking()
        {
            Barber Aurimas = new Barber() { Name = "Aurimas", Surname = "Bajo" };
            Barber Tomas = new Barber() { Name = "Tomas", Surname = "Sinickis" };
            List<Booking> booking = new List<Booking>()
            {
                new Booking(){Barber = Aurimas, Status=BookingStatus.available, Time = DateTime.Now },
                new Booking(){Barber = Aurimas, Status=BookingStatus.available, Time = DateTime.Now },
                new Booking(){Barber = Aurimas, Status=BookingStatus.available, Time = DateTime.Now },
            };
            return View(booking);
        }
    }
}
