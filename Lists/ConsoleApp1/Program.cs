using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> emptyString = new List<int>();
            for (int i = 0; i < items.Count; i++)
            {
                if ( items[i] > -1)
                {
                   emptyString.Add(items[i]);
                }
            }

            emptyString.Reverse();
            if (emptyString.Count == 0)
            {

                Console.WriteLine("empty");
            }
            else
            {

                Console.WriteLine(string.Join(" ", emptyString));
            }
        }
    }
}
