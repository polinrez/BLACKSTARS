using System;

namespace kalkulator
{
    public class OneFactory
    {
        public static IOneCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "button5":
                    return new Sin();
                    break;
                case "button6":
                    return new Cos();
                    break;
                case "button7":
                    return new Ln();
                    break;
                case "button8":
                    return new Sqrt();
                    break;
                default:
                    throw new Exception("Неизвестная операция");

            }
        } 
    }
}