using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Book_Library
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] reader = File.ReadAllLines("input_1.txt");

            int numberOfBooks = int.Parse(reader[0]);

            SortedDictionary<string, DateTime> booksData = new SortedDictionary<string, DateTime>();

            for (int i = 1; i < reader.Length-1; i++)
            {
                var tokens = reader[i].Split(' ').ToArray();

                string bookName = tokens[0];

                var convertedSringToDate = DateTime.ParseExact(tokens[3], "d.M.yyyy", CultureInfo.InvariantCulture);


                if (!booksData.ContainsKey(bookName))
                {
                    booksData.Add(bookName, convertedSringToDate);
                }
                else
                {
                    booksData[bookName] = convertedSringToDate;
                }

            }


            var convertYear = DateTime.ParseExact(reader[numberOfBooks + 1], "d.M.yyyy", CultureInfo.InvariantCulture);


            var result = booksData.OrderBy(i => i.Value).ThenBy(n => n.Key);

            using (StreamWriter writer = new StreamWriter("output_1.txt"))
            {
                foreach (var book in result)
                {
                    if (book.Value > convertYear)
                    {
                        writer.WriteLine("{0} -> {1:dd.MM.yyyy}", book.Key, book.Value);
                    }
                }
            }               
        }
    }
}

