using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;

namespace StatOperations
{
    public static class Mean
    {
        static public decimal findMean(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return Division.Quotient(sum, nums.Length);
        }

        static public decimal findMean(decimal[] nums)
        {
            decimal sum = 0;
            foreach (decimal num in nums)
            {
                sum += num;
            }
            return Division.Quotient(sum, nums.Length);
        }
    }
}