using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_Odds
{
    class Program
    {
        static int getSumEven(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                var result = n % 10;
                if (result % 2 == 0)
                {
                    sum += result;
                }
                int nextNumber = n / 10;
                n = nextNumber;
            }
            return sum;
        }
        static int getSumOdd(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                var result = n % 10;
                if (result % 2 != 0)
                {
                    sum += result;
                }
                int nextNumber = n / 10;
                n = nextNumber;
            }
            return sum;
        }

    static int getResultOfOddEven(int n)
        {
            int sumEven = getSumEven(n);
            int sumOdd = getSumOdd(n);
            int result = (sumEven * sumOdd);
            return result;
        }



        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(getResultOfOddEven(Math.Abs(number)));
        }
    }
}
