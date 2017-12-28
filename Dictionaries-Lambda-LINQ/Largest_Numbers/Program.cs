using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().
               Split(' ').
               Select(int.Parse).
               ToList();
            var result = input.OrderByDescending(x => x).Take(3);
            Console.Write(string.Join(" ", result));
            Console.WriteLine();
        }
    }
}
