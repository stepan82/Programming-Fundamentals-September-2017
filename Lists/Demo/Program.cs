using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int shifts = int.Parse(Console.ReadLine());
            for (int i = 0; i < shifts; i++)
            {
                numbers.Add(numbers[i]);
               
            }
            numbers.RemoveRange(0, shifts);

        }
    }
}