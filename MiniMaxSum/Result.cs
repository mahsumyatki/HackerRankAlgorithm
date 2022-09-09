using System;
using System.Collections.Generic;

namespace MiniMaxSum
{
    class Result
    {
        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        public static void miniMaxSum(List<int> arr)
        {
            long sum = 0;
            long min = long.MaxValue;//bir dizide min değer bulunurken alacağı default max değer atanır.
            long max = long.MinValue;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
                min = Math.Min(min, arr[i]);
                max = Math.Max(max, arr[i]);
            }

            Console.WriteLine((sum - max) + " " + (sum - min));
        }
    }
}
