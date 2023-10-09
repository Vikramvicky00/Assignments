using System;

namespace Assignments.interfaceAssignments
{
    public class Customer
    {
        static int custId=100;
        public Customer() 
        {
            custId += 1;
        }  
        public int CustomerId
        {
            get { return custId; }
        }

        private string CustName;
        public string CustomerName
        {
            get { return CustName; }
            set { CustName = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }


    }
}
