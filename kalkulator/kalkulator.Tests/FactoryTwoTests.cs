using System;
using kalkulator.OneArgument;
using kalkulator.TwoArgument;
using NUnit.Framework;

namespace kalkulator.Tests
{
    [TestFixture]

    public class FactoryTwoTests
    {
        [Test]
        public void CreateAddTest()
        {
            ICalculator calc = Factory.CreateCalculator("button1");
            Assert.IsInstanceOf(typeof (Add), calc);
        }

        [Test]
        public void CreateDelenTest()
        {
            ICalculator calc = Factory.CreateCalculator("button4");
            Assert.IsInstanceOf(typeof(Delen), calc);
        }

        [Test]
        public void CreateLogTest()
        {
            ICalculator calc = Factory.CreateCalculator("button9");
            Assert.IsInstanceOf(typeof(Log), calc);
        }

        [Test]
        public void CreateModTest()
        {
            ICalculator calc = Factory.CreateCalculator("button10");
            Assert.IsInstanceOf(typeof(Mod), calc);
        }

        [Test]
        public void CreateUmnogTest()
        {
            ICalculator calc = Factory.CreateCalculator("button2");
            Assert.IsInstanceOf(typeof(Umnog), calc);
        }

        [Test]
        public void CreateRaznostTest()
        {
            ICalculator calc = Factory.CreateCalculator("button3");
            Assert.IsInstanceOf(typeof(Raznost), calc);
        }
        [Test]
        public void WrongNameTest()
        {
            Assert.Throws<Exception>(() => Factory.CreateCalculator("button50"));
        }
        
    }
}