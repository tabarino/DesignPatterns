using System;

namespace DesignPatterns
{
    public class TaxCalculator2020 : ITaxCalculator
    {
        public float CalculateTax()
        {
            Console.WriteLine("Calculate Tax 2020");

            return 2;
        }
    }
}
