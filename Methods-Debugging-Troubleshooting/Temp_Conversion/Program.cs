using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp_Conversion
{
    class Program
    {
        static double FarenToCels(double value)
        {
            return (value - 32) * 5 / 9;
        }
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double result = FarenToCels(input);
            Console.WriteLine($"{result:F2}");
        }
    }
}
