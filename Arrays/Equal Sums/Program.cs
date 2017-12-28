using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            if (inputNumbers.Length == 1 || inputNumbers.Min() < 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 1; i < inputNumbers.Length - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumLeft += inputNumbers[j];
                }
                for (int k = i + 1; k <= inputNumbers.Length - 1; k++)
                {
                    sumRight += inputNumbers[k];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
                    sumLeft = 0;
                    sumRight = 0;      
            }
           
                Console.WriteLine("no");
           
           
        }
    }
}
