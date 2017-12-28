using System;

namespace Prime_Checker_Method
{
   public class StartUp
    {
      public  static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = PrimeTool.isPrime(i);
            }
        }
    }
}
