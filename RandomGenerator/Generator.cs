using System;


namespace RandomGenerator
{
    public class Generator
    {
        static public int randomInt(int seed)
        {
            var random = new Random(seed);
            return random.Next();
        }

        static public decimal randomDecimal(int seed)
        {
            var random = new Random(seed);
            return Convert.ToDecimal(random.NextDouble());
        }

        static public int randomRange(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }

        static public int randomRange(int seed, int min, int max)
        {
            var random = new Random(seed);
            return random.Next(min, max);
        }

        static public decimal randomRange(decimal min, decimal max)
        {
            var random = new Random();
            return Convert.ToDecimal(random.NextDouble()) * (max - min) + min;
        }

        static public decimal randomRange(int seed, decimal min, decimal max)
        {
            var random = new Random(seed);
            return Convert.ToDecimal(random.NextDouble()) * (max - min) + min;
        }

        static public int[] randomIntList(int seed, int length)
        {
            int[] list = new int[length];
            for (int i = 0; i < length; i++)
            {
                var random = new Random(seed + i);
                list[i] = random.Next();
            }
            return list;
        }

        static public decimal[] randomDecimalList(int seed, int length)
        {
            decimal[] list = new decimal[length];
            for (int i = 0; i < length; i++)
            {
                var random = new Random(seed + i);
                list[i] = Convert.ToDecimal(random.NextDouble());
            }
            return list;
        }

        static public int[] randomListRangeInt(int popSize, int returnSize)
        {
            int[] nums = new int[returnSize];
            for (int i = 0; i < returnSize; i++)
            {
                nums[i] = randomRange(0, popSize);
            }
            return nums;
        }

        static public decimal[] randomListRangeDecimal(int popSize, int returnSize)
        {
            decimal[] nums = new decimal[returnSize];
            for (int i = 0; i < returnSize; i++)
            {
                nums[i] = randomRange(0M, popSize);
            }
            return nums;
        }

        static public int[] systematicListRangeInt(int popSize, int returnSize)
        {
            int[] nums = new int[returnSize];
            var random = new Random();
            int[] pop = randomIntList(random.Next(), popSize);
            for (int i = 0; i < returnSize; i += popSize % returnSize)
            {
                nums[i] = pop[i];
            }
            return nums;
        }

        static public decimal[] systematicListRangeDecimal(int popSize, int returnSize)
        {
            decimal[] nums = new Decimal[returnSize];
            var random = new Random();
            decimal[] pop = randomDecimalList(random.Next(), popSize);
            for (int i = 0; i < returnSize; i += popSize % returnSize)
            {
                nums[i] = pop[i];
            }
            return nums;
        }
    }
}
