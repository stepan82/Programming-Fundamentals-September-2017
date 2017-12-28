using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Min_Max_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] values = new int[input];
            for (int i = 0; i < input; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
            }
            var sum = values.Sum();
            var min = values.Min();
            var max = values.Max();
            var average = values.Average();
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
