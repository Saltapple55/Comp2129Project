using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class BookingManager : Manager
    {
        //add booking manager method to get all customers in flight
        private int maxBookings;
        private int numBookings;
        private Booking[] bookingList;
      

     
        public BookingManager(int max)
        {
            this.maxBookings = max;
            numBookings = 0;
            bookingList = new Booking[max];
        }

        // Show Customers

        public void displayCustomers()
        {
            foreach (Customer customers in customers)
            {
                Console.WriteLine("List of Customers: \n ");
                Console.WriteLine("Customer Id:" + custId + "\n Customer First Name: " 
                    + custFname + "Customer Last Name: " + custLname );
            }
        }

        // DISPLAY FLIGHTS: 
        public void displayFlights()
        {
            foreach (Flight flight in flights)
            {
                Console.WriteLine("List of Flights: \n");
                Console.WriteLine("Flight Id:" + flightId);
            }
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

        // NEED THE CUSTOMER 
        //FIND CUSTOMER
        public Customer findcustId(int custId)
        {
            foreach (Customer customer in customers)
            {
                if (customer.custId == custId) 
                    return customer;
            }
        }

        // NEED THE FLIGHT
        //FIND THE FLIGHT
        public Flight findflightId(int flightId)
        {
            foreach (Flight flight in flights)
            {
                if (flight.flightId == flightId)
                    return flight;
            }
        }

        public Booking findBookingwithIds(int custId, int flightId)
        {
            foreach (Booking booking in booking)
            {
                if (booking.custId() == custId && booking.flightId() == bookingNum)
                {
                    return booking;
                }
            }
            return null; 
            Console.WriteLine("The Booking was not found. ");
        }

        //standard adding of booking

        public bool addBooking(int bookingNum, int[] customers, string bookingDate)
        {

            // Get the customer ID and flight ID
            Console.WriteLine("\nEnter the Customer Id Please: ");
            int custId = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the Flight Id Please: ");
            int flightId = int.Parse(Console.ReadLine());

           
            // if the booking didn't match 

            if (!isBookingValid(custId, flightId))
            {
                Console.WriteLine("Booking does not match the customer or flight Id please try again.");
            }


            // KEEP THIS TO PREVENT USING TOO MUCH MEMORY ??? 
            if (numBookings < maxBookings)
            {
                bookingList[numBookings] = new Booking(bookingNum, customers, bookingDate);
                numBookings++;
                return true;
            }
            return false;
        }



        public override string ToString()
        {
            string s = "------------Bookings------------"
            for (int i = 0; i < numBookings; i++)
            {
                s = s + bookingList[i].ToString();
                s = s + "\n \n";
            }
            return s;
        }
    }
}
