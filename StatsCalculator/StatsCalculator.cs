using System;
using BasicCalculator;

namespace StatsCalculator
{
    public class StatsCalculator: BasicCalculator.BasicCalculator
    {
        private dynamic _result;

        public dynamic Mean(dynamic arrayList)
        {
            Result = StatOperations.Mean.findMean(arrayList);
            return Result;
        }

        public dynamic Median(dynamic arrayList)
        {
            Result = StatOperations.Median.findMedian(arrayList);
            return Result;
        }

        public dynamic Mode(dynamic arrayList)
        {
            Result = StatOperations.Mode.findMode(arrayList);
            return Result;
        }

        public dynamic Variance(dynamic arrayList)
        {
            Result = StatOperations.Variance.findVariance(arrayList);
            return Result;
        }

        public dynamic StandardDeviation(dynamic arrayList)
        {
            Result = StatOperations.StandardDeviation.findSD(arrayList);
            return Result;
        }

        public dynamic MeanDeviation(dynamic arrayList)
        {
            Result = StatOperations.MeanDeviation.findMeanDeviation(arrayList);
            return Result;
        }

        public dynamic Quartiles(dynamic arrayList)
        {
            Result = StatOperations.Quartiles.findQuartiles(arrayList);
            return Result;
        }

        public dynamic SampleCorrelation(dynamic xArray, dynamic yArray)
        {
            Result = StatOperations.SampleCorrelation.findSampleCorrelation(xArray, yArray);
            return Result;
        }

        public dynamic Skewness(dynamic arrayList)
        {
            Result = StatOperations.Skewness.findSkew(arrayList);
            return Result;
        }

        public dynamic ZScore(dynamic x, dynamic arrayList)
        {
            Result = StatOperations.ZScore.score(x, arrayList);
            return Result;
        }




    }
}
