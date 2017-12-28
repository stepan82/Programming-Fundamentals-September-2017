using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            switch (parameter)
            {
                case "face":
                    var result_1 = GetCubeFace(cubeSide);
                    Console.WriteLine($"{result_1:F2}");
                    break;

                case "space":
                    var result_2 = GetSpaceDiagonals(cubeSide);
                    Console.WriteLine($"{result_2:F2}");
                    break;

                case "volume":
                    var result_3 = GetVolume(cubeSide);
                    Console.WriteLine($"{result_3:F2}");
                    break;

                case "area":
                    var result_4 = GetArea(cubeSide);
                    Console.WriteLine($"{result_4:F2}");
                    break;
            }
        }

        static double GetCubeFace(double side)
        {
            double face = side * Math.Sqrt(2);
            return face;
        }

        static double GetSpaceDiagonals(double side)
        {
            double spaceDiag = side * Math.Sqrt(3);
            return spaceDiag;
        }

        static double GetVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }

        static double GetArea(double side)
        {
            double area = 6 * (Math.Pow(side, 2));
            return area;
        }
    }
}
