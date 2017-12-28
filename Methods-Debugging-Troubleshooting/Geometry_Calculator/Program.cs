using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            switch (figureType)
            {
                case "triangle":
                    double sideTriangle = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    double result_1 = GetTriangleArea(sideTriangle, height);
                    Console.WriteLine($"{result_1:F2}");
                    break;

                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    double result_2 = GetSquareArea(sideSquare);
                    Console.WriteLine($"{result_2:F2}");
                    break;

                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightRectangle = double.Parse(Console.ReadLine());
                    double result_3 = GetReactangleArea(width, heightRectangle);
                    Console.WriteLine($"{result_3:F2}");
                    break;

                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    double result_4 = GetCircleArea(radius);
                    Console.WriteLine($"{result_4:F2}");
                    break;
            }
        }

        static double GetTriangleArea(double side, double height)
        {
            double result = (side * height) / 2;
            return result;
        }

        static double GetSquareArea(double side)
        {
            double result = Math.Pow(side, 2);
            return result;
        }

        static double GetReactangleArea(double width, double height)
        {
            double result = width * height;
            return result;
        }

        static double GetCircleArea(double radius)
        {
            double result = Math.PI * Math.Pow(radius, 2);
            return result;
        }
    }
}
