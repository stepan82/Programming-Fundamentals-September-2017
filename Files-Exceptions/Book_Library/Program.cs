using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Book_Library
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] readFile = File.ReadAllLines("input_1.txt");

            int numberOfBooks = int.Parse(readFile[0]);

            SortedDictionary<string, decimal> booksData = new SortedDictionary<string, decimal>();

            for (int i = 1; i < readFile.Length; i++)
            {
                var tokens = readFile[i].Split(' ').ToArray();

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

            using (StreamWriter writer = new StreamWriter("output_1.txt"))
            {
                foreach (var author in result)
                {
                    
                    writer.WriteLine($"{author.Key} -> {author.Value:F2}");
                }
            }
        }
    }
}

