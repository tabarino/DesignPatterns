﻿using System;
using MementoPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Essentials();

            // Problem:
            // Need to restore an object back to its previous state (e.g. "undo" or "rollback" operations).
            MementoPattern.Demo.Show();
        }

        static void Essentials()
        {
            // Classes
            // var user = new User("Ivan");
            // user.SayHello();

            // Interfaces
            // ITaxCalculator calculator = new TaxCalculator2020();
            // var tax = calculator.CalculateTax();
            // Console.WriteLine($"Tax: {tax}");

            // First Principle of OOP -> Encapsulation
            // var account = new Account();
            // account.Deposit(10);
            // account.Withdraw(5);
            // Console.WriteLine($"Balance: {account.Balance}");

            // Second Principle of OOP -> Abstraction
            // var mailService = new MailService();
            // mailService.SendEmail();

            // Third Principle of OOP -> Inheritance
            // var textBox = new TextBox();
            // textBox.Enable();

            // Fourth Principle of OOP -> Polymorphism (Many Forms)
            _ = new DrawUIControl(new TextBox());
            _ = new DrawUIControl(new CheckBox());
        }
    }
}
