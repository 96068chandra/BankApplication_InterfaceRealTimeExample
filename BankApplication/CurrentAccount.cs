using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class CurrentAccount : IBankAccount
    {
        private decimal balance;

        public decimal CheckBalance()
        {
           return balance;
        }

        public bool DepositAmount(decimal amount)
        {
            balance=balance+amount;
            Console.WriteLine($"You have Deposited: {amount}");
            Console.WriteLine($"Your Account Balance: {balance}");
            return true;
        }

        public bool WithdrawAmount(decimal amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Insufficient Balance");
                return false;
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"You have Successfully Withdraw: {amount}");
                Console.WriteLine($"Your Account Balance: {balance}");
                return true;
            }
        }
    }
}
