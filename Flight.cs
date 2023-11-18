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
            if()
            if (numPassengers < maxSeats)
            {
                passengerList[numPassengers] = customer;
                numPassengers++;
                return true;
            }
            else return false;
        }
        


        public override string ToString()
        {
            string s = "Flight Number: " + flightId +
                        "Flight Destination: " + flightDest +
                        "Flight Origin: " + flightOrigin;
            return s;
        }
        
    }
}
