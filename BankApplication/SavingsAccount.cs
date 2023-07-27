using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class SavingsAccount : IBankAccount
    {
        private decimal Balance = 0;
        private readonly decimal PerDayWithdrawLimit = 10000;
        private decimal TodayWithdrawal = 0;
        public decimal CheckBalance()
        {
            return Balance;
           
        }

        public bool DepositAmount(decimal Amount)
        {
            Balance += Amount;
            Console.WriteLine($"You have Deposited: {Amount}");
            Console.WriteLine($"Your Account Balance: {Balance}");
            return true;
        }

        public bool WithdrawAmount(decimal amount)
        {
            if(Balance < amount)
            {
                Console.WriteLine("Insufficient Balance");
                return false;
            }
            else if(TodayWithdrawal+amount>PerDayWithdrawLimit)
            {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;

            }
            else
            {
                Balance -= amount;
                TodayWithdrawal += amount;
                Console.WriteLine($"You have Successfully Withdraw: {amount}");
                Console.WriteLine($"Your Account Balance: {Balance}");
                return true;

            }
        }
    }
}
