using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class Flight 
    {
        // Attributes
        private int numPassengers;
        private int maxSeats;
        private Customer[] passengerList;
        public int flightId;
        private string flightDest;
        private string flightOrigin;

        // Constructor
        public Flight (int flightNum, string flightDest, string flightOrigin, int maxSeats)
        {
            this.flightId = flightNum;
            this.flightDest = flightDest;
            this.flightOrigin = flightOrigin;
            this.numPassengers = 0;
            this.maxSeats = maxSeats;
            passengerList = new Customer[maxSeats];


        }

        // getters and setters
        public int FlightNum { get { return flightId; } }
        public string FlightDest { get { return flightDest; } }
        public string FlightOrigin { get { return flightOrigin; } }
        public int NumPassengers { get { return numPassengers; } }
        public int MaxSeats { get { return maxSeats; } }

        public Customer[] Passengers { get { return passengerList; } }

        // Method to add customer
        public bool addCustomer(Customer customer)
        {
            if (numPassengers < maxSeats)
            {
                passengerList[numPassengers] = customer;
                numPassengers++; // increments number of passengers each time a passenger is added
                return true;
            }
            else return false;
        }

        // Method for flight information
        public string flightInfo()
        {
            string s = "\nFlight Number: " + flightId +
            "\nFlight Destination: " + flightDest +
            "\nFlight Origin: " + flightOrigin;
            return s;
        }

        // Tostring method
        public override string ToString()
        {
            string s = $"------------Flight--------------"+
                         "\nFlight Number: " + flightId +
                        "\nFlight Destination: " + flightDest +
                        "\nFlight Origin: " + flightOrigin +
                        "\nNumber of Passengers: " + numPassengers +
                        "\nMaximum Passengers: " + maxSeats +
                        $"\n------Customers in Flight {flightId}------\n";
            if (numPassengers == 0)
            {
                s = s + "There are no Customers in the Flight";
            }
            else
            {
                for (int i = 0; i < numPassengers; i++)
                {
                    s = s + $"{i + 1}. {passengerList[i].ToString()}";
                    s = s + "\n -------------------------------\n";
                }
            }
            return s;
        }
        
    }
}
