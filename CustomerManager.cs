using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject2129
{
    internal class CustomerManager
    {
        private int numCustomers;
        private int maxCustomers;
        private Customer[] customerList;

        //override Constructor t
        //d://reative address
        public CustomerManager(string location)
        {
            //load from file
        }
        public CustomerManager(int max) //constructor
        {
            maxCustomers = max;
            numCustomers = 0;
            customerList = new Customer[max]; //customer list array 
        }
        public Customer[] getCustomerList() //getters
        {
            return customerList; 
        }
        
        public int NumCustomers
        {
            get { return numCustomers; }
        }
        public Customer getCustomer(int index)
        {
            return customerList[index];
        }

        public bool addCustomer(string fname, string lname, string phoneNum, out string error)
        {

            if (numCustomers < maxCustomers && !checkCustomerExists(fname, lname, phoneNum)) //checks if there is space
            {
                Customer c = new Customer(fname, lname, phoneNum); //creating customer object with attributes
                customerList[numCustomers] = c; //adding new customer into array
                numCustomers++; //incremeting so it can loop back to create new customers until there is no more space
                error = "";
                return true;
            }
            if (checkCustomerExists(fname, lname, phoneNum))
            {
                error = "Customer already exists";

            }
            else
                error = "Cannot add any new Customers";
            return false; //once it is full
        }
      
        public Customer viewCustomer(string custFname, string custLname, string phoneNum)
        {
            for (int i = 0; i < numCustomers; i++) //goes through the customers 
            {
                if (customerList[i].FirstName == custFname && customerList[i].LastName == custLname &&
                    customerList[i].PhoneNum == phoneNum)
                    //if customer first name, last name and phone number matches (customer exists), returns customer
                {
                    return customerList[i];
                }
            }
            return null; //else if the customer doesn't match returns null

        }

        private bool checkCustomerExists(string custFname, string custLName, string phoneNum)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                //checking if customer exists, so if customer first name, last name and phone # matches
                if (customerList[i].FirstName == custFname && customerList[i].LastName == custLName &&
                    customerList[i].PhoneNum == phoneNum)
                {
                    return true; //this means that customer has a duplicate
                }
            }
            return false; //this means customer is not duplicate
        }

        public bool removeCustomer(int index, out string error)
        {
            if (customerList[index].NumBookings > 0) //if the customer exists in the array and have a booking (index is greater than 0)
            { //cannot remove customer as can't delete a customer if they have a booking 
                error = "Customer could not be deleted because they have already made bookings";
                return false;

            }
            else
            {
                //next two lines moves customer from back of array to where customer was removed, and empties old spot
                customerList[index] = customerList[numCustomers - 1];
                customerList[numCustomers - 1] = null;
                numCustomers--;
                error = "";
                return true;
            }
            //redundancy failsafe-should never trigger because because getValidIndex() will never give anything >=numCustomers
        }


        public override string ToString()
        {
            if (numCustomers == 0)
            {
                return "There are currently no customers";

            }
            string s = "------------Customer List-------------\n";
            for (int i = 0; i < numCustomers; i++)
            {
                s = s + $"{i + 1}. {customerList[i].ToString()}";
                s = s + "\n -------------------------------\n";
            }
            return s;
        }
    }
}
