using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x_1 = double.Parse(Console.ReadLine());
            double y_1 = double.Parse(Console.ReadLine());
            double x_2 = double.Parse(Console.ReadLine());
            double y_2 = double.Parse(Console.ReadLine());
            GetClosestPodoubleToCenter(x_1, y_1, x_2, y_2);
        }

        static void GetClosestPodoubleToCenter(double x_1, double y_1, double x_2, double y_2)
        {
           Math.Abs(x_1);
           Math.Abs(y_1);
           Math.Abs(x_2);
           Math.Abs(y_2);
            double c_1 = Math.Pow(x_1, 2) + Math.Pow(y_1, 2);
            double c_2 = Math.Pow(x_2, 2) + Math.Pow(y_2, 2);
            if (c_1 == c_2)
            {
                Console.WriteLine($"({x_1}, {y_1})");
            }
            else if (c_1 < c_2)
            {
                Console.WriteLine($"({x_1}, {y_1})");
            }
            else
            {
                Console.WriteLine($"({x_2}, {y_2})");

            }
        }
    }
}
