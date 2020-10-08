using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace barberShopProject20201006.Models
{
    public abstract class Person
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}
