using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;

namespace StatOperations
{
    public static class ZScore
    {
        static public decimal score(int x, int[] nums)
        {
            decimal mean = Mean.findMean(nums);
            decimal SD = StandardDeviation.findSD(nums);

            return Division.Quotient((x - mean), SD);
        }

        static public decimal score(decimal x, decimal[] nums)
        {
            decimal mean = Mean.findMean(nums);
            decimal SD = StandardDeviation.findSD(nums);

            return Division.Quotient((x - mean), SD);
        }
    }
}