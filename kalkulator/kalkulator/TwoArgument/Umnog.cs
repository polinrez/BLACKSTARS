namespace kalkulator.TwoArgument
{
    public class Umnog:ICalculator
    {
        /// <summary>
        /// Метод для операции "умножить"
        /// </summary>
        /// <param name="firstArgument">Первый аргумент типа double - множимое</param>
        /// <param name="secondArgument">Второй аргумент типа double  - множитель</param>
        /// <returns>Произведение первого и второго аргумента</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        } 
    }
}