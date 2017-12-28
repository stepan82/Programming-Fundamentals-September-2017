using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string wordMatch = Console.ReadLine().ToLower();
            int matches = 0;
            int indexer = text.IndexOf(wordMatch);

            while (indexer != -1)
            {
                matches++;
                indexer = text.IndexOf(wordMatch, indexer + 1);
            }

            Console.WriteLine(matches);
        }
    }
}
