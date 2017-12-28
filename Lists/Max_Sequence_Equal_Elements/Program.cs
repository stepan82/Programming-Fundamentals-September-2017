using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 0;
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestStart = start;
                        bestLength = length;
                    }
                }
                else
                {
                    start = i;
                    length = 1;
                }
            }
            if (start == arr.Count -1 && length == 1)
            {
                Console.Write($"{arr[0]}");
                Console.WriteLine();
            }
            
            else
            for (int i = 1; i <=bestLength; i++)
            {
                Console.Write($"{arr[bestStart]} ");
            }
            Console.WriteLine();
        }
    }
}
