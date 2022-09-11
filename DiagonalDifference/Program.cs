using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>() {
                new List<int>(){1,2,5},
                new List<int>(){4,5,6},
                new List<int>(){7,8,9}
            };

            int result = Result.diagonalDifference(arr);
            Console.WriteLine(result);
        }
    }
}
