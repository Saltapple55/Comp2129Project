using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class FlightManager
    {
        private int numFlights;
        private int maxFlights;
        private Flight[] flightList;


        public FlightManager(int maxFlights)
        {
            this.numFlights = 0;
            this.maxFlights = maxFlights;
            this.flightList = new Flight[maxFlights];

        }

        public int NumFlights { get { return numFlights; } }

        public bool addFlight(int flightNum, string flightDest, string flightOrigin, int maxSeats)
        {
            if (!flightExists(flightNum))
            {
                flightList[numFlights] = new Flight(flightNum, flightDest, flightOrigin, maxSeats);
                numFlights++;
                return true;
            }
            return false;
        }

        public string viewFlights(int flightNum, string flightDest, string flightOrigin)
        {
           
                string s = "Flight Number: " + flightNum +
                            "Flight Destination: " + flightDest +
                            "Flight Origin: " + flightOrigin;
                return s;
            
            return null;
        }

        public bool flightExists(int flightNum)
        {
            for (int i = 0; i < numFlights; i++) 
            {
                if (flightList[i].flightId == flightNum)
                {
                    return true;
                }
            }
            return false;
        }

        public string viewParticularFlight()
        {
            string s = "";
            return s;
        }

        public bool removeFlight(int flightNum)
        {
            if (flightExists(flightNum))
            {

                flightList[numFlights] = null;
                numFlights--;
                return true;

            }
            return false;
        }

        public string ToString()
        {
            string s = "";
            return s;
        }

    }
}
