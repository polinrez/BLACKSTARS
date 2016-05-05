using System;

namespace kalkulator.TwoArgument
{
    public class Delen:ICalculator
    {
        /// <summary>
        /// Метод выполнения математической операции "Деление" для двух аргументов + исключение "деление на 0"
        /// </summary>
        /// <param name="firstArgument">Первый аргумент типа double - делимое</param>
        /// <param name="secondArgument">Второй аргумент типо double - делитель</param>
        /// <returns>Деление первого аргумента на второй аргумент - частное <see cref="Double"/>.</returns>
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