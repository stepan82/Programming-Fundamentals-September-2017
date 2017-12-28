using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library
{

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            SortedDictionary<string, decimal> booksData = new SortedDictionary<string, decimal>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();

                string authorName = tokens[1];
                decimal price = decimal.Parse(tokens[5]);
                if (!booksData.ContainsKey(authorName))
                {
                    booksData.Add(authorName, 0.0M);
                    booksData[authorName] += price;
                }
                else
                {
                    booksData[authorName] += price;
                }
            }
            var result = booksData.OrderByDescending(i => i.Value).ThenBy(n => n.Key);
            foreach (var author in result)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }

        }
    }
}

