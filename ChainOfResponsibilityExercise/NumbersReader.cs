using System;

namespace ChainOfResponsibilityExercise
{
    public class NumbersReader : DataReader
    {
        protected override string GetExtension()
        {
            return ".numbers";
        }

        protected override void DoRead(string filename)
        {
            Console.WriteLine("Reading data from a Numbers spreadsheet.");
        }
    }
}
