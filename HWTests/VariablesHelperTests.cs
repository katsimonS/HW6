using HWLibrary;
using NUnit.Framework;
using System;

namespace HWTests
{
    public class VariablesHelperTests
    {
        [TestCase(2, 3, 19)]
        [TestCase(0, 5, 5)]
        [TestCase(-1, -2, 1)]

        public void CalculateEqantion_WhenANotEqualToB_ShouldCalculateEquation(double a, double b, double expectedResult)
        {
            double actualResult = VariablesHelper.CalculateEqantion(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateEqantion_WhenAEqualToB_ShouldArgumentException()
        {
            try
            {
                VariablesHelper.CalculateEqantion(77, 77);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equal to B!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase("abc", "qwe", "qweabc")]
        [TestCase("Hello", "World", "WorldHello")]

        public void SwapString_WhenAAndBPassed_ShouldBA(string a, string b, string expectedResult)
        {
            string actualResult = VariablesHelper.SwapString(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(78, 33, 2, 12)]
        [TestCase(9, 90, 0, 9)]

        public void DivisionAndRemainder_WhenAAndBPassed_ShouldDivisionAndRemainder(int a, int b, int x, int y)
        {
            var actualResult = VariablesHelper.DivisionAndRemainder(a, b);
            var expectedResult = (x, y);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DivisionAndRemainder_WhenBEqualToZero_ShouldArgumentException()
        {
            try
            {
                VariablesHelper.DivisionAndRemainder(77, 0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("B equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, -8, 12, 20)]
        [TestCase(2, 3, 4, 0.5)]
        [TestCase(3, 2, 2, 0)]
        public void LinearEquation_WhenAAndBAndCPassed_ShouldLinearEquation(double a, double b, double c, double expectedResult)
        {
            double actualResult = VariablesHelper.LinearEquation(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void LinearEquation_WhenAOrBOrCEqualToZero_ShouldArgumentException()
        {
            try
            {
                VariablesHelper.LinearEquation(0, 77, 77);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A or B or C equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 2, 3, 4, 1, 1)]
        public void EquationOfLine_When—oordinatesPassed_ShouldEquationOfLine(int x1, int y1, int x2, int y2, double a, double b)
        {
            var actualResult = VariablesHelper.EquationOfLine(x1, y1, x2, y2);
            var expectedResult = (a, b);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void EquationOfLine_WhenX1EqualToX2_ShouldArgumentException()
        {
            try
            {
                VariablesHelper.EquationOfLine(77, -3, 77, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("X1 equal to X2!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}