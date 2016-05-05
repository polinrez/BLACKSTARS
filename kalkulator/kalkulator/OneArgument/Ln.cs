using System;

namespace kalkulator.OneArgument
{

    public class Ln: IOneCalculator
    {
        /// <summary>
        /// Метод выполнения математической операции "десятичный логарифм" для одного аргумента
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}