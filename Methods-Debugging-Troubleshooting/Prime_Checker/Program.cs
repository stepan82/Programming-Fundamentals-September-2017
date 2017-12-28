using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static long GetPrime(long input)
        {
            long count = 0;
            for (long i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            long inputNumber = long.Parse(Console.ReadLine());
            long getPrime = GetPrime(inputNumber);
            if (inputNumber < 2)
            {
                Console.WriteLine("False");
            }
            else if (getPrime == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
