using kalkulator.OneArgument;
using NUnit.Framework;

namespace kalkulator.Tests.OneArgument
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(0, 0)]
        [TestCase(60,-0.3048)]
        [TestCase(90, 0.8939)]
        [TestCase(180, -0.8011)]
        [TestCase(800, 0.8939)]
        public void AddTest(double first, double expected)
        {
            Sin calculator = new Sin();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
