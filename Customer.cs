using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class Customer
    {
        private static int custIDGenerator = 0;
        private int custID;

        private string custFName;
        private string custLName;
        private string phoneNum;
        private int numBookings;

        public static void getCustIDgenerator(int num)
        {
            custIDGenerator = num;
        }
        public Customer(string firstName, string lastName, string phoneNum)
        {
            custID = ++custIDGenerator; //id generator 
            custFName = firstName;
            custLName = lastName;
            this.phoneNum = phoneNum;
            numBookings = 0;

        }
        //getters
        public int CustID 
        {
            get { return custID; }
        }
        public string FirstName
        {
            get { return custFName; }
        }
        public string LastName
        {
            get { return custLName; }
        }
        public string PhoneNum
        {
            get { return phoneNum; }
        }

        public int NumBookings
        {
            get { return numBookings; }
        }
        public void increaseNumBooking() //increases bookings
        {
            numBookings++; 
        } 
        public override string ToString()
        {
            string s = custFName;
            s = s + " " + custLName;
            s = s + " " + phoneNum;
            return s;
        }


    }


}
