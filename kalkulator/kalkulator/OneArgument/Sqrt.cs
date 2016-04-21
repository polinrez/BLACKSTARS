using System;

namespace kalkulator.OneArgument
{
    public class Sqrt: IOneCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Корень из отрицательного");
            }
            return Math.Sqrt(firstArgument);
        }
    }
}