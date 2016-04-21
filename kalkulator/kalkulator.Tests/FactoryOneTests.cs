using System;
using kalkulator.OneArgument;
using kalkulator.TwoArgument;
using NUnit.Framework;

namespace kalkulator.Tests
{
    [TestFixture]
    public class FactoryOneTests
    {

        [Test]

        public void CreateCosTest()
        {
            IOneCalculator calc = OneFactory.CreateCalculator("button6");
            Assert.IsInstanceOf(typeof (Cos), calc);
        }

        [Test]

        public void CreateLnTest()
        {
            IOneCalculator calc = OneFactory.CreateCalculator("button7");
            Assert.IsInstanceOf(typeof (Ln), calc);
        }

        [Test]

        public void CreateSinTest()
        {
            IOneCalculator calc = OneFactory.CreateCalculator("button5");
            Assert.IsInstanceOf(typeof (Sin), calc);
        }

        [Test]

        public void CreateSqrtTest()
        {
            IOneCalculator calc = OneFactory.CreateCalculator("button8");
            Assert.IsInstanceOf(typeof (Sqrt), calc);
        }

        [Test]
        public void WrongNameTest()
        {
            Assert.Throws<Exception>(() => OneFactory.CreateCalculator("button0"));
        }
    }
}