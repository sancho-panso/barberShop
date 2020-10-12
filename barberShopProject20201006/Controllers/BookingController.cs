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
        static List<Booking> booking = new List<Booking>();

        public IActionResult Booking()
        {
            if (booking.Count() == 0)
            {
                Barber Aurimas = new Barber() { Name = "Aurimas", Surname = "Bajo" };
                Barber Tomas = new Barber() { Name = "Tomas", Surname = "Sinickis" };
                Client Rytis = new Client() { Name = "Rytis", Surname = "Rytelis", Phone = "605-34959" };
                Client Vakaris = new Client() { Name = "Vakaris", Surname = "Vakarskis", Phone = "699-12934" };
                Client Monika = new Client() { Name = "Monika", Surname = "Monkyte", Phone = "666-22389" };

                booking.Add(new Booking() { Barber = Aurimas, Status = BookingStatus.available, Time = DateTime.Now, Client = Vakaris });
                booking.Add(new Booking() { Barber = Aurimas, Status = BookingStatus.available, Time = DateTime.Now, Client = Rytis });
                booking.Add(new Booking() { Barber = Tomas, Status = BookingStatus.available, Time = DateTime.Now, Client = Monika });
            }

            return View(booking);
        }

        [HttpGet]
        public IActionResult Book(Guid? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.BookingId = id;
            return View(booking);
        }  
        //public IActionResult Book()
        //{
        //    return  View(booking);
        //}
    }
}
