using System;

namespace ChainOfResponsibilityExercise
{
    public class DataReaderFactory
    {
        public static DataReader GetDataReaderChain()
        {
            var excelReader = new ExcelReader();
            var numbersReader = new NumbersReader();
            var quickBooksReader = new QuickBooksReader();

            quickBooksReader.SetNext(numbersReader);
            numbersReader.SetNext(excelReader);

            return quickBooksReader;
        }
    }
}
