using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string[] firstInput = firstString.Split(' ');
            string[] secondInput = secondString.Split(' ');
            int[] numberArreys_1 = new int[firstInput.Length];
            int[] numberArreys_2 = new int[secondInput.Length];

            for (int i = 0; i < numberArreys_1.Length; i++)
            {
                numberArreys_1[i] = int.Parse(firstInput[i]);
            }

            for (int i = 0; i < numberArreys_2.Length; i++)
            {
                numberArreys_2[i] = int.Parse(secondInput[i]);
            }

            if (numberArreys_1.Length == numberArreys_2.Length)
            {
                for (int i = 0; i < numberArreys_1.Length; i++)
                {
                    Console.Write($"{numberArreys_1[i] + numberArreys_2[i]} ");
                }
            }
            else if (numberArreys_1.Length < numberArreys_2.Length)
            {
                for (int i = 0; i < numberArreys_2.Length; i++)
                {
                     Console.Write($"{numberArreys_1[i % numberArreys_1.Length] + numberArreys_2[i % numberArreys_2.Length]} ");
                }
            }

            else
            {
                 for (int i = 0; i < numberArreys_1.Length; i++)
                {
                     Console.Write($"{numberArreys_1[i % numberArreys_1.Length] + numberArreys_2[i % numberArreys_2.Length]} ");
                }
            }

        }
    }
}
