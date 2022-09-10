using System;
using System.Collections.Generic;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 3,5,7,9,7,5,3,1 };
            int result = Result.lonelyInteger(arr);
            Console.WriteLine(result);
         } 
    }
}
