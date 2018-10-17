using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMCarRental.Domain
{
    public class Car
    {
        public Car()
        {
            Bookings = new List<Booking>();
        }
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Brand { get; set; }
        public string Mark { get; set; }
        public DateTime Year { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
