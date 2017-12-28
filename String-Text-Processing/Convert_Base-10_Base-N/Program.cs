using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Convert_Base_10_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger basa = tokens[0];
            BigInteger number = tokens[1];
            List<BigInteger> baseNumber = new List<BigInteger>();
           
            while (number > 0)
            {
                BigInteger result = number % basa;
                baseNumber.Add(result);
                BigInteger devided = number / basa;
                number = devided;
            }
            baseNumber.Reverse();

            for (int i = 0; i < baseNumber.Count; i++)
            {
                Console.Write(baseNumber[i]); 
            }
            Console.WriteLine();
        }
    }
}
