using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_Given_Range
{
    class Program
    {

        static void Main(string[] args)
        {
          
            int number_2 = int.Parse(Console.ReadLine());
            FindPrimesInRange(1, number_2);
        }
        static void FindPrimesInRange(int startNum, int endNum)
        { 
            if (startNum <= 1)
            {
                startNum = 2;
            }

            List<int> numbers = new List<int>();
            int count = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {

                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    numbers.Add(i);
                }
                count = 0;
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
