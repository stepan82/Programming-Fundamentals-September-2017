using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorialNumber = int.Parse(Console.ReadLine());

               BigInteger result_1 = factorialNumber;
               for (int i = factorialNumber - 1; i >= 1; i--)
               {
                   result_1 *= i;
               }
               BigInteger total = NumberOfZeros(result_1);
               Console.WriteLine(total);

        }

      static BigInteger NumberOfZeros (BigInteger result)
      {
         int zerosCount = 0;
         BigInteger currentResult = result;
         while (currentResult % 10 == 0)
         {
            
             zerosCount++;
             BigInteger number_2 = currentResult / 10;
             
           currentResult = number_2;
         }
         return zerosCount;
      }
    }
}
