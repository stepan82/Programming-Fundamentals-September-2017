using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Draw_Filled_Square
{
    class Program
    {
        static void printHeaderFooter(int number)
        {
            Console.WriteLine(new string('-', number * 2)); 
        }

        static void squareFilled(int number)
        {
            for (int i = 1; i <= number-1; i++)
            {
                Console.Write("\\/");
            }
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            printHeaderFooter(input);
            for (int i = 1; i <= input-2; i++)
            {
                Console.Write("-");
                squareFilled(input);
                Console.WriteLine("-");
            }
            printHeaderFooter(input);
        
        }
    }
}
