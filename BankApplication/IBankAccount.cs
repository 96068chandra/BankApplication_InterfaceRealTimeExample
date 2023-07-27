using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal interface IBankAccount
    {
        bool DepositAmount(decimal amount);
        bool WithdrawAmount(decimal amount);
        decimal CheckBalance();
    }
}
