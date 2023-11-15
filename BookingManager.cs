using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlightProject2129
{
    internal class BookingManager
    {
        private int maxBookings;
        private int numBookings;
        private Booking[] bookingList;
      

     
        public BookingManager(int max)
        {
            this.maxBookings = max;
            numBookings = 0;
            bookingList = new Booking[max];
        }

      
        public Customer[] getCustomersInFlight(Flight f)
        {
            Customer[] flightCustomer = new Customer[Booking.Length];
            int count = 0;

            for (int i = 0; i < Booking.Length; i++)
            {
                // unsure if to use getFlight or Flight 
                if (Booking[i].Flight().Equals(f))
                {
                    flightCustomer[count++] = Booking[i].Customer;
                }

               }
            // copy with only length of count 
            Customer[] custinFlight = new Customer[count];
            Array.Copy(flightCustomer, custinFlight, count);
            Console.WriteLine("This is the customers in flight: ");
            return custinFlight;

        }
           
        // check if the booking works 
        public bool IsBookingValid(int custId, int flightId)
        {
            // I NEED THE CUSTOMER AND FLIGHT 
            Customer selectedCustomer = findcustId(custId);
            Flight selectedFlight = findflightId(flightId);
            Booking existingBooking = FindBookingByCustomerAndFlightId(customerId, flightId);

            return selectedCustomer != null && selectedFlight != null && selectedFlight.AvailableSeats > 0 && existingBooking == null;
        }

        //standard adding of booking

        public bool addBooking(int bookingNum,Customer customer, Flight flight, string bookingDate)
        {

            // Get the customer ID and flight ID
            Console.WriteLine("\nEnter the Customer Id Please: ");
            int custId = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the Flight Id Please: ");
            int flightId = int.Parse(Console.ReadLine());

           
            // if the booking didn't match 

            if (!isBookingValid(custId, flightId))
            {
                return null; 
                //Console.WriteLine("Booking does not match the customer or flight Id please try again.");
            }


            // KEEP THIS TO PREVENT USING TOO MUCH MEMORY ??? 
            if (numBookings < maxBookings)
            {
                bookingList[numBookings] = new Booking(bookingNum, customer, flight, bookingDate);
                numBookings++;
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            string s = "---------Bookings---------"
            string s = base.ToString();
            for (int i = 0; i < numBookings; i++)
            {
                s = s + bookingList[i].ToString();
                s = s + "\n \n";
            }
            return s;
        }
    }
}
