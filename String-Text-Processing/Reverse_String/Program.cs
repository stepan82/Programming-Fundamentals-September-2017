using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var input_2 = input.ToCharArray();

            StringBuilder reverseText = new StringBuilder();
            for (int i = input_2.Length-1; i >= 0; i--)
            {
               reverseText.Append(input_2[i]);
            }

            Console.WriteLine(reverseText);
           //char[] inputArray = input.ToCharArray();
           //var reverseArray = inputArray.Reverse();
            //Console.WriteLine(string.Join("", reverseArray));
        }
    }
}
