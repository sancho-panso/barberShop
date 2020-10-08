using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace barberShopProject20201006.Models
{
    public class Booking
    {
        //public Booking(string client,string barber, DateTime Time )
        //{

        //}
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public Barber Barber { get; set; }
        public BookingStatus Status { get; set; }
        public DateTime Time { get; set; }
    }
}
