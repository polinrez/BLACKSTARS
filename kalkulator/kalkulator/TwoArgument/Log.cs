using System;

namespace kalkulator.TwoArgument
{
    public class Log:ICalculator
    {
        /// <summary>
        /// Метод для математической операции "логарифм" для двух аргументов
        /// </summary>
        /// <param name="firstArgument">Первый аргумент типа double</param>
        /// <param name="secondArgument">Второй аргумент типа double - основание логарифма</param>
        /// <returns>логарифм первого аргумента по основанию второго аргумента</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return  Math.Log(firstArgument,secondArgument);
        }  
    }
}