using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int kFactor_Number = int.Parse(Console.ReadLine());
            var nums = new long[numberOfElements];
            nums[0] = 1;
            for (int i = 1; i < numberOfElements; i++)
            {
                long sum = 0;
                for (int prev = i - kFactor_Number; prev <= i - 1; prev++)
                    if (prev >= 0)
                        sum += nums[prev];
                nums[i] = sum;
            }
            for (int i = 0; i < numberOfElements; i++)
                Console.Write(nums[i] + " ");
            Console.WriteLine();

        }
    }
}
