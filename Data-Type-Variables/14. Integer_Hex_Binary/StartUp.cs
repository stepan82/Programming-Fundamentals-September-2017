using System;

namespace _14.Integer_Hex_Binary
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var hexadecimal = Convert.ToString(input, 16);
            var hexaResult = hexadecimal.ToUpper();
            var binary = Convert.ToString(input, 2);
            Console.WriteLine(hexaResult);
            Console.WriteLine(binary);
        }
    }
}
