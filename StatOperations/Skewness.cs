using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathOperations;

namespace StatOperations
{
    public static class Skewness
    {
        static public string findSkew(int[] nums)
        {
            decimal mean = Mean.findMean(nums);
            decimal median = Median.findMedian(nums);
            if (Mode.findMode(nums).Count == 1)
            {
                decimal mode = Mode.findMode(nums).First();
                if (mean > mode && median > mode)
                {
                    return "Positive Skewness";
                }
                else if (mode > median && mode > mean)
                {
                    return "Negative Skewness";
                }
            }

            if (mean > median)
            {
                return "Likely a Positive Skewness";
            }
            else
            {
                return "Likely a Negative Skewness";
            }
        }

        static public string findSkew(decimal[] nums)
        {
            decimal mean = Mean.findMean(nums);
            decimal median = Median.findMedian(nums);
            if (Mode.findMode(nums).Count == 1)
            {
                decimal mode = Mode.findMode(nums).First();
                if (mean > mode && median > mode)
                {
                    return "Positive Skewness";
                }
                else if (mode > median && mode > mean)
                {
                    return "Negative Skewness";
                }
            }

            if (mean > median)
            {
                return "Likely a Positive Skewness";
            }
            else
            {
                return "Likely a Negative Skewness";
            }
        }
    }
}