using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static double triangle_Area (double width, double height)
        {
            double area = (width * height) / 2;
            return area;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = triangle_Area(width, height);
            Console.WriteLine(result);
        }
    }
}
