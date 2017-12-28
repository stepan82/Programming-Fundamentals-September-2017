using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int reverse = 0;
                while (numbers[i] > 0)
                {
                    int rem = numbers[i] % 10;
                    reverse = (reverse * 10) + rem;
                    numbers[i] = numbers[i] / 10;
                }
                result += reverse;
            }

            Console.WriteLine(result);
        }
    }
}
