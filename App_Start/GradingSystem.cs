using System;

namespace B2
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0 || amount > 1000)
                return false;

            Balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                return false;

            if (amount > Balance)
                return false;

            Balance -= amount;
            return true;
        }

        public decimal ShowBalance()
        {
            return Balance;
        }
    }
}
