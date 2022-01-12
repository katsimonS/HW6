using System;

namespace HWLibrary
{
    public class OneDimensionalArraysHelper
    {
        public static int GetMinElement(int[] array)
        {
            var i = GetMinIndexElement(array);

            return array[i];
        }

        public static int GetMaxElement(int[] array)
        {
            var i = GetMaxIndexElement(array);

            return array[i];
        }

        public static int GetMinIndexElement(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            int minValueIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[minValueIndex] > array[i])
                {
                    minValueIndex = i;
                }
            }

            return minValueIndex;
        }

        public static int GetMaxIndexElement(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            int maxValueIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[maxValueIndex] < array[i])
                {
                    maxValueIndex = i;
                }
            }

            return maxValueIndex;
        }

        public static int GetSumOddIndex(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int[] ReverseArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            int i = 0;
            int j = array.Length - 1;

            while (i < j)
            {
                Swap(ref array[i++], ref array[j--]);
            }

            return array;
        }

        public static int CountOddElements(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    ++count;
                }
            }

            return count;
        }

        public static int[] SwapHalfArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            int a = array.Length / 2;
            int b = a + array.Length % 2;

            for (int i = 0; i < a; i++)
            {
                Swap(ref array[i], ref array[b + i]);
            }

            return array;
        }

        public static int[] BubbleSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
        }

        public static int[] InsertSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty!");
            }

            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i;
                while ((j >= 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }

            return array;
        }
    }
}
