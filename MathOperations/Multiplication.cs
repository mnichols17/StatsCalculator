using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public static class Multiplication
    {
        static public int Product(int factorA, int factorB)
        {
            return (factorA * factorB);
        }

        static public decimal Product(decimal factorA, decimal factorB)
        {
            return (factorA * factorB);
        }

        static public int Product(int[] intArray)
        {
            int result = 0;

            for (var i = 0; i < intArray.Length; i++)
            {
                if (i > 1)
                {
                    result = Product(result, intArray[i]);
                }
                else
                {
                    result = Product(intArray[0], intArray[1]);
                }
            }

            return result;
        }

        static public decimal Product(decimal[] decimalArray)
        {
            decimal result = 0;

            for (var i = 0; i < decimalArray.Length; i++)
            {
                if (i > 1)
                {
                    result = Product(result, decimalArray[i]);
                }
                else
                {
                    result = Product(decimalArray[0], decimalArray[1]);
                }
            }

            return result;
        }
    }
}
