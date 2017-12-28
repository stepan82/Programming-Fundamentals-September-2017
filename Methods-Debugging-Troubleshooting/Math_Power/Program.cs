using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static double powerNumber(double number, double power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double pow = powerNumber(number, power);
            Console.WriteLine(pow);
        }
    }
}
