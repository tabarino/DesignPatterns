using System;

namespace PrototypePatternWithICloneable
{
    public class Demo
    {
        public static void Show()
        {
            // Create an instance of Person and assign values to its fields.
            Person p1 = new Person();
            p1.Age = 42;
            p1.Name = "Sam";
            p1.IdInfo = new IdInfo(6565);
            p1.Address = new Address("11, Test Street", "1111");

            // Perform a shallow copy of p1 and assign it to p2.
            var p2 = (Person)p1.ShallowClone();

            // Display values of p1, p2
            Console.WriteLine("Original values of p1 and p2:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // Change the value of p1 properties and display the values of p1 and p2.
            p1.Age = 32;
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            p1.Address = new Address("12, Test Street", "1212");
            Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // Make a deep copy of p1 and assign it to p3.
            var p3 = (Person)p1.Clone();
            // Change the members of the p1 class to new values to show the deep copy.
            p1.Name = "George";
            p1.Age = 39;
            p1.IdInfo.IdNumber = 8641;
            p1.Address = new Address("22, Test Street", "2222");
            Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person person)
        {
            Console.WriteLine($"      Name: {person.Name}, Age: {person.Age}");
            Console.WriteLine($"      Idnumber: {person.IdInfo.IdNumber}");
            Console.WriteLine($"      Address: {person.Address.Street} - {person.Address.PostCode}");
        }
    }
}
