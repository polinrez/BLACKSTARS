using kalkulator.TwoArgument;
using NUnit.Framework;

namespace kalkulator.Tests.OneArgument
{
    [TestFixture]
    public class TestAdd
    {
        [Test]
        public void AddTest()
        {
            Add calck = new Add();
            double res = calck.Calculate(2,2);
            Assert.AreEqual(4, res);
            res = calck.Calculate(1, 8);
            Assert.AreEqual(9, res);
        }
    }
}