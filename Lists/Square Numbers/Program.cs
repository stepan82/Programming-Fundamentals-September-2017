using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToList();
            List<int> newResult = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == Math.Truncate(Math.Sqrt(input[i])))
                {
                    newResult.Add(input[i]);
                }
            }
            var result = newResult.OrderByDescending(x => x);

           
                Console.WriteLine(string.Join(" ", result));
            
        }
    }
}
