using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([0]{1}[x]{1})?[0-9A-F]+\b";

            string input = Console.ReadLine();

            var numberMatches = Regex.Matches(input, pattern).Cast<Match>().Select(c => c.Value).ToArray();

            Console.WriteLine(string.Join(" ", numberMatches));
        }
    }
}
