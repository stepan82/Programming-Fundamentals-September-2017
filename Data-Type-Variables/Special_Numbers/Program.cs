using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int takova = 0;
            bool result = false;
            for (int i = 1; i <= number; i++)
            {
                takova = i;
                while (i > 0)
                {
                    totalSum += i % 10;
                    i = i / 10;
                }
                result = (totalSum == 5) || (totalSum == 7) || (totalSum == 11);
                Console.WriteLine($"{takova} -> {result}");
            }
        }
    }
}
