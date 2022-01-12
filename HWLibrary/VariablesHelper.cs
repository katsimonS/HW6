using System;

namespace HWLibrary
{
    public class VariablesHelper
    {
        public static double CalculateEqantion(double a, double b)
        {
            if (a == b)
            {
                throw new ArgumentException("A equal to B!");
            }

            return (a * 5 + b * b) / (b - a);
        }
        public static string SwapString(string valueA, string valueB)
        {
            string temp = valueA;
            valueA = valueB;
            valueB = temp;

            return valueA + valueB;
        }
        public static (int division, int remainder) DivisionAndRemainder(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("B equal to zero!");
            }

            int division = a / b;
            int remainder = a % b;

            return (division, remainder);
        }
        public static double LinearEquation(double a, double b, double c)
        {
            if (a == 0 || b == 0 ||c == 0)
            {
                throw new ArgumentException("A or B or C equal to zero!");
            }

            return (c - b) / a;
        }
        public static (double, double) EquationOfLine(int x1, int y1, int x2, int y2)
        {
            if(x1 == x2)
            {
                throw new ArgumentException("X1 equal to X2!");
            }

            double a = Math.Round((y1 - y2) / (double)(x1 - x2), 2);
            double b = Math.Round(y2 - a * x2, 2);

            return (a, b);
        }
    }
}
