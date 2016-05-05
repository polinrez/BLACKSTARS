using System;

namespace kalkulator.OneArgument
{
    public class Sqrt: IOneCalculator
    {
        /// <summary>
        /// Метод выполнения математической операции "Корень из числа" для одного аргумента + исключение "корень из отрицательного числа"
        /// </summary>
        /// <param name="firstArgument">Один аргумент типа  double</param>
        /// <returns>Квадратный корень из аргумента в виде <see cref="Double"/>.</returns>
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