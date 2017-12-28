using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Book_Library
{

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            SortedDictionary<string, DateTime> booksData = new SortedDictionary<string, DateTime>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();

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

            string year = Console.ReadLine();

            var convertYear = DateTime.ParseExact(year, "d.M.yyyy", CultureInfo.InvariantCulture);


            var result = booksData.OrderBy(i => i.Value).ThenBy(n => n.Key);

            foreach (var book in result)
            {
                if (book.Value > convertYear)
                {
                    Console.WriteLine("{0} -> {1:dd.MM.yyyy}", book.Key, book.Value);
                }               
            }
        }
    }
}

