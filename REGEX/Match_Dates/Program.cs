using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string pattern = @"(?<day>\b\d{2})(?<separators>\/|\.|-)*(?<month>[JFMASOND]{1}[a-z]{2})\2(?<year>\d{4})\b";

            MatchCollection matchDates = Regex.Matches(input, pattern);

            foreach (Match date in matchDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
