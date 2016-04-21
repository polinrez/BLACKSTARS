using System;
using kalkulator.OneArgument;
using NUnit.Framework;

namespace kalkulator.Tests.OneArgument
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(4, 2)]
        [TestCase(400,20)]
        [TestCase(523, 22.8691)]
        [TestCase(6084, 78)]
        [TestCase(0, 0)]
        public void SqrtTest(double first, double expected)
        {
            Sqrt calculator = new Sqrt();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }

        [Test]
        public void OtricTest()
        {
            Sqrt calculator = new Sqrt();
            Assert.Throws<Exception>(() => calculator.Calculate(-10));
        }
    }
}