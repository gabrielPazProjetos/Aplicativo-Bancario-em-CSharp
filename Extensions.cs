using System;

namespace Classes_M2
{
    public static class BankCustomerExtensions
    {
        // Checks if the customer ID is valid (10 digits)
        public static bool IsValidCustomerId(this BankCustomer customer)
        {
            return customer.CustomerId.Length == 10;
        }

        // Returns a greeting message for the customer
        public static string GreetCustomer(this BankCustomer customer)
        {
            return $"Hello, {customer.ReturnFullName()}!";
        }
    }

    public static class BankAccountExtensions
    {
        // Checks if the account is overdrawn
        public static bool IsOverdrawn(this BankAccount account)
        {
            return account.Balance < 0;
        }

        // Checks if a specific amount can be withdrawn
        public static bool CanWithdraw(this BankAccount account, double amount)
        {
            return account.Balance >= amount;
        }
    }
}
