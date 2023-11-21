// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
namespace FlightProject2129
{
    public class Program
    {

        private static CustomerManager? custMan;
        private static FlightManager? flightMan;    
        private static BookingManager? bookingMan;

        public static void Main(string[] args)
        {
            //PLEASE CHANGE THE LOCATION TO FIT U! 
            string location = "flightproject.txt";
            
            custMan = new CustomerManager(10);
            FlightManager flightMan = new FlightManager(10);
            BookingManager bookMan = new BookingManager(10);
            AirlineCoordinator airCon = new AirlineCoordinator(custMan, flightMan, bookMan);
            Menu.MainMenu(airCon);


            saveToDisk(location);






            /*
             * // Example array to be saved
            string[] dataArray = { "Data1", "Data2", "Data3" };

            // Specify the file name
            string fileName = "output.txt";

            // Call the SaveArrayToFile method to store the array in the file
            DataStorage.SaveArrayToFile(fileName, dataArray);
            */
        }

        public static void saveToDisk(string location)
        {
            // add getters to all the lists
            // // intialize outside of main 
            if (custMan != null) {
                UtilityClass.saveCustomers(location, custMan.getCustomerList(), custMan.NumCustomers);

            } else
            {
                Console.WriteLine("Try Again, can't save customer");
            }

            if (flightMan != null)
            {
                UtilityClass.saveFlights(location, flightMan.getFlightList(), flightMan.NumFlights);
            } else
            {
                Console.WriteLine("Try again, can't save flights");
            }

            if (bookingMan != null)
            {
                UtilityClass.saveBookings(location, bookingMan.getBookingList(), bookingMan.getNumBookings());
            }else
            {
                Console.WriteLine("Try again, can't save booking");
            }
            
        }
       
     

    }
}
