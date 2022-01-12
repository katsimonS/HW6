using NUnit.Framework;
using HWLibrary;
using System;

namespace HWTests
{
    class LoopsHelperTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 0, 1)]
        [TestCase(3, 1, 3)]
        [TestCase(4, 5, 1024)]

        public void DegreeOfNumber_WhenAAndBPassed_ShouldCalculateADegreeB(int a, int b, int expectedResult)
        {
            int actualResult = LoopsHelper.DegreeOfNumber(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DegreeOfNumber_WhenBNegative_ShouldArgumentException()
        {
            try
            {
                LoopsHelper.DegreeOfNumber(5, -7);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Degree cannot be negative!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
