using System;

namespace ChainOfResponsibilityExercise
{
    public class ExcelReader : DataReader
    {
        protected override string GetExtension()
        {
            return ".xls";
        }

        protected override void DoRead(string filename)
        {
            Console.WriteLine("Reading data from an Excel spreadsheet.");
        }
    }
}
