using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class Booking
    {
        private static int bookingNumGenerator = 0;
        private int bookingNum;
        private Customer customer;
        private Flight flight;
        private string bookingDate;

        public static void getBookingNumGenerator(int num)
        {
            bookingNumGenerator = num;
        }
        public Booking(Customer customer, Flight flight)
        {
            this.bookingNum = ++bookingNumGenerator;
            this.customer = customer;
            this.flight = flight;
            this.bookingDate = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt"); ;
        }

        
        // made a new constructor for the loading and saving of files
        public Booking(int bookingNum, Customer customer, Flight flight, string bookingDate)
        {
            this.bookingNum = bookingNum;
            this.customer = customer;
            this.flight = flight;
            this.bookingDate = bookingDate;
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
