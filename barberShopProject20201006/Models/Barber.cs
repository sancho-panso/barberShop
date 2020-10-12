using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace barberShopProject20201006.Models
{
    public class Barber: Person
    {
        public Barber()
        {
            Id = Guid.NewGuid();

        }
    }
}
