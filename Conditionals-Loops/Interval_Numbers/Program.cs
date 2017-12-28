namespace Interval_Numbers
{
    using System;
    public class Program
    {
       public static void Main(string[] args)
        {
            int number_1 = int.Parse(Console.ReadLine());
            int number_2 = int.Parse(Console.ReadLine());
            if (number_1 < number_2)
            {
                for (int i = number_1; i <= number_2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = number_2; i <= number_1; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
