using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Convert_Base_N_Base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').ToArray();
            BigInteger basa = BigInteger.Parse(tokens[0]);
            var number = tokens[1].ToCharArray();

            BigInteger result = 0;
            int count = 0;

            for (int i = number.Length-1; i >= 0; i--)
            {
                result += int.Parse(number[i].ToString()) * BigInteger.Pow(basa, count);
                count++;
            }

            Console.WriteLine(result);
        }
    }
}
