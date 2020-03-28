using System;
using RandomGenerator;

namespace SamplingOperations
{
    public class Systematic
    {
        static public int[] sampling(int popSize, int returnSize)
        {
            return Generator.randomListRangeInt(popSize, returnSize);
        }
    }
}
