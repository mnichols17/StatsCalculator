using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public static class Radical
    {
        static public decimal rootAns(int radicant, int degree)
        {
            double rad = Convert.ToDouble(radicant);
            double deg = Convert.ToDouble(degree);

            decimal result = Convert.ToDecimal(Math.Pow(rad, 1 / deg));
            return result;
        }

        static public decimal rootAns(decimal radicant, decimal degree)
        {
            double rad = Convert.ToDouble(radicant);
            double deg = Convert.ToDouble(degree);
            
            decimal result =Convert.ToDecimal(Math.Pow(rad, 1 / deg));
            return result;
        }
    }
}
