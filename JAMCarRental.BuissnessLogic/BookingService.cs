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
<<<<<<< HEAD
            var query = inputUserData.Cars.Where(c =>
                c.Bookings.Where(b => !(b.StartTime > endDateTime && b.EndTime < starDateTime)).ToList().Count == 0);
            return query.ToList();
        }

        public void LendCar(Car car)
=======
<<<<<<< HEAD
        }
=======
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

>>>>>>> 805ee7eceba43fa65c0dbbb5b90c987822e88e46
        public void ReturnCar(DateTime returnTime, Booking booking)
>>>>>>> 66367e09ddb87db6110f473f4d909524369a8012
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