using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMCarRental.Domain;
using JAMCarRental.Data;

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