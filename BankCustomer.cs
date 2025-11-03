using System;

namespace Classes_M2
{
    public class BankCustomer
    {
        // Static field to generate unique customer IDs
        private static int s_nextCustomerId;

        // Private fields for customer name
        private string _firstName = "Tim";
        private string _lastName = "Shao";

        // Read-only property for customer ID
        public readonly string CustomerId;

        // Public properties for first and last name
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        // Static constructor initializes the starting customer ID
        static BankCustomer()
        {
            Random random = new Random();
            s_nextCustomerId = random.Next(10000000, 20000000);
        }

        // Constructor assigns name and generates unique customer ID
        public BankCustomer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerId = (s_nextCustomerId++).ToString("D10");
        }

        // Returns the full name of the customer
        public string ReturnFullName()
        {
            return $"{FirstName} {LastName}";
        }

        // Updates the customer's name
        public void UpdateName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Displays customer information
        public string DisplayCustomerInfo()
        {
            return $"Customer ID: {CustomerId}, Name: {ReturnFullName()}";
        }
    }
}
