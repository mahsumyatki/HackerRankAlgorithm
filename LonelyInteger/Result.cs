using System;
using System.Collections.Generic;

namespace LonelyInteger
{
    class Result
    {
        /*
         * Complete the 'lonelyinteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */
        public static int lonelyInteger(List<int> arr)
        {
            var result = 0;
            foreach (var item in arr)
            {
                result ^= item;
            }

            return result;
        }

    }
}
