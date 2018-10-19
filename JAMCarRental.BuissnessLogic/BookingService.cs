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
<<<<<<< HEAD
        public List<string> searchAvaliableCars(DateTime starDateTime, DateTime endDateTime)
        {
            //if datetime is between cars booking stop until start.
=======

        public void ReturnCar(DateTime returnTime, Booking booking)
        {
            booking.EndTime = returnTime;
            inputUserData.Bookings.Update(booking);
            inputUserData.SaveChanges();
>>>>>>> 1c9ec24cdd639169d6f255ed6f4c4d57c0aaa0cc
        }
    }
}