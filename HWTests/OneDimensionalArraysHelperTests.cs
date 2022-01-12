using HWLibrary;
using NUnit.Framework;
using System;

namespace HWTests
{
    class OneDimensionalArraysHelperTests
    {
        [TestCase(new int[] { 1, 2, 3, 4}, 0)]
        [TestCase(new int[] { 11, 3, 1 }, 2)]
        [TestCase(new int[] { 31, 2, 1, 4, 22}, 2)]
        [TestCase(new int[] {0}, 0)]
        [TestCase(new int[] { 1, -2, 3, 4, 17 }, 1)]
        [TestCase(new int[] {}, 0)]

        public void GetMinIndexElement_WhenArrayPassed_ShouldMinIndexElement(int[] testArray, int expectedResult)
        {
            int actualResult = OneDimensionalArraysHelper.GetMinIndexElement(testArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        public void GetMinIndexElement_WhenArrayNull_ShouldArgumentException(int[] testArray)
        {
            try
            {
                OneDimensionalArraysHelper.GetMinIndexElement(testArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1)]
        [TestCase(new int[] { 11, 3, 1 }, 1)]
        [TestCase(new int[] { 31, 2, 1, 4, 22 }, 1)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, -2, 3, 4, 17 }, -2)]
        public void GetMinElement_WhenArrayPassed_ShouldMinIndexElement(int[] testArray, int expectedResult)
        {
            int actualResult = OneDimensionalArraysHelper.GetMinElement(testArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        public void GetMinElement_WhenArrayNull_ShouldArgumentException(int[] testArray)
        {
            try
            {
                OneDimensionalArraysHelper.GetMinIndexElement(testArray);
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
