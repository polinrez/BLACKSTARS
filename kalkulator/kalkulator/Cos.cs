using System;

namespace kalkulator
{
    public class Cos: IOneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}