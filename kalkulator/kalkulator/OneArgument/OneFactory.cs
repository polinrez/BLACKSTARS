using System;

namespace kalkulator.OneArgument
{
    public class OneFactory
    {
        public static IOneCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "button5":
                    return new Sin();
                case "button6":
                    return new Cos();
                case "button7":
                    return new Ln();
                case "button8":
                    return new Sqrt();
                default:
                    throw new Exception("Неизвестная операция");

            }
        } 
    }
}