using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {input}.");
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
