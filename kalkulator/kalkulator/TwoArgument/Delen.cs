using System;

namespace kalkulator.TwoArgument
{
    public class Delen:ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstArgument / secondArgument;
        } 
    }
}