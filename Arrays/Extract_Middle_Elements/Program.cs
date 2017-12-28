using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int evenIndex_1 = arr.Length / 2 - 1;
            int evenIndex_2 = arr.Length / 2;
            int oddIndex_1 = arr.Length / 2 - 1;
            int oddIndex_2 = arr.Length / 2;
            int oddIndex_3 = arr.Length / 2 + 1;
            

            if (arr.Length == 1)
            {
                Console.WriteLine($"{arr[0]}");
            }

            else if (arr.Length % 2 == 0)
            {
                Console.WriteLine($"{arr[evenIndex_1]}, {arr[evenIndex_2]}");
            }

            else 
            {
                Console.WriteLine($"{arr[oddIndex_1]}, {arr[oddIndex_2]}, {arr[oddIndex_3]}");
            }
        }
    }
}
