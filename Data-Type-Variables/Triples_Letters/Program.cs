using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (char i = 'a'; i <= 'a' + (number-1); i++)
            {
                for (char i_2 = 'a'; i_2 <= 'a' + (number - 1); i_2++)
                {
                    for (char i_3 = 'a'; i_3 <= 'a' + (number - 1); i_3++)
                    {
                        char letter_1 = i;
                        char letter_2 = i_2;
                        char letter_3 = i_3;
                        Console.WriteLine($"{i}{i_2}{i_3}");
                    }
                }
            }
        }
    }
}
