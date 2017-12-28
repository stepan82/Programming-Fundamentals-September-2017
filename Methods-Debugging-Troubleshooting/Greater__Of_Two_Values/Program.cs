using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater__Of_Two_Values
{
    class Program
    {
        static int getMax_1(int value_1, int value_2)
        {
            int maxValue = 0;
            if (value_1 > value_2)
            {
                maxValue = value_1;
            }
            else
            {
                maxValue = value_2;
            }
            return maxValue;
        }

        static char getMax_2(char value_1, char value_2)
        {
            char maxValue = ' ';
            if (value_1 > value_2)
            {
                maxValue = value_1;
            }
            else
            {
                maxValue = value_2;
            }
            return maxValue;
        }
        static string getMax_3(string value_1, string value_2)
        {
            string maxValue = " ";
            if (value_1.CompareTo(value_2) >= 0)
            {
                maxValue = value_1;
            }
            else
            {
                maxValue = value_2;
            }
            return maxValue;
        }
        static void Main(string[] args)
        {
            string varType = Console.ReadLine();
            if (varType == "int")
            {
                int value_1 = int.Parse(Console.ReadLine());
                int value_2 = int.Parse(Console.ReadLine());
                int result = getMax_1(value_1, value_2);
                Console.WriteLine(result);
            }
            else if (varType == "char")
            {
                char value_1 = char.Parse(Console.ReadLine());
                char value_2 = char.Parse(Console.ReadLine());
                int result = getMax_2(value_1, value_2);
                Console.WriteLine(Convert.ToChar(result));
            }
            else if (varType == "string")
            {
                string value_1 = Console.ReadLine();
                string value_2 = Console.ReadLine();
                string result = getMax_3(value_1, value_2);
                Console.WriteLine(Convert.ToString(result));
            }
        }
    }
}
