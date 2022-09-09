using System;
using System.IO;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {        
            string s = "07:05:45PM";
            string result = Result.timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
