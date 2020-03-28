using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;

namespace StatOperations
{
    public static class Median
    {
        static public decimal findMedian(int[] nums)
        {
            Array.Sort(nums);
            if (nums.Length > 2)
            {
                if (nums.Length % 2 != 0)
                {
                    return nums[(nums.Length / 2)];
                }
                else
                {
                    return Division.Quotient(nums[nums.Length / 2] + nums[(nums.Length / 2) - 1], 2);
                }
            }
            return 0;
        }

        static public decimal findMedian(decimal[] nums)
        {
            Array.Sort(nums);
            if (nums.Length > 2)
            {
                if (nums.Length % 2 != 0)
                {
                    return nums[(nums.Length / 2)];
                }
                else
                {
                    return Division.Quotient(nums[nums.Length / 2] + nums[(nums.Length / 2) - 1], 2);
                }
            }
            return 0;
        }
    }
}