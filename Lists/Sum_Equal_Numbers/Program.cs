using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().
               Split(' ').
               Select(double.Parse).
               ToList();

            for (int i = 0; i <= inputNums.Count -1; i++)
            {
               double isLast = inputNums.Count - 1;
                if (i == isLast)
                {
                    break;
                }
                double result = 0;
                if (inputNums[i] == inputNums[i + 1])
                {
                    result += inputNums[i] + inputNums[i + 1];
                    inputNums[i] = result;
                    inputNums.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
