using System;

namespace kalkulator.OneArgument
{
    public class Cos: IOneCalculator
    {
        /// <summary>
        /// Метод выполнения математической операции "косинус" для одного аргумента 
        /// </summary>
        /// <param name="firstArgument">Один аргумент типа double</param>
        /// <returns>Косинус из аргумента</returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}