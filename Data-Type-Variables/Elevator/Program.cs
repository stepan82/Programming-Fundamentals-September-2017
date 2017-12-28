using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = people / ((double)capacity);
            double finalResult = Math.Ceiling(courses);
            Console.WriteLine(finalResult);
        }
    }
}
