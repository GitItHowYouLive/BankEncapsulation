using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user!");
            var userAccount = new BankAccount();

            bool workToDo = true;

            while (workToDo)
            {
                Console.WriteLine("\nWhat would you like to do today?");
                Console.WriteLine("Please choose 'deposit', 'withdrawal', 'balance', or 'exit'");
                var choice = Console.ReadLine().ToLower().Trim();

                switch (choice)
                {
                    case "deposit":
                        Console.WriteLine("How much would you like to deposit today?");
                        double.TryParse(Console.ReadLine().Trim(), out var amount);

                        if (amount <= 0)
                        {
                            Console.WriteLine("That is not a valid deposit. Please start over.");
                        } 
                        else
                        {
                            userAccount.Deposit(amount);
                            Console.WriteLine($"{amount.ToString("C")} has been deposited, and your balance is now {userAccount.GetBalance().ToString("C")}");
                        }
                        break;

                    case "withdrawal":
                        Console.WriteLine("How much would you like to withdraw?");
                        double.TryParse(Console.ReadLine().Trim(), out var outage);

                        if (outage <= 0)
                        {
                            Console.WriteLine("That is not a valid withdrawal amount. Please start over.");
                        }
                        else if (outage > userAccount.GetBalance())
                        {
                            Console.WriteLine($"I'm sorry, but you only have {userAccount.GetBalance().ToString("C")} available for withdrawal today.");
                        }
                        else
                        {
                            userAccount.Withdrawal(outage);
                            Console.WriteLine($"Thank you for banking with Biggsby! Your balance is now {userAccount.GetBalance().ToString("C")}");
                        }
                        break;

                    case "balance":
                        Console.WriteLine($"\nYour balance is {userAccount.GetBalance().ToString("C")}");
                        break;

                    case "exit":
                        workToDo = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Input not recognized. Please try again.");
                        break;
                }
            }
        }
    }
}
