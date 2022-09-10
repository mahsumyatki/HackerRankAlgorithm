using System;

namespace FlippingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine().Trim());
            for (int countItr = 0; countItr < count; countItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                long result = Result.flippingBits(n);

                Console.WriteLine(result);
            }
        }
    }
}
