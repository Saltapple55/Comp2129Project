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
        //remember to make custID read from file when you learn how
        private static int custIDGenerator=0;
        private int custID;

        private string custFName;
        private string custLName;
        private string phoneNum;
        private int numBookings;

        public static void getCustIDgenerator(int num)
        {
            custIDGenerator = num;
        }
        public Customer( string firstName, string lastName, string phoneNum)
        {
            custID = ++custIDGenerator;
            custFName = firstName;
            custLName = lastName;
            this.phoneNum = phoneNum;
            numBookings = 0;
            
        }

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

        public  int NumBookings
        {
            get { return numBookings; }
        }
        public void increaseNumBooking()
        {
            numBookings++;
        }
        public override string ToString()
        {
            string s = "\nFirst Name: " + custFName;
            s = s + "\nLast Name: " + custLName;
            s = s + "\nPhone Number: " + phoneNum;
            return s;
        }


    }


}
