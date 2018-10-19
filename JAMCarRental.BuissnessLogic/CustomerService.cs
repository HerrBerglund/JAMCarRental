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

        public void Change(Customer customer)
        {
            inputUserData.Customers.Update(customer);
            inputUserData.SaveChanges();
        }

        public void Remove(Customer customer)
        {
            inputUserData.Customers.Remove(customer);
            inputUserData.SaveChanges();
        }
    }
}