using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorialNumber = int.Parse(Console.ReadLine());
            BigInteger result = factorialNumber;
            for (int i = factorialNumber -1 ; i >= 1; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
