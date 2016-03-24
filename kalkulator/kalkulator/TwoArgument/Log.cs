using System;

namespace kalkulator.TwoArgument
{
    public class Log:ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return  Math.Log(firstArgument,secondArgument);
        }  
    }
}