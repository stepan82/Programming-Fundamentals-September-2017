using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_By_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (var num in arr)
            {
                foreach (var nums in arr)
                {
                    if (num - nums == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
