using System;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int odd = 0;
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    odd += number;
                    break;
                }
            }
            Console.WriteLine($"The number is: {Math.Abs(odd)}");
        }
    }
}

