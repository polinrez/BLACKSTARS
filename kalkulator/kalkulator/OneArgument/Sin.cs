using System;

namespace kalkulator.OneArgument
{
    public class Sin: IOneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}