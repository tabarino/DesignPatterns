using System;

namespace ChainOfResponsibilityExercise
{
    public class QuickBooksReader : DataReader
    {
        protected override string GetExtension()
        {
            return ".qbw";
        }

        protected override void DoRead(string filename)
        {
            Console.WriteLine("Reading data from a QuickBooks file.");
        }
    }
}
