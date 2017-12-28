using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first_Letter = char.Parse(Console.ReadLine());
            char second_Letter = char.Parse(Console.ReadLine());
            char third_Letter = char.Parse(Console.ReadLine());
            for (char i = first_Letter; i <= second_Letter; i++)
            {
                for (char j = first_Letter;  j <= second_Letter; j ++)
                {
                    for (char k = first_Letter; k <= second_Letter; k++)
                    {
                        if (i != third_Letter && j != third_Letter && k != third_Letter)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
