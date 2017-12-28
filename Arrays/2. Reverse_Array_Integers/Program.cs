using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse_Array_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] permResult = new int[inputNumbers.Length];
            int[] result = new int[inputNumbers.Length];

            for (int i = 1; i <= rotations; i++)
            {
                for (int j = 0; j < inputNumbers.Length; j++)
                {
                    var position = (j + i) % inputNumbers.Length;
                    permResult[position] = inputNumbers[j];
                    result[position] += permResult[position];
                }     
            }
            Console.WriteLine(string.Join(" ",  result));
        }
    }
}
