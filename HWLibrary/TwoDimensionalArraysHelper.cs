using System;

namespace HWLibrary
{
    public class TwoDimensionalArraysHelper
    {
        public static int GetMinValue(int[,] array)
        {
            var (i, j) = GetMinIndexArray(array);

            return array[i, j];
        }

        public static int GetMaxValue(int[,] array)
        {
            var (i, j) = GetMaxIndexArray(array);

            return array[i, j];
        }

        public static(int, int) GetMinIndexArray(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[minI, minJ] > array[i, j])
                    {
                        minI = i;
                        minJ = j;
                    }
                }
            }

            return (minI, minJ);
        }

        public static(int, int) GetMaxIndexArray(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[maxI, maxJ] < array[i, j])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            return (maxI, maxJ);
        }

        public static int BiggerNeighborCount(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i > 0 && array[i, j] < array[i - 1, j])
                    {
                        continue;
                    }
                    if (i < array.GetLength(0) - 1 && array[i, j] < array[i + 1, j])
                    {
                        continue;
                    }
                    if (j > 0 && array[i, j] < array[i, j - 1])
                    {
                        continue;
                    }
                    if (j < array.GetLength(1) - 1 && array[i, j] < array[i, j + 1])
                    {
                        continue;
                    }
                    count++;
                }
            }

            return count;
        }

        public static int[,] DiagonalRevers(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        Swap(ref array[i, j], ref array[j, i]);
                    }
                }
            }

            return array;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
