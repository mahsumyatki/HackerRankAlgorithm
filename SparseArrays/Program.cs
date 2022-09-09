using System;
using System.Collections.Generic;

namespace SparseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() {
                "abcde",
                "sdaklfj",
                "asdjf",
                "na",
                "basdn",
                "sdaklfj",
                "asdjf",
                "na",
                "asdjf",
                "na",
                "basdn",
                "sdaklfj",
                "asdjf"
            };
            List<string> queries = new List<string>() {
                "abcde",    
                "sdaklfj",
                "asdjf",
                "na",
                "basdn"
            };

            List<int> result = Result.matchingStrings(strings, queries);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
