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

        public List<Car> searchAvaliableCars(DateTime starDateTime, DateTime endDateTime)
        {
            var query = inputUserData.Cars.Where(c =>
                c.Bookings.Where(b => !(b.StartTime > endDateTime && b.EndTime < starDateTime)).ToList().Count == 0);
            return query.ToList();
        }

        public void LendCar(Car car)
        {
            inputUserData.Cars.Find(car.Id).IsReturned = false;
            inputUserData.SaveChanges();
        }

        public void ReturnCar(Car car)
        {
            inputUserData.Cars.Find(car.Id).IsReturned = true;
            inputUserData.SaveChanges();
        }
    }
}