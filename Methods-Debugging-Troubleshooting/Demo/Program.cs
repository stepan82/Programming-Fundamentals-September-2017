using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                int sum = 0;
                int currentNumber = i;
                while (currentNumber > 0)
                {
                    sum = currentNumber % 10;
                    currentNumber = currentNumber / 10;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        sum = 0;
                    }
                }
            }
        }
    }
}
