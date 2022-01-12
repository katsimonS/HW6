using HWLibrary;
using NUnit.Framework;
using System;

namespace HWTests
{
    public class ConditionalOperatorsHelperTests
    {
        [TestCase(5, 2, 7)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 10, -7)]

        public void CalculateConditional_WhenAAndBPassed_ShouldCalculateAAndB(int a, int b, int expectedResult)
        {
            int actualResult = ConditionalOperatorsHelper.CalculateCondition(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 2, 1)]
        [TestCase(-5, 2, 2)]
        [TestCase(-5, -2, 3)]
        [TestCase(5, -2, 4)]

        public void SearchQuarter_WhenXAndYPassed_ShouldSearchQuarter(int x, int y, int expectedResult)
        {
            int actualResult = ConditionalOperatorsHelper.SearchQuarter(x, y);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SearchQuarter_WhenXOrYEqualZero_ShouldArgumentException()
        {
            try
            {
                ConditionalOperatorsHelper.SearchQuarter(0, 77);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Quarter unidentified! X or Y qual to zero", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

    }
}
