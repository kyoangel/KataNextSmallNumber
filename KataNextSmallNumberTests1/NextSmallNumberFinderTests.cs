using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataNextSmallNumber.Tests
{
    [TestClass()]
    public class NextSmallNumberFinderTests
    {
        [TestMethod()]
        public void TestNextSmallNumber_input_zero_should_return_minus1()
        {
            var actual = NextSmallNumberFinder.NextSmallNumber(0);
            var expected = -1;
            Assert.AreEqual(expected, actual);
        }
    }
}