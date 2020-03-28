using System;
using RandomGenerator;

namespace SamplingOperations
{
    public class Simple
    {
        static public int[] randomSamplingInt(int popSize, int returnSize)
        {
            return Generator.randomListRangeInt(popSize, returnSize);
        }

        static public decimal[] randomSamplingDecimal(int popSize, int returnSize)
        {
            return Generator.randomListRangeDecimal(popSize, returnSize);
        }
    }
}
