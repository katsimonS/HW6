using System;

namespace HWLibrary
{
    public class ConditionalOperatorsHelper
    {
        public static int CalculateCondition(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        public static int SearchQuarter(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                throw new ArgumentException("Quarter unidentified! X or Y qual to zero");
            }

            int result;

            if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x < 0 && y > 0)
            {
                result = 2;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else
            {
                result = 4;
            }

            return result;
        }

        public static (int a, int b, int c) IncreasingNumbers(int a, int b, int c)
        {
            if (a > b)
            {
                Swap(ref a, ref b);
            }
            if (a > c)
            {
                Swap(ref a, ref c);
            }
            if (b > c)
            {
                Swap(ref b, ref c);
            }

            return (a, b, c);
        }
        
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static (double x1, double x2) QuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("A cannot be equal to zero!");
            }

            double x1;
            double x2;
            double discriminant = b * b - 4 * a * c;

            if (discriminant >= 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return (x1, x2);
            }

            throw new ArgumentException("D is less zero!");
        }

        public static string NumberTranslation(int num)
        {
            if (num < 10 || num > 99)
            {
                throw new ArgumentException("The number must be two-digit!");
            }

            string a = "";
            string b = "";

            if (num < 20)
            {
                switch (num)
                {
                    case 10:
                        a = "Ten";
                        break;
                    case 11:
                        a = "Eleven";
                        break;
                    case 12:
                        a = "Twelve";
                        break;
                    case 13:
                        a = "Thirteen";
                        break;
                    case 14:
                        a = "Fourteen";
                        break;
                    case 15:
                        a = "Fifteen";
                        break;
                    case 16:
                        a = "Sixteen";
                        break;
                    case 17:
                        a = "Seventeen";
                        break;
                    case 18:
                        a = "Eighteen";
                        break;
                    case 19:
                        a = "Nineteen";
                        break;
                }
            }
            else
            {
                switch (num / 10)
                {
                    case 2:
                        a = "Twenty";
                        break;
                    case 3:
                        a = "Thirty";
                        break;
                    case 4:
                        a = "Fourty";
                        break;
                    case 5:
                        a = "Fifty";
                        break;
                    case 6:
                        a = "Sixty";
                        break;
                    case 7:
                        a = "Seventy";
                        break;
                    case 8:
                        a = "Eighty";
                        break;
                    case 9:
                        a = "Ninety";
                        break;
                }
                switch (num % 10)
                {
                    case 1:
                        b = "one";
                        break;
                    case 2:
                        b = "two";
                        break;
                    case 3:
                        b = "three";
                        break;
                    case 4:
                        b = "four";
                        break;
                    case 5:
                        b = "five";
                        break;
                    case 6:
                        b = "six";
                        break;
                    case 7:
                        b = "seven";
                        break;
                    case 8:
                        b = "eight";
                        break;
                    case 9:
                        b = "nine";
                        break;
                }
            }

            return $"{a} {b}";
        }
    }
}
