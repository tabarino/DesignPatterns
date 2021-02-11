using System;
using MementoPattern;
using MementoExercise;
using StatePattern;
using StateExercise;
using IteratorPattern;
using IteratorPatternMadeSimple;
using IteratorExercise;
using StrategyPattern;
using StrategyPatternWithDelegates;
using StrategyExercise;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Essentials();

            // Memento();
            
            // State();

            // Iterator();
            
            Strategy();
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

        static void Memento()
        {
            // Memento
            // Also known as: Snapshot
            // Memento is a behavioral design pattern that lets you save and restore the previous
            // state of an object without revealing the details of its implementation.
            // Problem:
            // Need to restore an object back to its previous state (e.g. "undo" or "rollback" operations).
            MementoPattern.Demo.Show();
            MementoExercise.Demo.Show();
        }

        static void State()
        {
            // State
            // State is a behavioral design pattern that lets an object alter its behavior 
            // when its internal state changes. It appears as if the object changed its class.
            // Problem:
            // A monolithic object's behavior is a function of its state, 
            // and it must change its behavior at run-time depending on that state. 
            // Or, an application is characterized by large and numerous case statements that
            // vector flow of control based on the state of the application.
            StatePattern.Demo.Show();
            StateExercise.Demo.Show();
        }

        static void Iterator()
        {
            // Iterator
            // Iterator is a behavioral design pattern that lets you traverse elements of a collection
            // without exposing its underlying representation (list, stack, tree, etc.).
            // Problem:
            // Need to "abstract" the traversal of wildly different data structures so that algorithms
            // can be defined that are capable of interfacing with each transparently.
            IteratorPattern.Demo.Show();
            IteratorPatternMadeSimple.Demo.Show();
            IteratorExercise.Demo.Show();
        }

        static void Strategy()
        {
            // Strategy
            // Strategy is a behavioral design pattern that lets you define a family of algorithms,
            // put each of them into a separate class, and make their objects interchangeable.
            // Problem:
            // One of the dominant strategies of object-oriented design is the "open-closed principle"
            // So, you need to program to an interface, not an implementation
            // StrategyPattern.Demo.Show();
            // StrategyPatternWithDelegates.Demo.Show();
            StrategyExercise.Demo.Show();
        }
    }
}
