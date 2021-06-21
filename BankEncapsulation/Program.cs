using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO add loop to return to first prompt if the user has not yet decided to quit bank app (bool)
            BankAccount checking = new BankAccount();
            Console.WriteLine("Welcome to your bank account!");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Current Balance");

            //bool yesOrNo;

            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 2)
            {
                Console.WriteLine("Invalid input, try again");
            }

            if (userInput == 1)
            {
                Console.WriteLine("How much money would you like to deposit today?");

                double depAmount;

                while (!double.TryParse(Console.ReadLine(), out depAmount))
                {
                    Console.WriteLine("Invalid input, try again");
                }

                checking.Deposit(depAmount);
                //added this line to confirm, can be refactored later to look cleaner
                Console.WriteLine($"Your current balance is {checking.GetBalance()}");
            }
            else if (userInput == 2)
            {
                Console.WriteLine($"Your current balance is {checking.GetBalance()}");
            }
        }

        //public static bool continueOrQuit(bool yesOrNo)
        //{
        //    Console.WriteLine("Did you need anything else today? Y/N");
        //    string userInput = Console.ReadLine();

        //    if (userInput == "Y")
        //    {
        //        return yesOrNo;
        //    }
        //    else if (userInput == "N")
        //    {
        //        return !yesOrNo;
        //    }
        //}
    }
}
