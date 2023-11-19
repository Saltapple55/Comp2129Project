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

        public bool addFlight(int flightNum, string flightDest, string flightOrigin, int maxSeats, out string error)
        {
            if (!flightExists(flightNum))
            {
                flightList[numFlights] = new Flight(flightNum, flightDest, flightOrigin, maxSeats);
                numFlights++;
                error = "";
                return true;
            }
            error = "Flight number already exists";
            return false;
        }
        public Flight getFlight(int index)
        {
            return flightList[index];
        }/*
        public string viewFlights(int flightNum, string flightDest, string flightOrigin)
        {
            
           
                string s = "Flight Number: " + flightNum +
                            "Flight Destination: " + flightDest +
                            "Flight Origin: " + flightOrigin;
                return s;
            
        }*/

        private bool flightExists(int flightNum)
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

        public string viewParticularFlight(int flightNum)
        {
            for (int i = 0; i<numFlights; i++)
            {
                if (flightList[i].FlightNum == flightNum)
                    return flightList[i].ToString();
            }
            return "Flight does not exist";
        }

        public bool removeFlight(int index, out string error)
        {

            if (flightList[index].NumPassengers > 0)
            {
                error = "Flight cannot be deleted because Customers have already booked it";
                return false;
            }
           
            flightList[index] = flightList[numFlights-1];
            flightList[numFlights-1]= null;
            numFlights--;
            error = "";
            return true;

            
        }

        public override string ToString()
        {
            if (numFlights == 0)
            {
                return "There are currently no flights";
            }
            string s = "------------Flight List-------------\n";
            for (int i = 0; i < numFlights; i++)
            {
                s = s + $"{i + 1}. {flightList[i].flightInfo()}";
                s = s + "\n -------------------------------\n";
            }
            return s;
        }

    }
}
