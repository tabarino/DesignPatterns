using System;

namespace DesignPatterns
{
    public class TaxCalculator2019 : ITaxCalculator
    {
        public float CalculateTax()
        {
            Console.WriteLine("Calculate Tax 2019");

            return 1;
        }
    }
}
