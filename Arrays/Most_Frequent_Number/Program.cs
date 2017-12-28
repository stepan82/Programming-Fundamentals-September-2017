using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            int perm = 0;
            int mostFrequent = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > perm && i <= mostFrequent)
                {
                    mostFrequent = arr[i];
                    perm = count;
                }
                count = 0;
            }
            Console.WriteLine(mostFrequent);
        }
    }
}
