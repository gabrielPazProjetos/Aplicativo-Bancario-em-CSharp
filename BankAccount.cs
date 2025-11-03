using System;

namespace Classes_M2
{
    public class BankAccount
    {
        // Static field to generate unique account numbers
        private static int s_nextAccountNumber;

        // Static interest rate shared across all accounts
        public static double InterestRate;

        // Read-only properties
        public int AccountNumber { get; }
        public string CustomerId { get; }

        // Encapsulated balance with private setter
        public double Balance { get; private set; } = 0;

        // Account type is publicly readable and writable
        public string AccountType { get; set; } = "Checking";

        // Static constructor initializes account number and interest rate
        static BankAccount()
        {
            Random random = new Random();
            s_nextAccountNumber = random.Next(10000000, 20000000);
            InterestRate = 0;
        }

        // Constructor for basic account
        public BankAccount(string customerIdNumber)
        {
            AccountNumber = s_nextAccountNumber++;
            CustomerId = customerIdNumber;
        }

        // Constructor with initial balance and account type
        public BankAccount(string customerIdNumber, double balance, string accountType)
        {
            AccountNumber = s_nextAccountNumber++;
            CustomerId = customerIdNumber;
            Balance = balance;
            AccountType = accountType;
        }

        // Deposits money into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        // Withdraws money from the account
        public bool Withdraw(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        // Transfers money to another account
        public bool Transfer(BankAccount targetAccount, double amount)
        {
            if (Withdraw(amount))
            {
                targetAccount.Deposit(amount);
                return true;
            }
            return false;
        }

        // Applies interest to the account balance
        public void ApplyInterest()
        {
            Balance += Balance * InterestRate;
        }

        // Displays account information
        public string DisplayAccountInfo()
        {
            return $"Account Number: {AccountNumber}, Type: {AccountType}, Balance: {Balance}, Interest Rate: {InterestRate}, Customer ID: {CustomerId}";
        }
    }
}
