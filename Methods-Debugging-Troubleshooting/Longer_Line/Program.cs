using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x_1 = double.Parse(Console.ReadLine());
            double y_1 = double.Parse(Console.ReadLine());
            double x_2 = double.Parse(Console.ReadLine());
            double y_2 = double.Parse(Console.ReadLine());
            double x_3 = double.Parse(Console.ReadLine());
            double y_3 = double.Parse(Console.ReadLine());
            double x_4 = double.Parse(Console.ReadLine());
            double y_4 = double.Parse(Console.ReadLine());

            GetBiggestDistance(x_1, y_1, x_2, y_2, x_3, y_3, x_4, y_4);
        }

        static void GetBiggestDistance
        (double x_1, double y_1, double x_2, double y_2, double x_3, double y_3, double x_4, double y_4)
        {
            Math.Abs(x_1);Math.Abs(y_1);Math.Abs(x_2);Math.Abs(y_2); Math.Abs(x_3);Math.Abs(y_3);Math.Abs(x_4);Math.Abs(y_4);

            double c_1 = Math.Pow(x_1, 2) + Math.Pow(y_1, 2);
            double c_2 = Math.Pow(x_2, 2) + Math.Pow(y_2, 2);
            double c_3 = Math.Pow(x_3, 2) + Math.Pow(y_3, 2);
            double c_4 = Math.Pow(x_4, 2) + Math.Pow(y_4, 2);

            if (c_1 + c_2 == c_3 + c_4)
            {
                if (c_1 < c_2)
                {
                    Console.WriteLine($"({x_1}, {y_1})({x_2}, {y_2})");

                }
                else
                {
                    Console.WriteLine($"({x_2}, {y_2})({x_1}, {y_1})");

                }
            }
            else if (c_1 + c_2 >= c_3 + c_4)
            {
                if (c_1 < c_2)
                {
                    Console.WriteLine($"({x_1}, {y_1})({x_2}, {y_2})");
                }
                else
                {
                    Console.WriteLine($"({x_2}, {y_2})({x_1}, {y_1})");
                }
               
            }
            else if (c_3 + c_4 > c_1 + c_2)
            {
                if (c_4 < c_3)
                {
                    Console.WriteLine($"({x_4}, {y_4})({x_3}, {y_3})");
                }
                else
                {
                    Console.WriteLine($"({x_3}, {y_3})({x_4}, {y_4})");

                }
            }
        }
    }
}
