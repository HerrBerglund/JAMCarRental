using JAMCarRental.Data;
using JAMCarRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

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
            var bookings = inputUserData.Bookings.ToList();
            //var cars = inputUserData.Cars.ToList().Select(x => x.Id == 3);
            var okCars= new List<string>();
            int idForTheOKCar = 0;
         
            foreach (var bk in bookings)
            {
                if (starDateTime >= bk.EndTime && endDateTime <= bk.StartTime)
                {
                    int idsearched = bk.CarId;
                    var registredNumber = inputUserData.Cars.Select(x => x.RegistrationNumber);
                    bk.CarId;
                    okCars.Add();  
                }
            }
        }

        public void ReturnCar(DateTime returnTime, Booking booking)
        {
            booking.EndTime = returnTime;
            inputUserData.Bookings.Update(booking);
            inputUserData.SaveChanges();
        }
    }
}