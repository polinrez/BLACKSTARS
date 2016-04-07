using kalkulator.TwoArgument;
using NUnit.Framework;

namespace kalkulator.Tests.TwoArgument
{
    [TestFixture]
    public class AddTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(677777, 33333, 711110)]
        [TestCase(55555.5, 245.7, 55801.2)]
        [TestCase(-36, -4, -40)]
        [TestCase(-4, 2, -2)]
        public void AddTest(double first, double second, double expected)
        {
            Add calculator = new Add();
            double result = calculator.Calculate(first,second);
            Assert.AreEqual(expected, result);
        }
    }
}