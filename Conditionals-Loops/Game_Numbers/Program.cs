using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic_Number = int.Parse(Console.ReadLine());
            var lastFirstNumber = 0;
            var lastLastNumber = 0;
            var count = 0;
            for (int i = n; i <= m; i++)
            {
                for (int inner = n; inner <= m; inner++)
                {
                    if (i + inner == magic_Number)
                    {
                       lastFirstNumber = i;
                       lastLastNumber = inner;
                    }
                    count++;
                }
            }
            if (lastFirstNumber != 0 && lastLastNumber != 0)
            {
                Console.WriteLine($"Number found! {lastFirstNumber} + {lastLastNumber} = {magic_Number}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magic_Number}");
            }
        }
    }
}
