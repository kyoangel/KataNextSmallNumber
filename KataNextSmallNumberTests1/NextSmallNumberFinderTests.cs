using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataNextSmallNumber.Tests
{
    [TestClass()]
    public class NextSmallNumberFinderTests
    {
        private static long _smallNumber;

        [TestMethod()]
        public void TestNextSmallNumber_input_zero_should_return_minus1()
        {
            GivenNumber(0);
            TheNextSmallNumberShouldBe(-1);
        }

        private static void TheNextSmallNumberShouldBe(int expected)
        {
            Assert.AreEqual(expected, _smallNumber);
        }

        private static void GivenNumber(int targetNumber)
        {
            _smallNumber = NextSmallNumberFinder.NextSmallNumber(targetNumber);
        }
    }
}