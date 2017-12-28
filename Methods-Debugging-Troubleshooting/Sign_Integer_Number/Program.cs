using System;

namespace Sign_Integer_Number
{
    class Program
    {
        static void printNumberSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        static void Main(string[] args)
        {
            int result = int.Parse(Console.ReadLine());
            printNumberSign(result);
        }
    }
}
