using JAMCarRental.Data;
using JAMCarRental.Domain;

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