using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class Flight 
    {
        private int numPassengers;
        private int maxSeats;
        private Customer[] passengerList;
        public int flightId;
        private string flightDest;
        private string flightOrigin;

        public Flight (int flightNum, string flightDest, string flightOrigin, int maxSeats)
        {
            this.flightId = flightNum;
            this.flightDest = flightDest;
            this.flightOrigin = flightOrigin;
            this.numPassengers = 0;
            this.maxSeats = maxSeats;
            passengerList = new Customer[maxSeats];


        }
        public int FlightNum { get { return flightId; } }
        public string FlightDest { get { return flightDest; } }
        public string FlightOrigin { get { return flightOrigin; } }
        public int NumPassengers { get { return numPassengers; } }
        public int MaxSeats { get { return maxSeats; } }

        public Customer[] Passengers { get { return passengerList; } }

        public bool addCustomer(Customer customer)
        {
            if (numPassengers < maxSeats)
            {
                passengerList[numPassengers] = customer;
                numPassengers++;
                return true;
            }
            else return false;
        }

        public string flightInfo()
        {
            string s = "\nFlight Number: " + flightId +
            "\nFlight Destination: " + flightDest +
            "\nFlight Origin: " + flightOrigin;
            return s;
        }

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
