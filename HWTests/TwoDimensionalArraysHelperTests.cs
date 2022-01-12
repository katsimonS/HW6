using HWLibrary;
using NUnit.Framework;
using System;

namespace HWTests
{
    class TwoDimensionalArraysHelperTests
    {
        [TestCaseSource(nameof(testArrayGetMinValue))]
        public void GetMinValue_WhenArrayIsFilled_ShouldReturnMinFromArray(int[,] sourceArray,int expectedMin)
        {
            int actualMin = TwoDimensionalArraysHelper.GetMinValue(sourceArray);

            Assert.AreEqual(expectedMin, actualMin);
        }

        static object[] testArrayGetMinValue = new[]
        {
            new object[] { new[,] { { 1 }, { 4 } }, 1 },
            new object[] { new[,] { { 4, 5 }, { 7, 0 } }, 0 },
            new object[] { new[,] { { 4, -7, 6}, { 6, 7, 0} }, -7 }
        };

        [TestCase(null)]
        public void GetMinValue_WhenArrayNull_ShouldArgumentException(int[,] nullArray)
        {
            try
            {
                TwoDimensionalArraysHelper.GetMinValue(nullArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource(nameof(testArrayGetMaxValue))]
        public void GetMaxValue_WhenArrayIsFilled_ShouldReturnMaxFromArray(int[,] sourceArray, int expectedMax)
        {
            int actualMax = TwoDimensionalArraysHelper.GetMaxValue(sourceArray);

            Assert.AreEqual(expectedMax, actualMax);
        }

        static object[] testArrayGetMaxValue = new[]
        {
            new object[] { new[,] { { 1 }, { 4 } }, 4 },
            new object[] { new[,] { { 4, 5 }, { 7, 0 } }, 7 },
            new object[] { new[,] { { 4, -7, 6}, { 6, 8, 0} }, 8 }
        };

        [TestCase(null)]
        public void GetMaxValue_WhenArrayNull_ShouldArgumentException(int[,] nullArray)
        {
            try
            {
                TwoDimensionalArraysHelper.GetMaxValue(nullArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource(nameof(testArrayGetMinIndexArray))]
        public void GetMinIndexArray_WhenArrayIsFilled_ShouldReturnMinIndexFromArray(int[,] sourceArray, (int, int) expectedMin)
        {
            var actualMin = TwoDimensionalArraysHelper.GetMinIndexArray(sourceArray);

            Assert.AreEqual(expectedMin, actualMin);
        }

        static object[] testArrayGetMinIndexArray = new[]
        {
            new object[] { new[,] { { 1 }, { 4 } }, (0, 0) },
            new object[] { new[,] { { 4, 5 }, { 7, 0 } }, (1, 1) },
            new object[] { new[,] { { 4, -7, 6}, { 6, 7, 0} }, (0, 1) }
        };

        [TestCase(null)]
        public void GetMinIndexArray_WhenArrayNull_ShouldArgumentException(int[,] nullArray)
        {
            try
            {
                TwoDimensionalArraysHelper.GetMinIndexArray(nullArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource(nameof(testArrayGetMaxIndexArray))]
        public void GetMaxIndexArray_WhenArrayIsFilled_ShouldReturnMaxIndexFromArray(int[,] sourceArray, (int, int) expectedMax)
        {
            var actualMax = TwoDimensionalArraysHelper.GetMaxIndexArray(sourceArray);

            Assert.AreEqual(expectedMax, actualMax);
        }

        static object[] testArrayGetMaxIndexArray = new[]
        {
            new object[] { new[,] { { 1 }, { 4 } }, (1, 0) },
            new object[] { new[,] { { 4, 5 }, { 0, 8 } }, (1, 1) },
            new object[] { new[,] { { 4, -7, 6}, { 6, 0, 8} }, (1, 2) }
        };

        [TestCase(null)]
        public void GetMaxIndexArray_WhenArrayNull_ShouldArgumentException(int[,] nullArray)
        {
            try
            {
                TwoDimensionalArraysHelper.GetMaxIndexArray(nullArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource(nameof(testArrayBiggerNeighborCount))]
        public void BiggerNeighborCount_WhenArrayIsFilled_ShouldBiggerNeighborCount(int[,] sourceArray, int expectedResult)
        {
            var actualResult = TwoDimensionalArraysHelper.BiggerNeighborCount(sourceArray);

            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] testArrayBiggerNeighborCount = new[]
        {
            new object[] { new[,] { { 1 }, { 4 } }, 1 },
            new object[] { new[,] { { 4, 8 }, { 9, 7 } }, 2 },
            new object[] { new[,] { { 4, -7, 6}, { 6, 0, 8} , { 1, 1, 1 } }, 3 }
        };

        [TestCase(null)]
        public void BiggerNeighborCount_WhenArrayNull_ShouldArgumentException(int[,] nullArray)
        {
            try
            {
                TwoDimensionalArraysHelper.BiggerNeighborCount(nullArray);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource(nameof(testArrayDiagonalRevers))]
        public void DiagonalRevers_WhenArrayIsFilled_ShouldDiagonalRevers(int[,] sourceArray, int[,] expectedResult)
        {
            int[,] actualResult = TwoDimensionalArraysHelper.DiagonalRevers(sourceArray);

            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] testArrayDiagonalRevers = new[]
        {
            new object[] { new[,] { { 1 }, { 4 } }, new[,] { { 1 }, { 4 } } },
            new object[] { new[,] { { 4, 8 }, { 9, 7 } }, new[,] { { 4, 9 }, { 8, 7 } } },
            new object[] { new[,] { { 4, -7, 6}, { 6, 0, 8} , { 1, 1, 1 } }, new[,] { { 4, 6, 1 }, { -7, 0, 1 }, { 6, 8, 1 } } }
        };

        [TestCase(null)]
        public void DiagonalRevers_WhenArrayNull_ShouldArgumentException(int[,] nullArray)
        {
            try
            {
                TwoDimensionalArraysHelper.DiagonalRevers(nullArray);
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
