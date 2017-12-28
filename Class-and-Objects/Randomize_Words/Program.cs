using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var rndm = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int pos2 = rndm.Next(input.Length);
                string temp = input[i];
                input[i] = input[pos2];
                input[pos2] = temp;


                Console.WriteLine(string.Join (Environment.NewLine, input));
            }
        }
    }
}
