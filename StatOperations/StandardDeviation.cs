using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;

namespace StatOperations
{
    public static class StandardDeviation
    {
        static public decimal findSD(int[] nums)
        {
            return Convert.ToDecimal(Math.Round(Radical.rootAns(Variance.findVariance(nums), 2), 7));
        }

        static public decimal findSD(decimal[] nums)
        {
            return Convert.ToDecimal(Math.Round(Radical.rootAns(Convert.ToDecimal(Variance.findVariance(nums)), 2), 7));
        }
    }
}