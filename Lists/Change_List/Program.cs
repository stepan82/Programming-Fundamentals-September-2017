using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(' ').ToList();
            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    var number = int.Parse(commands[1]);
                    for (int i = numbers.Count-1; i >= 0; i--)
                    {
                        if (numbers[i] == number)
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }
                }

               if (commands[0] == "Insert")
                {
                    var element = int.Parse(commands[1]);
                    var position = int.Parse(commands[2]);
                    numbers.Insert(position, element);
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }

            if (commands[0] == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write($"{numbers[i]} ");

                    }
                }
                Console.WriteLine();
            }
            if (commands[0] == "Odd")
            {
                
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.Write($"{numbers[i]} ");
                        
                    }
                  
                }
                Console.WriteLine();
            }
        }
    }
}
