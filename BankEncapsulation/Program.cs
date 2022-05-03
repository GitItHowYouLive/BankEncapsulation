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
                        userAccount.Deposit(amount);
                        break;

                    case "withdrawal":
                        Console.WriteLine("How much would you like to withdraw?");
                        double.TryParse(Console.ReadLine().Trim(), out var outage);
                        userAccount.Withdrawal(outage);
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
