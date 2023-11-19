using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//All functions that print to console go here. The only class this interacts with is the Airline Coordinator

//all add and delete class methods which are boolean also have an out string, error, you must print those errors 

namespace FlightProject2129
{
    internal static class Menu
    {
        
        public static void MainMenu(AirlineCoordinator airCon)
        {
            Console.WriteLine("Welcome to XYZ Airlines Limited");
            //I don't mind a bonus mark for the wonderful plane ;)
            string s = @"


                                                     ##
                                                   ####                             ##
                                                #######                           ####  
                                               ########                         #####
                                   _______rrrrrrrrrrrrrrrrrr_________         ###### 
                                ############################### ###################
                            ######################################################
                           /      )##########( )####( )####( )####( )#############
                            ##############\\#####################################
                             ---/////////// \\#####\\##\\///////////////---\\#####\
                                              \\####\\##\\                    \\###\
                                                \\###\\#\\                      \\#\
                                                   \\#\\#\


            ";
            Console.WriteLine(s);
            char c;
            do
            {

                Console.WriteLine("\nPlease select a choice from the menu below:");
                Console.WriteLine("");
                Console.WriteLine("1: Customers");
                Console.WriteLine("2: Flights");
                Console.WriteLine("3: Bookings");
                Console.WriteLine("4: Exit");

                c = Console.ReadKey().KeyChar;
                Console.WriteLine("");


                switch (c)
                {
                    case '1':
                        CustomerMenu(airCon); break;
                    case '2':
                        FlightMenu(airCon); break;
                    case '3':
                        BookingMenu(airCon); break;
                    case '4':
                        Console.WriteLine("Thank you for using XYZ Airlines. Have a wonderful day!");
                        Console.WriteLine(s);
                        break;
                    default: Console.WriteLine("Incorrect input, please try again."); break;

                }
            }
            while (!c.Equals('4'));
            




        }
        public static void CustomerMenu(AirlineCoordinator airCon)
        {
            char c;
            string fname;
            string lname;
            string phone;
            int index;
            string error;
            while(true)
            {
                Console.WriteLine("\n----------------Customer Menu---------------");
                Console.WriteLine("");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("");
                Console.WriteLine("1: Add Customer");
                Console.WriteLine("2: View Customers");
                Console.WriteLine("3: Delete Customer");
                Console.WriteLine("4: Return to main menu");

                c = Console.ReadKey().KeyChar;
                Console.WriteLine("");


                switch (c)
                {
                    case '1':
                        Console.WriteLine("Please enter the first name");
                        fname = getInput();
                        Console.WriteLine("Please enter the last name");
                        lname = getInput();
                        Console.WriteLine("Please enter the phone number in format: 'XXX-XXX-XXXX'");
                        phone = getPhoneInput();
                        if (airCon.addCustomer(fname, lname, phone, out error)) Console.WriteLine("Thank you for adding a new Customer");
                        else Console.WriteLine(error);
                         break;
                    case '2':
                        Console.WriteLine(airCon.CustomerManager); break;
                    case '3':
                        Console.WriteLine(airCon.CustomerManager);
                        Console.WriteLine("Please type the number of the customer you'd like to delete");
                        index = getValidIndexInput(airCon.CustomerManager.NumCustomers);
                        if (airCon.deleteCustomer(index, out error)) Console.WriteLine("Customer has been removed");
                        else Console.WriteLine(error);
                        
                        break;
                    case '4':
                        return;
                    default: Console.WriteLine("Incorrect input, please try again."); break;

                }
            }
            


        }
        public static void FlightMenu(AirlineCoordinator airCon)
        {
            //wait until you have Flight and FLightManager Finalized to edit
            char c;
            int fnum;
            string org;
            string dest;
            int maxseats;
            int index;
            string error;
            while (true)
            {
                Console.WriteLine("\n----------------Flight Menu---------------");
                Console.WriteLine("");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("");
                Console.WriteLine("1: Add Flight");
                Console.WriteLine("2: View Flights");
                Console.WriteLine("3: View a particular Flight");
                Console.WriteLine("4: Delete Flight");
                Console.WriteLine("5: Return to main menu");

                c = Console.ReadKey().KeyChar;
                Console.WriteLine("");


                switch (c)
                {
                    case '1':
                        Console.WriteLine("Please enter the flight number");
                        fnum = getIntInput();
                        Console.WriteLine("Please enter the origin of the flight");
                        org = getInput();
                        Console.WriteLine("Please enter the destination of the flight");
                        dest = getInput();
                        Console.WriteLine("Please enter the maximum seats on this flight");
                        maxseats = getIntInput();
                        if (airCon.addFlight(fnum, dest, org, maxseats, out error)) Console.WriteLine("Thank you for adding a new Flight");
                        else Console.WriteLine(error);
                        break;
                    case '2':
                        Console.WriteLine(airCon.FlightManager); break;
                    case '3':
                        Console.WriteLine("Please enter the flight number");
                        fnum = getIntInput();
                        Console.WriteLine(airCon.FlightManager.viewParticularFlight(fnum));

                        break;
                    case '4':
                        Console.WriteLine(airCon.FlightManager); 
                        Console.WriteLine("Please type the number of the flight you'd like to delete");
                        index = getValidIndexInput(airCon.FlightManager.NumFlights);
                        if (airCon.deleteCustomer(index, out error)) Console.WriteLine("Flight has been removed");
                        else Console.WriteLine(error);
                        break;
                    case '5':
                        return;
                    default: Console.WriteLine("Incorrect input, please try again."); break;

                }
            }



        }
        public static void BookingMenu(AirlineCoordinator airCon)
        {
            char c;
            string error;
            int cindex;
            int findex;
            while (true) { 

            Console.WriteLine("\n----------------Booking Menu---------------");
            Console.WriteLine("");
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("");
            Console.WriteLine("1: Add Booking");
            Console.WriteLine("2: View Booking");
            Console.WriteLine("3: Return to main menu");

            c = Console.ReadKey().KeyChar;
            Console.WriteLine("");

                switch (c)
                {
                    case '1':
                        if (airCon.CustomerManager.NumCustomers == 0 || airCon.FlightManager.NumFlights == 0)
                        {
                            Console.WriteLine("Can't making a booking without both existing Customers and Flights");
                            continue;
                        }
                        Console.WriteLine(airCon.CustomerManager);
                        Console.WriteLine("Please type the number of the customer making the booking");
                        cindex = getValidIndexInput(airCon.CustomerManager.NumCustomers);
                        Console.WriteLine(airCon.FlightManager);
                        Console.WriteLine("Please type the number of the flight you'd like to add");
                        findex = getValidIndexInput(airCon.FlightManager.NumFlights);
                        if (airCon.BookingManager.addBooking(airCon.CustomerManager.getCustomer(cindex), airCon.FlightManager.getFlight(findex), out error))
                        { Console.WriteLine("Added Booking"); }
                        else Console.WriteLine(error);
                        break;
                    case '2':
                        Console.WriteLine(airCon.BookingManager); break;
                    case '3':
                        return; break;
                    default: Console.WriteLine("Incorrect input, please try again."); break;
                }
            }

        }
        public static string getInput()
        {
            string input;
            while (true)
            {
                input = Console.ReadLine();
                //only thing it checks for is whether there is an input
                if (!string.IsNullOrEmpty(input))
                {
                    //Console.WriteLine("\n");
                    return input; 
                }
            }
        }
        public static int getIntInput()
        {
            int num;
            string input;
            while (true)
            {
                input=getInput();
                if (!Int32.TryParse(input, out num))
                {
                    Console.WriteLine("Not a number, try again.");
                }
                else if (num <= 0)
                {
                    Console.WriteLine("Please put a positive number, try again");
                }
                else                
                    return num;
            }
        }



        public static int getValidIndexInput(int arrlength)
        {
            int num;
            string input;
            while (true)
            {
                num = getIntInput();
                if (num > arrlength)
                {
                    Console.WriteLine("Number not in list bounds, try again");
                }
                else
                    //reduces because list starts from 1, but real index will start from 0
                    return num - 1;
            
            }
           
        }

        public static string getPhoneInput()
        {
            string input;
            string phonePattern = @"([0-9]{3})-([0-9]{3})-([0-9]{4})";
            Regex phone = new Regex(phonePattern);
            while (true) {
                input = getInput();
                Match match = phone.Match(input);
                if (match.Success)
                {
                    return input;

                }
                else
                {
                    Console.WriteLine("Invalid Phone Number");
                }
            }

        }

    }
}
