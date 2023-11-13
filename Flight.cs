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
        public int flightId;
        private string flightDest;
        private string flightOrigin;

        public Flight (int flightNum, string flightDest, string flightOrigin)
        {
            this.flightId = flightNum;
            this.flightDest = flightDest;
            this.flightOrigin = flightOrigin;
        }

        public int getFlightNum()
        {
            return flightId;
        }

        public string getFlightDest()
        {
            return flightDest;
        }

        public string getOrigin()
        {
            return flightOrigin;
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
