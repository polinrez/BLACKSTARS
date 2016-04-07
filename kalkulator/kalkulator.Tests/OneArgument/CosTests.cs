using kalkulator.OneArgument;
using NUnit.Framework;

namespace kalkulator.Tests.OneArgument
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(0, 1)]
        [TestCase(5, 0.2836)]
        [TestCase(70, 0.6333)]
        [TestCase(900, 0.0662)]
        [TestCase(1000, 0.5623)]
        public void AddTest(double first, double expected)
        {
            Cos calculator = new Cos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
