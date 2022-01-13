using System;

namespace HWLibrary
{
    public class LoopsHelper
    {
        public static int DegreeOfNumber(int a, int b)
        {
            if (b < 0)
            {
                throw new ArgumentException("Degree cannot be negative!");
            }

            int result = a;

            if (b == 0)
            {
                result = 1;
            }
            for (int i = 1; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static int CountNumber(int a)
        {
            int result = 0;

            for (int i = 1; i * i < a; i++)
            {
                result = i;
            }

            return result;
        }

        public static int MaxDivisor(int a)
        {
            if (a == 0)
            {
                throw new ArgumentException("A equals to zero!");
            }

            int maxDivisor = 0;

            for (int i = a - 1; i > 0; i--)
            {
                if (a % i == 0)
                {
                    maxDivisor = i;
                    break;
                }
            }

            return maxDivisor;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        public static int DivisorSum(int a, int b, int divisor)
        {
            int sum = 0;

            if (b < a)
            {
                Swap(ref a, ref b);
            }
            for (int i = a; i <= b; i++)
            {
                if (i % divisor == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int FibonacciSeries(int n)
        {
            int fibonacciSeries = 0;
            int a = 1;
            int temp;

            for (int i = 0; i < n; i++)
            {
                temp = fibonacciSeries;
                fibonacciSeries = a;
                a += temp;
            }

            return fibonacciSeries;
        }

        public static int EuclideanAlgorithm(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArgumentException("A or B equals to zero!");
            }

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return Math.Max(a, b);
        }

        public static int GetCountOddNumber(int n)
        {
            int result = 0;

            while (n != 0)
            {
                int digit = n % 10;
                n /= 10;
                if (digit % 2 != 0)
                {
                    result++;
                }
            }

            return result;
        }

        public static int InvertedNumber(int n)
        {
            int result = 0;

            while (n != 0)
            {
                int currentDigit = n % 10;
                n /= 10;
                result *= 10;
                result += currentDigit;
            }

            return result;
        }

        public static bool SameNumbers(int a, int b)
        {
            while (a != 0)
            {
                int digitA = a % 10;
                while (b != 0)
                {
                    int digitB = b % 10;
                    if (digitB == digitA)
                    {
                        return true;
                    }
                    b /= 10;
                }
                a /= 10;
            }

            return false;
        }

    }
}
