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
    }
}