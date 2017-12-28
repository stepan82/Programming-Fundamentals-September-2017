using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_Number = int.Parse(Console.ReadLine());
            int second_Number = int.Parse(Console.ReadLine());
            int third_Number = int.Parse(Console.ReadLine());
            int fourth_Number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first_Number.ToString("D4")} {second_Number.ToString("D4")} {third_Number.ToString("D4")} {fourth_Number.ToString("D4")}");
        }
    }
}
