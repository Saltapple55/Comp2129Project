// See https://aka.ms/new-console-template for more information

using System;
namespace FlightProject2129
{
    public class Program
    {
          private static CustomerManager? custMan;
        private static FlightManager? flightMan;    
        private static BookingManager? bookingMan;
        
        public static void Main(string[] args)
        {
            CustomerManager custMan = new CustomerManager(10);
            FlightManager flightMan = new FlightManager(10);
            BookingManager bookMan= new BookingManager(10);
            AirlineCoordinator airCon = new AirlineCoordinator(custMan, flightMan, bookMan);
            Menu.MainMenu(airCon);

        }

       
    }

          public void saveToDisk(string location)
        {
            // add getters to all the lists
            // // intialize outside of main 

            UtilityClass.saveCustomers(location, custMan.getCustomerList(), custMan.NumCustomers);
            UtilityClass.saveFlights(location, flightMan.getFlightList(), flightMan.NumFlights);
            UtilityClass.saveBookings(location, bookingMan.getBookingList(), bookingMan.getNumBookings()); 
        }
}
