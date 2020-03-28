using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations
{
    public static class MeanDeviation
    {
        static public decimal findMeanDeviation(int[] arrayList) 
        {
            decimal mean = Mean.findMean(arrayList);
            decimal[] meanList = new decimal[arrayList.Length];

            for (int i = 0; i < arrayList.Length; i++)
            {
                meanList[i] = arrayList[i] - mean;    
            }

            decimal result = Mean.findMean(meanList);

            return result;
        }

        static public decimal findMeanDeviation(decimal[] arrayList)
        {
            decimal mean = Mean.findMean(arrayList);
            decimal[] meanList = new decimal[arrayList.Length];

            for (int i = 0; i < arrayList.Length; i++)
            {
                meanList[i] = arrayList[i] - mean;
            }

            decimal result = Mean.findMean(meanList);

            return result;
        }
    }
}
