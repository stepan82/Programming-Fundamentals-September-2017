using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
       static int GetFibonacciRange(int number)
       {
            var f0 = 1;
            var f1 = 1;
            for (var i = 1; i <= number - 1; i++)
            {
                var fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            return f1;

        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = GetFibonacciRange(input);
            Console.WriteLine(result);
        }
    }
}
