using System;

namespace kalkulator.OneArgument
{
    public class Ln: IOneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}