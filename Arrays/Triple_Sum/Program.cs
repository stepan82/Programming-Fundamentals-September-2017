using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr.Contains(arr[i] + arr[j]))
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[i] + arr[j]}");
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }   
        }
    }
}
