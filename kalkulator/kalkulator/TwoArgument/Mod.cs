namespace kalkulator.TwoArgument
{
    public class Mod:ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument%secondArgument;
        }  
    }
}