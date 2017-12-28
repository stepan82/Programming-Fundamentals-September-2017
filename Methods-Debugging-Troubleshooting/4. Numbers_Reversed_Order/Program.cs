using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numbers_Reversed_Order
{
    class Program
    {
        static string ReverseString(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = ReverseString(input);
            Console.WriteLine(result);
        }
    }
}
