using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLogs = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> logRecords = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 1; i <= numberOfLogs; i++)
            {
                var logData = Console.ReadLine().Split(' ').ToArray();
                string addressIP = logData[0];
                string name = logData[1];
                int duration = int.Parse(logData[2]);

                if (!logRecords.ContainsKey(name))
                {
                    logRecords.Add(name, new SortedDictionary<string, int>());
                    logRecords[name].Add(addressIP, duration);
                }

                else if (logRecords.ContainsKey(name))
                {

                    if (logRecords[name].ContainsKey(addressIP))
                    {
                        logRecords[name][addressIP] += duration;
                    }
                    else
                    {
                        logRecords[name].Add(addressIP, duration);
                    }
                }
            }

                foreach (var record in logRecords)
                {
                    var sum = record.Value.Values.Sum();

                    Console.Write("{0}: {1} ", record.Key, sum);
                    Console.Write("[");
                    Console.Write(string.Join(", ", record.Value.Keys));
                    Console.WriteLine("]");
                }

        }
    }
}
