﻿namespace kalkulator.TwoArgument
{
    public class Umnog:ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        } 
    }
}