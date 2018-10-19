using System;

namespace JAMCarRental.Domain
{
    public class Booking
    {
        public int Id { get; set; }
        public Car TheCar { get; set; }
        public int CarId { get; set; }
        public Customer TheCustomer { get; set; }
        public int CustomerId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}