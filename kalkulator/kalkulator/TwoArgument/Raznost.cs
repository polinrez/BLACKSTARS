namespace kalkulator.TwoArgument
{
    public class Raznost:ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        } 
    }
}