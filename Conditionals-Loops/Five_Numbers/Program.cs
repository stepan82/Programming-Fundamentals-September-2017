using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var count = 0;
            for (int n_1 = a; n_1 <= b; n_1++)
            {
                for (int n_2 = n_1 + 1; n_2 <= b; n_2++)
                {
                    for (int n_3 = n_2 + 1; n_3 <= b; n_3++)
                    {
                        for (int n_4 = n_3 + 1; n_4 <= b; n_4++)
                        {
                            for (int n_5 = n_4 + 1; n_5 <= b; n_5++)
                            {
                                if (n_1 < n_2 && n_2 < n_3 && n_3 < n_4 && n_4 < n_5)
                                {
                                    Console.WriteLine($"{n_1} {n_2} {n_3} {n_4} {n_5}");
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
