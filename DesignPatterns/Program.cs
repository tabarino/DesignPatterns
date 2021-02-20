using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Essentials();

            BehavioralPatterns();
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

        static void BehavioralPatterns()
        {
            // In software engineering, behavioral design patterns are design patterns
            // that identify common communication patterns between objects and realize these patterns.
            // By doing so, these patterns increase flexibility in carrying out this communication.

            // Memento();

            // State();

            // Iterator();

            // Strategy();

            // Template();

            // Command();

            // Observer();

            // Mediator();

            ChainOfResponsibility();
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
            StrategyPattern.Demo.Show();
            StrategyPatternWithDelegates.Demo.Show();
            StrategyExercise.Demo.Show();
        }

        static void Template()
        {
            // Template Method
            // Template Method is a behavioral design pattern that defines the skeleton of an algorithm in the
            // superclass but lets subclasses override specific steps of the algorithm without changing its structure.
            // Problem:
            // Two different components have significant similarities, but demonstrate no reuse of 
            // common interface or implementation. If a change common to both components becomes necessary,
            // duplicate effort must be expended.
            TemplatePattern.Demo.Show();
            TemplateExercise.Demo.Show();
        }

        static void Command()
        {
            // Command Pattern
            // Also known as: Action, Transaction
            // Command is a behavioral design pattern that turns a request into a stand-alone object
            // that contains all information about the request. This transformation lets you parameterize
            // methods with different requests, delay or queue a request’s execution, and support undoable operations.
            // Problem:
            // Need to issue requests to objects without knowing anything about
            // the operation being requested or the receiver of the request.
            CommandPattern.Demo.Show();
            CommandExercise.Demo.Show();
        }

        static void Observer()
        {
            // Observer Pattern
            // Also known as: Event-Subscriber, Listener
            // Observer is a behavioral design pattern that lets you define a subscription mechanism
            // to notify multiple objects about any events that happen to the object they’re observing.
            // Problem:
            // A large monolithic design does not scale well as new graphing or monitoring requirements are levied.
            ObserverPattern.Demo.Show();
            ObserverPatternUsingEventsAndDelegates.Demo.Show();
            ObserverExercise.Demo.Show();
        }

        static void Mediator()
        {
            // Mediator Pattern
            // Also known as: Intermediary, Controller
            // Mediator is a behavioral design pattern that lets you reduce chaotic dependencies between objects.
            // The pattern restricts direct communications between the objects and forces them
            // to collaborate only via a mediator object.
            // Problem:
            // We want to design reusable components, but dependencies between the potentially reusable pieces
            // demonstrates the "spaghetti code" phenomenon
            // (trying to scoop a single serving results in an "all or nothing clump").
            MediatorPattern.Demo.Show();
            MediatorPatternUsingObservers.Demo.Show();
            MediatorPatternUsingEventsAndDelegates.Demo.Show();
            MediatorExercise.Demo.Show();
        }

        static void ChainOfResponsibility()
        {
            // Chain of Responsibility Pattern;
            // Also known as: CoR, Chain of Command
            // Chain of Responsibility is a behavioral design pattern that lets you pass requests along
            // a chain of handlers. Upon receiving a request, each handler decides either to process the request
            // or to pass it to the next handler in the chain.
            // Problem:
            // There is a potentially variable number of "handler" or "processing element" or "node" objects,
            // and a stream of requests that must be handled. Need to efficiently process the requests
            // without hard-wiring handler relationships and precedence, or request-to-handler mappings.
            // ChainOfResponsibilityPattern.Demo.Show();
            ChainOfResponsibilityExercise.Demo.Show();
        }
    }
}
