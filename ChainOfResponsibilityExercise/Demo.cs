using System;

namespace ChainOfResponsibilityExercise
{
    public class Demo
    {
        public static void Show()
        {
            var reader = DataReaderFactory.GetDataReaderChain();
            reader.Read("data.xls");
            reader.Read("data.numbers");
            reader.Read("data.qbw");
            reader.Read("data.jpg");
        }
    }
}
