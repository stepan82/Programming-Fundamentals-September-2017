using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input_Number = int.Parse(Console.ReadLine());
            for (int first = 1; first <= input_Number; first++)
            {
                for (int i = 1; i <= first; i++)
                {
                    Console.Write($"{first} ");
                }
                Console.WriteLine();
            }
        }
    }
}
