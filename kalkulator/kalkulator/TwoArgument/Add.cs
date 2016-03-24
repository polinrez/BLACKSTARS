namespace kalkulator.TwoArgument
{
    public class Add:ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}