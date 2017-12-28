using System;

namespace Comparing_Floats
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double epsilon = 0.000001;
            double result = Math.Abs(firstNumber - secondNumber);
            if (result < epsilon)
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
