using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";

            string input = Console.ReadLine();

            MatchCollection foundNames = Regex.Matches(input, pattern);

            foreach (Match name in foundNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
