using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount checking = new BankAccount();

            Console.WriteLine("Welcome to your bank account!");
            Console.WriteLine("How much money will you deposit?");

            double input = double.Parse(Console.ReadLine());

            checking.Deposit(input);

            Console.WriteLine($"Your new balance is {checking.GetBalance()}");


        }
    }
}
