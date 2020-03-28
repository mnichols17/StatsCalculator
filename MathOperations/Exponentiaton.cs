using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public static class Exponentiaton
    {
        static public decimal Power(int baseNum, int exponent)
        {
            decimal result = Convert.ToDecimal(Math.Pow(baseNum, exponent));
            return result;
        }

        static public decimal Power(decimal baseNum, decimal exponent)
        {
            double bNum = Convert.ToDouble(baseNum);
            double exp = Convert.ToDouble(exponent);

            decimal result = Convert.ToDecimal(Math.Pow(bNum, exp));
            return result;
        }
    }
}
