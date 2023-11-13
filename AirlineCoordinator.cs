using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class AirlineCoordinator
    {
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
        public bool addCustomer(string fname, string lname, string phoneNum) {
            return custMan.addCustomer(fname, lname, phoneNum);
        }
        public bool deleteCustomer(int index)
        {
            if (bookMan.)
            return custMan.removeCustomer(index);
        }
        public string viewAllCustomers()
        {
            return custMan.ToString();
        }
        //BookingManager methods
        public bool addBooking(int flightId, Customer[] custs) {

            return true;
        }
        
        public string viewAllBookings()
        {
            return bookMan.ToString();
        }
        //FlightManager methods
        public bool addFlight() { }
        public string viewOneFlight()
        {
            return flightMan.ToString();
        }

        public string viewAllFlights()
        {
            return flightMan.ToString();
        }
       
    }
}
