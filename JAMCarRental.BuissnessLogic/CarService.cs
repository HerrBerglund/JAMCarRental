using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMCarRental.Domain;
using JAMCarRental.Data;

namespace JAMCarRental.BuissnessLogic
{
    public class CarService
    {
        private JamCarRentalContext inputUserData = new JamCarRentalContext();

        public void Add(Car car)
        {
            inputUserData.Cars.Add(car);
            inputUserData.SaveChanges();
        }
    }
}