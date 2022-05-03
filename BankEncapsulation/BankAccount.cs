using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double cash)
        {
            if (cash <= 0)
            {
                Console.WriteLine("That is not a valid deposit. Please try again.");
            }
            else
            {
                _balance += cash;
                Console.WriteLine($"{cash.ToString("C")} has been deposited, and your balance is now {GetBalance().ToString("C")}");
            }
        }

        public void Withdrawal(double cash)
        {
            if (cash <= 0)
            {
                Console.WriteLine("That is not a valid withdrawal amount. Please start over.");
            }
            else if (cash > GetBalance())
            {
                Console.WriteLine($"I'm sorry, but you only have {GetBalance().ToString("C")} available for withdrawal today.");
            }
            else
            {
                _balance -= cash;
                Console.WriteLine($"Thank you for banking with Biggsby! Your balance is now {GetBalance().ToString("C")}");
            }
        }

        public double GetBalance()
        {
            return _balance;
        }

    }
}
