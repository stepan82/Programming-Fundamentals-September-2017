using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string input = Console.ReadLine();

            MatchCollection numbersMatch = Regex.Matches(input, pattern);

            foreach (Match number in numbersMatch)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
