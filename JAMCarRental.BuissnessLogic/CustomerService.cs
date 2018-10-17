using JAMCarRental.Data;
using JAMCarRental.Domain;

namespace JAMCarRental.BuissnessLogic
{
    public class CustomerService
    {
        private JamCarRentalContext inputUserData = new JamCarRentalContext();

        public void Add(Customer customer)
        {
            inputUserData.Customers.Add(customer);
            inputUserData.SaveChanges();
        }
    }
}