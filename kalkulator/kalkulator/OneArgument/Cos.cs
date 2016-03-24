using System;

namespace kalkulator.OneArgument
{
    public class Cos: IOneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}