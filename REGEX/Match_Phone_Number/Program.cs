using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+{1}[3][5][9](\s*|\-*)[2]\1\d{3}\1\d{4}\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            var count = matches.Count;
            foreach (Match item in matches)
            {
                if (--count > 0)
                {
                    Console.Write($"{item.Value}, ");
                }
                else
                {
                    Console.Write($"{item.Value}");
                }
                   

            }
            Console.WriteLine();

        }
    }
}
