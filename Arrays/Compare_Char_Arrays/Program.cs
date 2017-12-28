using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_1 = Console.ReadLine();
            string input_2 = Console.ReadLine();
            char[] firstArrey = input_1.ToCharArray();
            char[] secondArrey = input_2.ToCharArray();
            int count = 0;

            if (firstArrey.Length > secondArrey.Length)
            {
                for (int i = 0; i < firstArrey.Length; i++)
                {
                    count++;
                }
                string print = new string(secondArrey);
                string print_1 = new string(firstArrey);
                if (count != 0)
                {

                    Console.WriteLine($"{print.Replace(" ", String.Empty)}");
                    Console.WriteLine($"{print_1.Replace(" ", String.Empty)}");
                }
            }


            else if (firstArrey.Length < secondArrey.Length)
            {
                for (int i = 0; i < secondArrey.Length; i++)
                {
                    count++;
                }
                string print = new string(secondArrey);
                string print_1 = new string(firstArrey);
                if (count != 0)
                {

                    Console.WriteLine($"{print_1.Replace(" ", String.Empty)}");
                    Console.WriteLine($"{print.Replace(" ", String.Empty)}");
                }
            }

            else
            {
                if (firstArrey[0] > secondArrey[0])
                {
                    string print = new string(secondArrey);
                    string print_1 = new string(firstArrey);
                    Console.WriteLine($"{print.Replace(" ", String.Empty)}");
                    Console.WriteLine($"{print_1.Replace(" ", String.Empty)}");
                }
                else
                {
                    string print = new string(secondArrey);
                    string print_1 = new string(firstArrey);
                    Console.WriteLine($"{print_1.Replace(" ", String.Empty)}");
                    Console.WriteLine($"{print.Replace(" ", String.Empty)}");
                }

            }
        }
    }
}
