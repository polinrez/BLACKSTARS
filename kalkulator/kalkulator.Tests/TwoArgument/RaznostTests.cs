using kalkulator.TwoArgument;
using NUnit.Framework;

namespace kalkulator.Tests.OneArgument
{
    [TestFixture]
    public class RaznostTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(100000, 33333, 66667)]
     
        public void AddTest(double first, double second, double expected)
        {
            Raznost calculator = new Raznost();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}