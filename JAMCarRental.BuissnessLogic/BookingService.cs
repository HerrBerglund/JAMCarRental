using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMCarRental.Domain;
using JAMCarRental.Data;

namespace JAMCarRental.BuissnessLogic
{
    public class BookingService
    {
        private JamCarRentalContext inputUserData = new JamCarRentalContext();

        public void Add(Booking booking)
        {
            inputUserData.Bookings.Add(booking);
            inputUserData.SaveChanges();
        }
    }
}