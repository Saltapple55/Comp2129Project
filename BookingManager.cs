using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class BookingManager
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

        
        public Booking[] getBookingList()
        {
            return bookingList;
        }


        // Show Customers



        // check if the booking works 
        /* public bool IsBookingValid(int custId, int flightId)
         {
             // I NEED THE CUSTOMER AND FLIGHT 
             Customer selectedCustomer = findcustId(custId);
             Flight selectedFlight = findflightId(flightId);
             Booking existingBooking = FindBookingByCustomerAndFlightId(customerId, flightId);

             return selectedCustomer != null && selectedFlight != null && selectedFlight.AvailableSeats > 0 && existingBooking == null;
         }*/

        // NEED THE CUSTOMER 
        //FIND CUSTOMER

        //standard adding of booking
        
        private bool checkBookingExists(int custId, int flightId)
        {
            for (int i = 0; i < numBookings; i++)
            {

                if (bookingList[i].Flight.FlightNum == flightId && bookingList[i].Customer.CustID == custId)
                {
                    return true;
                }
            }
            return false;
        }

        public bool addBooking(Customer customer, Flight flight, out string error)
        {
            if (checkBookingExists(customer.CustID, flight.FlightNum))
            {
                error = "Booking already exists";
                return false;
            }
            else if (numBookings == maxBookings)
            {
                error = "Can't add any new Bookings";
                return false;
            }
            //if this function is false, returns error, otherwise adds a customer and Booking is good to go
            if (!flight.addCustomer(customer))
            {
                error = "Flight is full, cannot accept any new Customers";
                return false;
            }
            customer.increaseNumBooking();


            
            bookingList[numBookings] = new Booking(customer, flight);
            numBookings++;
            error = "";
            return true;
                // ADD ERROR CODE

        }

        public override string ToString()
        {
            if(numBookings == 0)
            {
                return "No Bookings have been made yet";
            }
            string s = "---------Bookings---------\n";

            for (int i = 0; i < numBookings; i++)
            {
                s = s + bookingList[i].ToString();
                s = s + "\n \n";
            }
            return s;
        }
    }
}

