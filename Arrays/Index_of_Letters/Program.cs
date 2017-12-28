using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = 
                {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            int index = 0;
            string input = Console.ReadLine();
            char[] inputChar = input.ToCharArray();
            
            foreach (var ch in inputChar)
            {
                if (alphabet.Contains(ch))
                {
                    Console.WriteLine($"{ch} -> {index = Array.IndexOf(alphabet, ch)}");
                }
            }
          

        }
    }
}
