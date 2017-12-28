using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().
               Split(' ').
               Select(int.Parse).
               ToList();
               inputNums.Sort();

            inputNums.Sort();
            
            var maxResult = 1;
            for (int i = 0; i <= inputNums.Count - 1; i++)
            {
                var isLast = inputNums.Count - 1;
                if (i == isLast)
                {
                    Console.WriteLine($"{inputNums[i]} -> {maxResult}");
                    break;
                }
                if (inputNums[i] == inputNums[i + 1])
                {
                  
                    maxResult++;
                }
                else if (inputNums[i] != inputNums[i + 1])
                {
                    Console.WriteLine($"{inputNums[i]} -> {maxResult}");

                    maxResult = 1;
                }      
            }
        }
    }
}
