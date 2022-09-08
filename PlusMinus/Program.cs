using System.Collections.Generic;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            // List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> arr = new List<int>() { -4, 3, -9, 0, 4, 1 };

            Result.plusMinus(arr);
        }
    }
}
