// See https://aka.ms/new-console-template for more information

using System;
namespace FlightProject2129
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomerManager custMan = new CustomerManager(10);
            FlightManager flightMan = new FlightManager(10);
            BookingManager bookMan= new BookingManager(10);
            AirlineCoordinator airCon = new AirlineCoordinator(custMan, flightMan, bookMan);
            Menu.MainMenu(airCon);

        }

       
    }
}
