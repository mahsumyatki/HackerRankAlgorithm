using System;
using System.Globalization;

namespace TimeConversion
{
    class Result
    {
        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */
        public static string timeConversion(string s)
        {
            var date = DateTime.ParseExact(s,"hh:mm:sstt",CultureInfo.InvariantCulture);
            return $"{date:HH:mm:ss}";
        }

    }
}
