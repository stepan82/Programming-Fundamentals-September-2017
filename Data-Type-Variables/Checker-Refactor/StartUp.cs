using System;

namespace Checker_Refactor
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= inputNumber; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime}");
            }

        }
    }
}
