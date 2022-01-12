using HWLibrary;
using NUnit.Framework;
using System;

namespace HWTests
{
    class OneDimensionalArraysHelperTests
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, 0)]
        [TestCase(new int[] { 11, 3, 1 }, 2)]
        [TestCase(new int[] { 31, 2, 1, 4, 22 }, 2)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, -2, 3, 4, 17 }, 1)]
        [TestCase(new int[] { }, 0)]
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
        public void GetMinElement_WhenArrayPassed_ShouldMinElement(int[] testArray, int expectedResult)
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

        [TestCase(new int[] { 1, 2, 3, 4 }, 3)]
        [TestCase(new int[] { 11, 3, 1 }, 0)]
        [TestCase(new int[] { 31, 442, 1, 4, 22 }, 1)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, 0)]
        public void GetMaxIndexElement_WhenArrayPassed_ShouldMaxIndexElement(int[] testArray, int expectedResult)
        {
            int actualResult = OneDimensionalArraysHelper.GetMaxIndexElement(testArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        public void GetMaxIndexElement_WhenArrayNull_ShouldArgumentException(int[] testArray)
        {
            try
            {
                OneDimensionalArraysHelper.GetMaxIndexElement(testArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { 11, 3, 1 }, 11)]
        [TestCase(new int[] { 31, 442, 1, 4, 22 }, 442)]
        [TestCase(new int[] { 0 }, 0)]
        public void GetMaxElement_WhenArrayPassed_ShouldMaxElement(int[] testArray, int expectedResult)
        {
            int actualResult = OneDimensionalArraysHelper.GetMaxElement(testArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        public void GetMaxElement_WhenArrayNull_ShouldArgumentException(int[] testArray)
        {
            try
            {
                OneDimensionalArraysHelper.GetMaxIndexElement(testArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }


        [TestCase(new int[] { 1, 2, 3, 4 }, 6)]
        [TestCase(new int[] { 11, 3, 1 }, 3)]
        [TestCase(new int[] { 31, 442, 1, 2, 22 }, 444)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { -1, -1 }, -1)]
        public void GetSumOddIndex_WhenArrayPassed_ShouldGetSumOddIndex(int[] testArray, int expectedResult)
        {
            int actualResult = OneDimensionalArraysHelper.GetSumOddIndex(testArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        public void GetSumOddIndex_WhenArrayNull_ShouldArgumentException(int[] testArray)
        {
            try
            {
                OneDimensionalArraysHelper.GetSumOddIndex(testArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 11, 3, 1 }, new int[] { 1, 3, 11 })]
        [TestCase(new int[] { 31, 442, 1, 2, 22 }, new int[] { 22, 2, 1, 442, 31 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { -1, -1 }, new int[] { -1, -1 })]
        public void ReverseArray_WhenArrayPassed_ShouldReverseArray(int[] testArray, int[] expectedResult)
        {
            int[] actualResult = OneDimensionalArraysHelper.ReverseArray(testArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        public void ReverseArray_WhenArrayNull_ShouldArgumentException(int[] testArray)
        {
            try
            {
                OneDimensionalArraysHelper.ReverseArray(testArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(new int[] { 11, 3, 1 }, 3)]
        [TestCase(new int[] { 312, 442, 12, 2, 22 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        public void CountOddElements_WhenArrayPassed_ShouldCountOddElements(int[] testArray, int expectedResult)
        {
            int actualResult = OneDimensionalArraysHelper.CountOddElements(testArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        public void CountOddElements_WhenArrayNull_ShouldArgumentException(int[] testArray)
        {
            try
            {
                OneDimensionalArraysHelper.ReverseArray(testArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 11, 3, 1 }, new int[] { 1, 3, 11 })]
        [TestCase(new int[] { 31, 442, 1, 2, 22 }, new int[] { 2, 22, 1, 31, 442 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { -1, -1 }, new int[] { -1, -1 })]
        public void SwapHalfArray_WhenArrayPassed_ShouldSwapHalfArray(int[] testArray, int[] expectedResult)
        {
            int[] actualResult = OneDimensionalArraysHelper.SwapHalfArray(testArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        public void SwapHalfArray_WhenArrayNull_ShouldArgumentException(int[] testArray)
        {
            try
            {
                OneDimensionalArraysHelper.SwapHalfArray(testArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 4, 1, 3, 2 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 11, 3, 1 }, new int[] { 1, 3, 11 })]
        [TestCase(new int[] { 31, 442, 1, 2, 22 }, new int[] { 1, 2, 22, 31, 442 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { -1, -1 }, new int[] { -1, -1 })]
        public void BubbleSort_WhenArrayPassed_ShouldBubbleSort(int[] testArray, int[] expectedResult)
        {
            int[] actualResult = OneDimensionalArraysHelper.BubbleSort(testArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        public void BubbleSort_WhenArrayNull_ShouldArgumentException(int[] testArray)
        {
            try
            {
                OneDimensionalArraysHelper.BubbleSort(testArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 4, 1, 3, 2 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 11, 3, 1 }, new int[] { 1, 3, 11 })]
        [TestCase(new int[] { 31, 442, 1, 2, 22 }, new int[] { 1, 2, 22, 31, 442 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { -1, -1 }, new int[] { -1, -1 })]
        public void InsertSort_WhenArrayPassed_ShouldInsertSort(int[] testArray, int[] expectedResult)
        {
            int[] actualResult = OneDimensionalArraysHelper.InsertSort(testArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        public void InsertSort_WhenArrayNull_ShouldArgumentException(int[] testArray)
        {
            try
            {
                OneDimensionalArraysHelper.InsertSort(testArray);
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
