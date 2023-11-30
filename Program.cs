using System;
using System.IO;
using System.Text;

namespace FlightProject2129
{
    // Aayan Farooqui 101359123
    // Audrey Tjandra 101420460
    // Leonardo Pereira 101419551
    // Maria Sofronova 101062749


    public class Program
    {

        private static CustomerManager? custMan;
        private static FlightManager? flightMan;    
        private static BookingManager? bookingMan;

        public static void Main(string[] args)
        {

          
            //PLEASE CHANGE THIS TO YOUR LOCATION 
            string location = "C:\\Users\\maria\\Desktop\\T177\\Sem 3\\COMP2129\\FlightProject2129\\airplanetext.txt";

            
            
            try
            {
                Console.WriteLine("Previous Load: ");
                string fileContent = File.ReadAllText(location);
                Console.WriteLine(fileContent);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Couldn't find the file. It will load the file when you have information saved :)");

            
            // this creates new managers

            custMan = new CustomerManager(10);
            flightMan = new FlightManager(10);  
            bookingMan = new BookingManager(10);  

            AirlineCoordinator airCon = new AirlineCoordinator(custMan, flightMan, bookingMan);
         
            Menu.MainMenu(airCon);
             

            // this will use the save to disk to save the text information to location
            saveToDisk(location);
         
        }




        // save our information to text file
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

        // this will load it
        public static void loadToDisk(string location)
        {
            Customer[] customers = UtilityClass.loadCustomer(location);
           
            Console.WriteLine("Information loaded:");


        }


    }
}
