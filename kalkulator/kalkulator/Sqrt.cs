using System;

namespace kalkulator
{
    public class Sqrt: IOneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}