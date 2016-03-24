using System;

namespace kalkulator
{
    public class Ln: IOneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}