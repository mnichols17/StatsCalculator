using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations
{
    public static class SampleCorrelation
    {
        public static decimal findSampleCorrelation(int[] xArray, int[] yArray)
        {
            decimal xMean = Mean.findMean(xArray);
            decimal yMean = Mean.findMean(yArray);
            decimal xStandardDev = StandardDeviation.findSD(xArray);
            decimal yStandardDev = StandardDeviation.findSD(yArray);

            decimal stepOne = 0;
            
            decimal result;

            for(int i = 0; i < xArray.Length; i++)
            { 
                stepOne += ((xArray[i] - xMean) * (yArray[i] - yMean));
            }

            decimal stepTwo = stepOne / (xStandardDev * yStandardDev);

            result = (stepTwo / (xArray.Length - 1));

            return result;

        }

        public static decimal findSampleCorrelation(decimal[] xArray, decimal[] yArray)
        {
            decimal xMean = Mean.findMean(xArray);
            decimal yMean = Mean.findMean(yArray);
            decimal xStandardDev = StandardDeviation.findSD(xArray);
            decimal yStandardDev = StandardDeviation.findSD(yArray);

            decimal stepOne = 0;

            decimal result;

            for (int i = 0; i < xArray.Length; i++)
            {
                stepOne += ((xArray[i] - xMean) * (yArray[i] - yMean));
            }

            decimal stepTwo = stepOne / (xStandardDev * yStandardDev);

            result = (stepTwo / (xArray.Length - 1));

            return result;

        }
    }
}
