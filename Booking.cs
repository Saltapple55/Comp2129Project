using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class Booking
    {
        private int bookingNum = 0;
        private Customer customer;
        private Flight flight;
        private string bookingDate;


        public Booking(Customer customer, Flight flight)
        {
            this.bookingNum = bookingNum++;
            this.customer = customer;
            this.flight = flight;
            this.bookingDate = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt"); ;
        }

        public Customer Customer
        {
            get { return customer; }
        }

        public Flight Flight
        {
            get { return flight; }
        }


        public int BookingNum
        {
            get { return bookingNum; }
        }

        public string BookingDate
        {
            get { return bookingDate; }
        }

        public override string ToString()
        {

            string s = $"\nCustomer { customer.FirstName} {customer.LastName} \nFlight: {flight.FlightNum} \nBooking Number: {bookingNum} \nBooking Date: {bookingDate}";

            return s;
        }


    }
}
