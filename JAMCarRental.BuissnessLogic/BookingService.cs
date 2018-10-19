using JAMCarRental.Data;
using JAMCarRental.Domain;
using System;

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

        public void Remove(Booking booking)
        {
            inputUserData.Bookings.Remove(booking);
            inputUserData.SaveChanges();
        }
        public List<string> searchAvaliableCars(DateTime starDateTime, DateTime endDateTime)
        {
            //if datetime is between cars booking stop until start.
        }
    }
}