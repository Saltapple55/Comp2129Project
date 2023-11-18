using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class AirlineCoordinator
    {
        //enum for errors is an option
        //function return a string
        //exceptions-
        //add a out parameter that happens when error happens-out parameter is string
        CustomerManager custMan;
        FlightManager flightMan;
        BookingManager bookMan;

        public AirlineCoordinator(CustomerManager custMan, FlightManager flightMan, BookingManager bookMan)
        {
            this.custMan = custMan;
            this.flightMan = flightMan;
            this.bookMan = bookMan;
        }
        //getters
        public CustomerManager CustomerManager { get { return custMan; } }
        public FlightManager FlightManager { get { return flightMan; } }
        public BookingManager BookingManager { get { return bookMan; } }
        //Customer Manager methods
        public bool addCustomer(string fname, string lname, string phoneNum, out string error) {
            return custMan.addCustomer(fname, lname, phoneNum, out error);
        }
        public bool deleteCustomer(int index)
        {
            return custMan.removeCustomer(index);
        }
        public string viewAllCustomers()
        {
            return custMan.ToString();
        }
        //BookingManager methods
        public bool addBooking(Flight f, Customer c) {

            return true;
        }
        
        public string viewAllBookings()
        {
            return bookMan.ToString();
        }
        //FlightManager methods
        public bool addFlight(int flightNum, string flightDest, string flightOrigin, int maxSeats) 
        {
            return flightMan.addFlight(flightNum, flightDest, flightOrigin, maxSeats);
        }
        public string viewOneFlight()
        {
            return flightMan.ToString();
        }
        public bool deleteFlight(int index)
        {
            return flightMan.removeFlight(index);
        }
        public string viewAllFlights()
        {
            return flightMan.ToString();
        }
       
    }
}
