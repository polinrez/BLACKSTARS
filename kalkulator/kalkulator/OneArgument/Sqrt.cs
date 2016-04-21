using System;

namespace kalkulator.OneArgument
{
    /// <summary>
    /// 
    /// </summary>
    public class Sqrt: IOneCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
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