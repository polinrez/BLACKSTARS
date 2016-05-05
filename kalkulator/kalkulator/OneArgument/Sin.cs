using System;

namespace kalkulator.OneArgument
{
    public class Sin: IOneCalculator
    {
        /// <summary>
        /// Метод выполнения математической операции "синус" для одного аргумента 
        /// </summary>
        /// <param name="firstArgument">Один аргумент типа double</param>
        /// <returns>Синус из аргумента </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}