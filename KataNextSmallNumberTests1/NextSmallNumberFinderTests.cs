using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataNextSmallNumber.Tests
{
    [TestClass()]
    public class NextSmallNumberFinderTests
    {
        private static long _smallNumber;

        [TestMethod()]
        public void input_zero_should_return_minus1()
        {
            GivenNumber(0);
            TheNextSmallNumberShouldBe(-1);
        }

        [TestMethod()]
        public void input_21_should_return_12()
        {
            GivenNumber(21);
            TheNextSmallNumberShouldBe(12);
        }

        [TestMethod()]
        public void input_531_should_return_513()
        {
            GivenNumber(531);
            TheNextSmallNumberShouldBe(513);
        }

        [TestMethod()]
        public void input_2071_should_return_2017()
        {
            GivenNumber(2071);
            TheNextSmallNumberShouldBe(2017);
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