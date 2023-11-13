// See https://aka.ms/new-console-template for more information

using System;
namespace FlightProject2129
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu();


        }

        public static void Menu()
        {
            Console.WriteLine("Welcome to XYZ Airlines Limited");
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
            Console.WriteLine("Please select a choice from the menu below:");
            Console.WriteLine("");
            Console.WriteLine("1: Customers");
            Console.WriteLine("2: Flights");
            Console.WriteLine("3: Bookings");
            char c = Console.ReadKey().KeyChar;
            




        }
    }
}
