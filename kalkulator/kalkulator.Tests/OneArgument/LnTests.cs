using kalkulator.OneArgument;
using NUnit.Framework;

namespace kalkulator.Tests.OneArgument
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(1, 0)]
        [TestCase(5, 1.6094)]
        [TestCase(80, 4.3820)]
        [TestCase(1000, 6.9077)]
        [TestCase(59999, 11.0020)]
        public void LnTest(double first, double expected)
        {
            Ln calculator = new Ln();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}