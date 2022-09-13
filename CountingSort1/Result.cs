using System.Collections.Generic;
using System;

namespace CountingSort1
{
    class Result
    {
        /*
         * Complete the 'countingSort' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        public static List<int> countingSort(List<int> arr)
        {
            int[] result = new int[arr.Count];

            List<int> resultArr = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                result[i] = 0;
            }

            for (int i = 0; i < arr.Count; i++)
            {
                int num = arr[i];
                result[num] = result[num] + 1;
            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (result[i] != 0)
                    resultArr.Add(result[i]);
            }

            return resultArr;
        }

    }
}
