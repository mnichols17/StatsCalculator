using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public static class Division
    {
        static public decimal Quotient(int dividend, int divisor)
        {
            return (dividend / divisor);
        }

        static public decimal Quotient(decimal dividend, decimal divisor)
        {
            return (dividend / divisor);
        }

        static public decimal Quotient(int[] intArray)
        {
            decimal result = 0;

            for (var i = 0; i < intArray.Length; i++)
            {
                if (i > 1)
                {
                    result = Quotient(result, intArray[i]);
                }
                else
                {
                    result = Quotient(intArray[0], intArray[1]);
                }
            }

            return result;
        }

        static public decimal Quotient(decimal[] decimalArray)
        {
            decimal result = 0;

            for (var i = 0; i < decimalArray.Length; i++)
            {
                if (i > 1)
                {
                    result = Quotient(result, decimalArray[i]);
                }
                else
                {
                    result = Quotient(decimalArray[0], decimalArray[1]);
                }
            }

            return result;
        }
    }
}
