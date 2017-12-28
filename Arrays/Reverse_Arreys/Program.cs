using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Arreys
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();
            string[] newArrey = array.Split(' ');
            string[] numbersInArrey = new string[newArrey.Length];
            for (int i = 0; i < numbersInArrey.Length; i++)
            {
                numbersInArrey[i] = newArrey[i];
            }

            for (int i = numbersInArrey.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbersInArrey[i]} ");
            }
        }
    }
}
