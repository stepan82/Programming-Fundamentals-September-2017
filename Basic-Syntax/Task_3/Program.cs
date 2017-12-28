using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var emplyee_Name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var emplyee_ID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {emplyee_Name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {emplyee_ID.ToString("D8")}");
            Console.WriteLine($"Salary: {salary:F2}");

        }
    }
}
