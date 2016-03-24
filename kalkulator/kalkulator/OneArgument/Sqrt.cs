using System;

namespace kalkulator.OneArgument
{
    public class Sqrt: IOneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}