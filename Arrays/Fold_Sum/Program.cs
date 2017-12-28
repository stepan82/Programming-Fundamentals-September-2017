using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result = new int[inputNumbers.Length / 2];
            var numbers = inputNumbers.Length / 4;
            for (int i = 0; i < numbers; i++)
            {
                result[i] = inputNumbers[i];

            }

            for (int i = inputNumbers.Length - 1; i > inputNumbers.Length -3; i--)
            {
                result[i / 3] = inputNumbers[i];
            }

          
            

            

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
