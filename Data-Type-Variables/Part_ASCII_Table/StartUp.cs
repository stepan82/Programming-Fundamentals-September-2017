using System;

namespace Part_ASCII_Table
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());
            for (int i = startNumber; i <= stopNumber; i++)
            {
                char result = (char)i;
                Console.Write($"{result} ");
            }
        }
    }
}
