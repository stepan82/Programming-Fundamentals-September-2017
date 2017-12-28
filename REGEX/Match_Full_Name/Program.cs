using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputNames = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";


            MatchCollection foundNames = Regex.Matches(inputNames, pattern);

            foreach (Match name in foundNames)
            {
                Console.Write($"{name.Value} ");
            }
            Console.WriteLine();
        }
    }
}
