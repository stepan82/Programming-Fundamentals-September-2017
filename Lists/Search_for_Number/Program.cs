using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numbersCommands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> numbersTaken = new List<int>();
            for (int i = 0; i < numbersCommands[0]; i++)
            {
                numbersTaken.Add(numbers[i]);
            }

            numbersTaken.RemoveRange(0, numbersCommands[1]);

            if (numbersTaken.Contains(numbersCommands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
