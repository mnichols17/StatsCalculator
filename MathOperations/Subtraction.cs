namespace MathOperations
{
    public static class Subtraction
    {
        static public int Difference(int a, int b)
        {
            return a - b;
        }

        static public decimal Difference(decimal a, decimal b)
        {
            return a - b;
        }

        static public int Difference(int[] intArray)
        {
            int result = intArray[0];

            for (var i = 1; i < intArray.Length; i++)
            {
                result = Difference(result, intArray[i]);
            }

            return result;
        }

        static public decimal Difference(decimal[] decimalArray)
        {
            decimal result = decimalArray[0];

            for (var i = 1; i < decimalArray.Length; i++)
            {
                result = Difference(result, decimalArray[i]);
            }

            return result;
        }
    }
}