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

        [TestCase(26, 5)]
        [TestCase(25, 4)]
        [TestCase(16, 3)]
        [TestCase(1, 0)]
        [TestCase(4, 1)]
        [TestCase(-4, 0)]

        public void CountNumber_WhenAPassed_ShouldCalculateCountNumber(int a, int expectedResult)
        {
            int actualResult = LoopsHelper.CountNumber(a);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(16, 8)]
        [TestCase(25, 5)]
        [TestCase(75, 25)]

        public void MaxDivisor_WhenAAndBPassed_ShouldCalculateMaxDivisor(int a, int expectedResult)
        {
            int actualResult = LoopsHelper.MaxDivisor(a);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void MaxDivisor_WhenANegative_ShouldArgumentException()
        {
            try
            {
                LoopsHelper.MaxDivisor(0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equals to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(7, 15, 7, 21)]
        [TestCase(6, 15, 7, 21)]
        [TestCase(6, 14, 7, 21)]
        [TestCase(7, 14, 7, 21)]
        [TestCase(1, 23, 7, 42)]
        [TestCase(8, 13, 7, 0)]
        public void DivisorSum_WhenAAndBPassed_ShouldCalculateDivisorSum(int a, int b, int divisor, int expectedResult)
        {
            int actualResult = LoopsHelper.DivisorSum(a, b, divisor);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(0, 0)]
        [TestCase(3, 2)]
        [TestCase(6, 8)]
        [TestCase(10, 55)]
        public void FibonacciSeries_WhenNPassed_ShouldFibonacciSeries(int n, int expectedResult)
        {
            int actualResult = LoopsHelper.FibonacciSeries(n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(111, 432, 3)]
        [TestCase(661, 113, 1)]
        [TestCase(72, 96, 24)]
        public void EuclideanAlgorithm_WhenAAndBPassed_ShouldEuclideanAlgorithm(int a, int b, int expectedResult)
        {
            int actualResult = LoopsHelper.EuclideanAlgorithm(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void EuclideanAlgorithm_WhenBNegative_ShouldArgumentException()
        {
            try
            {
                LoopsHelper.EuclideanAlgorithm(0, 77);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A or B equals to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 1)]
        [TestCase(212322, 2)]
        [TestCase(111, 3)]
        [TestCase(10210299, 4)]
        [TestCase(22444, 0)]
        public void GetCountOddNumber_WhenNPassed_ShouldCountOddNumber(int n, int expectedResult)
        {
            int actualResult = LoopsHelper.GetCountOddNumber(n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(123, 321)]
        [TestCase(12, 21)]
        [TestCase(1, 1)]
        [TestCase(12345, 54321)]
        [TestCase(22444, 44422)]
        public void InvertedNumber_WhenNPassed_ShouldInvertedNumber(int n, int expectedResult)
        {
            int actualResult = LoopsHelper.InvertedNumber(n);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(111, 432, false)]
        [TestCase(1, 0, false)]
        [TestCase(1, 1, true)]
        [TestCase(112330034, 45525, true)]
        [TestCase(112334, 554, true)]
        public void SameNumbers_WhenAAndBPassed_ShouldSameNumbers(int a, int b, bool expectedResult)
        {
            var actualResult = LoopsHelper.SameNumbers(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
