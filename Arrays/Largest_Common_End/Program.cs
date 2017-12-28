using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] arr_2 = Console.ReadLine().Split(' ').ToArray();
            var countRight = 0;
            var countLeft = 0;
            for (int i = 0; i < Math.Min(arr.Length, arr_2.Length); i++)
            {
                if (arr[i] == arr_2[i])
                {
                    countRight++;
                }
                if (arr[arr.Length - 1 - i] == arr_2[arr_2.Length - 1 - i])
                    countLeft++;
            }
            if (countRight >= countLeft)
                Console.WriteLine(countRight);
            else
                Console.WriteLine(countLeft);
        }
    }
}
