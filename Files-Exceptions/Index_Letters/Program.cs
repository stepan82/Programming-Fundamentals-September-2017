using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Index_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet =
                {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            int index = 0;

            string input = File.ReadAllText("input_2.txt");

            char[] inputChar = input.ToCharArray();
            File.Create("output_2.txt"). Close();
            foreach (var ch in inputChar)
            {
                if (alphabet.Contains(ch))
                {
                   string result = ($"{ch} -> {index = Array.IndexOf(alphabet, ch)}");
                   File.AppendAllText("output_2.txt", result + Environment.NewLine);
                }
            }
        }
    }
}
