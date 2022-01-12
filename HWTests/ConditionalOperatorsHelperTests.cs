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

        [TestCase(5, 2, 1, 1, 2, 5)]
        [TestCase(-5, 2, 2, -5, 2, 2)]
        [TestCase(5, -2, 3, -2, 3, 5)]

        public void IncreasingNumbers_WhenXAndYPassed_ShouldSearchQuarter(int a, int b, int c, int x, int y, int z)
        {
            var actualResult = ConditionalOperatorsHelper.IncreasingNumbers(a, b, c);
            var expectedResult = (x, y, z);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, -2, -3, 3, -1)]

        public void QuadraticEquation_When_ShouldResult(double a, double b, double c, double x1, double x2)
        {
            var actualResult = ConditionalOperatorsHelper.QuadraticEquation(a, b, c);
            var expectedResult = (x1, x2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void QuadraticEquation_WhenDiscriminantIsLessZero_ShouldArgumentException()
        {
            try
            {
                ConditionalOperatorsHelper.QuadraticEquation(9, -6, 2);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("D is less zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void QuadraticEquation_WhenAEqualToZero_ShouldArgumentException()
        {
            try
            {
                ConditionalOperatorsHelper.QuadraticEquation(0, 77, 23);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A cannot be equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(10, "Ten ")]
        [TestCase(11, "Eleven ")]
        [TestCase(12, "Twelve ")]
        [TestCase(13, "Thirteen ")]
        [TestCase(14, "Fourteen ")]
        [TestCase(15, "Fifteen ")]
        [TestCase(16, "Sixteen ")]
        [TestCase(17, "Seventeen ")]
        [TestCase(18, "Eighteen ")]
        [TestCase(19, "Nineteen ")]
        [TestCase(20, "Twenty ")]
        [TestCase(77, "Seventy seven")]
        [TestCase(99, "Ninety nine")]
        public void NumberTranslation_WhenAAndBPassed_ShouldCalculateAAndB(int a, string expectedResult)
        {
            var actualResult = ConditionalOperatorsHelper.NumberTranslation(a);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
