using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_Number = int.Parse(Console.ReadLine());
            int m_Number = int.Parse(Console.ReadLine());
            int max_Sum = int.Parse(Console.ReadLine());
            var total_Sum = 0;
            var count_Combin = 0;
            for (int i = n_Number; i >= 1; i--)
            {
                for (int j = 1; j <= m_Number; j++)
                {
                    if (total_Sum >= max_Sum)
                    {
                        break;
                    }
                    count_Combin++;
                    total_Sum += 3 * (i * j);    
                }
                if (total_Sum >=max_Sum)
                {
                    break;
                }
            }
            if (total_Sum >= max_Sum)
            {
                Console.WriteLine($"{count_Combin} combinations");
                Console.WriteLine($"Sum: {total_Sum} >= {max_Sum}");
            }
            else
            {
                Console.WriteLine($"{count_Combin} combinations");
                Console.WriteLine($"Sum: {total_Sum}");
            }
        }
    }
}
