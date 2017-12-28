using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Name_
{
    class Program
    {
        static void getName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            getName(input);
        }
    }
}
