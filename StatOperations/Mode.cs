using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;

namespace StatOperations
{
    public static class Mode
    {
        static public List<int> findMode(int[] nums)
        {
            Dictionary<int, int> numList = new Dictionary<int, int>();
            int max = 0;
            List<int> modes = new List<int>();

            foreach (int num in nums)
            {
                if (numList.ContainsKey(num))
                {
                    numList[num] += 1;
                }
                else
                {
                    numList[num] = 1;
                }
            }

            foreach (int num in numList.Keys)
            {
                if (numList[num] > max)
                {
                    max = numList[num];
                    modes = new List<int>();
                    modes.Add(num);
                }
                else if (numList[num] == max)
                {
                    modes.Add(num);
                }
            }

            return modes;
        }

        static public List<decimal> findMode(decimal[] nums)
        {
            Dictionary<decimal, int> numList = new Dictionary<decimal, int>();
            int max = 0;
            List<decimal> modes = new List<decimal>();

            foreach (decimal num in nums)
            {
                if (numList.ContainsKey(num))
                {
                    numList[num] += 1;
                }
                else
                {
                    numList[num] = 1;
                }
            }

            foreach (decimal num in numList.Keys)
            {
                if (numList[num] > max)
                {
                    max = numList[num];
                    modes = new List<decimal>();
                    modes.Add(num);
                }
                else if (numList[num] == max)
                {
                    modes.Add(num);
                }
            }

            return modes;
        }
    }
}