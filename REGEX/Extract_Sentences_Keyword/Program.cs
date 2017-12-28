using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extract_Sentences_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            var tokens = Console.ReadLine().Split(new char[] { '!', '?', '.' }).ToList();

            string pattern = $@"\b\{word}\b";
           

            foreach (var item in tokens)
            {
                Match matches = Regex.Match(item, pattern);
                if (matches.Success)
                {
                    Console.WriteLine(item.Trim());
                }
            }
        }
    }
}
