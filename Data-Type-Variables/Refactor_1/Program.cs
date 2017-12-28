using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double pyramidVolume = (length * width * heigth) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {pyramidVolume:F2}");
        }
    }
}
