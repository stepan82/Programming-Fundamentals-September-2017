using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number_1 = int.Parse(Console.ReadLine());
            var number_2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number_1} + {number_2} = {number_1 + number_2}");
        }
    }
}
