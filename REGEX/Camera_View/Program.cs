using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int skip = tokens[0];
            int take = tokens[1];
            string text = Console.ReadLine();

            string pattern = @"\|<(\\w{" + skip + "})(\\w{0," + take + "})";
         
            MatchCollection matched = Regex.Matches(text, pattern);
            List<string> output = new List<string>();
            foreach (Match m in matched)
            {
                output.Add(m.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", output));



        }
    }
}
