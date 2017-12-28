using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> namesAndComments = new SortedDictionary<string, List<string>>();

            SortedDictionary<string, List<DateTime>> namesAndDates = new SortedDictionary<string, List<DateTime>>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ', ',').ToArray();

                if (tokens[0] == "end")
                {
                    break;
                }

                string name = tokens[0];

                if (tokens.Length == 1 && namesAndDates.ContainsKey(name))
                {
                    continue;
                }

                else if (tokens.Length == 1 && !namesAndDates.ContainsKey(name))
                {
                    namesAndDates.Add(name, new List<DateTime>());
                }

                else if (!namesAndDates.ContainsKey(name))
                {
                    namesAndDates.Add(name, new List<DateTime>());
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        namesAndDates[name].Add(DateTime.ParseExact(tokens[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }

                else if (namesAndDates.ContainsKey(name))
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        namesAndDates[name].Add(DateTime.ParseExact(tokens[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }
            }

            while (true)
            {
                string[] tokens_2 = Console.ReadLine().Split('-').ToArray();

                if (tokens_2[0] == "end of comments")
                {
                    break;
                }

                string name = tokens_2[0];
                string comment = tokens_2[1];

                if (!namesAndDates.ContainsKey(name))
                {
                    continue;
                }

                else if (namesAndDates.ContainsKey(name) && !namesAndComments.ContainsKey(name))
                {
                    namesAndComments.Add(name, new List<string>());
                }
                
                    namesAndComments[name].Add(comment);
            }

            foreach (var name in namesAndDates)
            {
                Console.WriteLine(name.Key);
                Console.WriteLine("Comments:");
                foreach (var item in namesAndComments)
                {
                    if (name.Key == item.Key)
                    {
                        foreach (var comment in item.Value)
                        {
                            Console.WriteLine($"- {comment}");
                        }
                    }
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in name.Value.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}
