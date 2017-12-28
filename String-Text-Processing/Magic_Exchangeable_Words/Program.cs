using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').ToArray();

            var firstWord = tokens[0].ToCharArray().Distinct().ToArray();
            var secondWord = tokens[1].ToCharArray().Distinct().ToArray();

            if (firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
