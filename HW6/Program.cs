using HWLibrary;
using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var result = VariablesHelper.CalculateEqantion(-1, -2);
                Console.WriteLine(result);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
