using System;
using kalkulator.TwoArgument;
using NUnit.Framework;

namespace kalkulator.Tests.OneArgument
{
    [TestFixture]
    public class DelenTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(1000, 100, 10)]

        public void DelenTest(double first, double second, double expected)
        {
            Delen calculator = new Delen();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

        [Test]

        public void ZeroTest()
        {
            Delen calculator = new Delen();
           
            Assert.Throws<Exception>(() => calculator.Calculate(10, 0));

        }
    }
}