using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;

namespace StatOperations
{
    public static class Quartiles
    {
        static public decimal[] findQuartiles(int[] nums) // array larger than size of 1 and evens
        {
            Array.Sort(nums);
            decimal[] quartiles = new decimal[3];
            if (nums.Length % 4 == 3)
            {
                quartiles[0] = nums[(nums.Length / 2) / 2];
                quartiles[1] = nums[nums.Length / 2];
                quartiles[2] = nums[(nums.Length / 2) + ((nums.Length / 2) / 2 + 1)];

            }
            else if (nums.Length % 2 != 0)
            {
                quartiles[0] = Division.Quotient(nums[(nums.Length / 2) / 2] + nums[((nums.Length / 2) / 2 - 1)], 2);
                quartiles[1] = nums[nums.Length / 2];
                int temp = (nums.Length / 2) + ((nums.Length / 2) / 2);
                quartiles[2] = Division.Quotient(nums[temp] + nums[temp + 1], 2);
            }
            else
            {
                quartiles[1] = nums[nums.Length / 2];
            }
            return quartiles;
        }

        static public double findQuartiles(decimal[] nums)
        {
            return 0;
        }
    }
}
