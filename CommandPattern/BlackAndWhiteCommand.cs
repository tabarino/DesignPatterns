using System;
using CommandPattern.Fx;

namespace CommandPattern
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black and White");
        }
    }
}
