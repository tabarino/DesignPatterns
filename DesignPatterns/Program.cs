using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Essential();
        }

        static void Essential()
        {
            // Classes
            // var user = new User("Ivan");
            // user.SayHello();

            // Interfaces
            // ITaxCalculator calculator = new TaxCalculator2020();
            // var tax = calculator.CalculateTax();
            // Console.WriteLine($"Tax: {tax}");

            // Encapsulation
            // var account = new Account();
            // account.Deposit(10);
            // account.Withdraw(5);
            // Console.WriteLine($"Balance: {account.Balance}");

            // Abstraction
            var mailService = new MailService();
            mailService.SendEmail();
        }
    }
}
