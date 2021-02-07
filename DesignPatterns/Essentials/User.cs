using System;

namespace DesignPatterns
{
    public class User
    {
        // Fields (Attributes)
        public string Name;

        // Constructor
        public User(string name)
        {
            this.Name = name;
        }

        // Methods
        public void SayHello()
        {
            Console.WriteLine($"Hi, my name is {this.Name}");
        }
    }
}
