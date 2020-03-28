using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public static class Addition
    {
        static public int Sum(int a, int b)
        {
            return a + b;
        }
        static public decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }


        static public int Sum(int[] intArray)
        {
            int result = 0;
            foreach(var x in intArray)
            {
                result = Sum(result, x);
            }

            return result;
        }

        static public decimal Sum(decimal[] decArray)
        {
            decimal result = 0;
            foreach(var x in decArray)
            {
                result = Sum(result, x);
            }
            return result;
        }
    }
}