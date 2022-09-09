using System.Collections.Generic;

namespace SparseArrays
{
    class Result
    {

        /*
         * Complete the 'matchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY strings
         *  2. STRING_ARRAY queries
         */

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < queries.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < strings.Count; j++)
                {
                    if (queries[i].Contains(strings[j]))
                    {
                        count++;
                    }
                }
                result.Add(count);
                count = 0;
            }

            return result;
        }

    }
}
