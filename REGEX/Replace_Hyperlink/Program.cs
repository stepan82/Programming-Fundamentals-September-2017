using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Replace_Hyperlink
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            while (input != "end")
            {
                string pattern = @"<{1}a{1}.*?href.*?=(.*)>(.*?)<\/a{1}>{1}";
                string replace = @"[URL href=$1]$2[/URL]";

                string replaced = Regex.Replace(input, pattern, replace);

                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }
        }
    }
}
