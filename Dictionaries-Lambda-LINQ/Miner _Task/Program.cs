using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner__Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var minerCounting = new Dictionary<string, long>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }

                long quantity = int.Parse(Console.ReadLine());

                if (minerCounting.ContainsKey(input))
                {
                    minerCounting[input] += quantity;
                }
                else
                {
                    minerCounting.Add(input, quantity);
                }
            }
            foreach (var item in minerCounting)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
