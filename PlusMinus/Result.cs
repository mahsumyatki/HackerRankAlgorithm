using System;
using System.Collections.Generic;

namespace PlusMinus
{
    class Result
    {
        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            float positiveCount = 0;
            float negativeCount = 0;
            float zeroCount = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                else if (arr[i] < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }

            Console.WriteLine("Positive : "+positiveCount / arr.Count);
            Console.WriteLine("Negative : "+negativeCount / arr.Count);
            Console.WriteLine("Zero : "+zeroCount / arr.Count);
        }
    }
}
