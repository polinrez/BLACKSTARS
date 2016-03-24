namespace kalkulator.TwoArgument
{
    public class Delen:ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        } 
    }
}