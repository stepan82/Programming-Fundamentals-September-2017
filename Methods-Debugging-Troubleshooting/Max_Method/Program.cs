using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static int getMax(int a, int b)
        {
            int maxValue = 0;
            if (a > b)
            {
                maxValue = a;
            }
            else
            {
                maxValue = b;
            }
            return maxValue;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int resultAB = getMax(a, b);
            if (resultAB > c)
            {
                Console.WriteLine(resultAB);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
