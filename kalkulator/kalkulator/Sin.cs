using System;

namespace kalkulator
{
    public class Sin: IOneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}