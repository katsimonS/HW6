using HWLibrary;
using NUnit.Framework;
using System;

namespace HWTests
{
    class TwoDimensionalArraysHelperTests
    {
        [TestCaseSource(nameof(testArray))]
        public void GetMinValue_WhenArrayIsFilled_ShouldReturnMinFromArray(
            int[,] sourceArray,
            int expectedMin)
        {
            int actualMin = TwoDimensionalArraysHelper.GetMinValue(sourceArray);

            Assert.AreEqual(expectedMin, actualMin);
        }

        static object[] testArray = new[]
        {
            new object[] { new[,] { { 1, 2, 3 }, { 4, 5, 6} }, 1 },
            new object[] { new[,] { { 4, 5, 6}, { 6, 7, 0} }, 0 },
            new object[] { new[,] { { 4, -7, 6}, { 6, 7, 0} }, -7 }
        };

        [TestCase(null)]
        public void GetMinValue_WhenArrayNull_ShouldArgumentException(int[,] testArray)
        {
            try
            {
                TwoDimensionalArraysHelper.GetMinValue(testArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
