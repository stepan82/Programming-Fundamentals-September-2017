using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            try
            {
                while (true)
                {
                    int number_Integer = int.Parse(Console.ReadLine());
                    total++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(total);
            }
        }
    }
}
