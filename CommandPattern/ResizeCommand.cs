using System;
using CommandPattern.Fx;

namespace CommandPattern
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }
}
