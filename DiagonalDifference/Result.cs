using System.Collections.Generic;

namespace DiagonalDifference
{
    class Result
    {
        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftToRight = 0;
            int rightToLeft = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (i==j)
                    {
                        leftToRight += arr[i][j];
                    }

                    if ( i+j == arr.Count-1)
                    {
                        rightToLeft += arr[i][j];
                    }
                }
            }
            return leftToRight-rightToLeft;
        }

    }
}
