using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;

namespace StatOperations
{
    public static class Variance
    {
        static public decimal findVariance(int[] nums)
        {
            decimal total = 0;
            decimal mean = Mean.findMean(nums);

            foreach (int num in nums)
            {
                decimal temp = Math.Abs(mean - num);
                total += Multiplication.Product(temp, temp);
            }

            return Division.Quotient(total, nums.Length);
        }

        static public decimal findVariance(decimal[] nums)
        {
            decimal total = 0;
            decimal mean = Mean.findMean(nums);

            foreach (decimal num in nums)
            {
                decimal temp = Math.Abs(mean - num);
                total += Multiplication.Product(temp, temp);
            }

            return Division.Quotient(total, nums.Length);
        }
    }
}