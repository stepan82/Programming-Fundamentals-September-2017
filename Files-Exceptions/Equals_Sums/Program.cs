using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Equals_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = File.ReadAllText("input_5.txt").Split(' ').Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;

            if (inputNumbers.Length == 1 || inputNumbers.Min() < 0)
            {
                File.Create("output_5.txt").Close();
                File.WriteAllText("output_5.txt", 0.ToString());
                return;
            }

            for (int i = 1; i < inputNumbers.Length - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumLeft += inputNumbers[j];
                }
                for (int k = i + 1; k <= inputNumbers.Length - 1; k++)
                {
                    sumRight += inputNumbers[k];
                }

                if (sumLeft == sumRight)
                {
                    File.Create("output_5.txt").Close();
                    File.WriteAllText("output_5.txt", i.ToString());

                    return;
                }
                sumLeft = 0;
                sumRight = 0;
            }
          
                File.WriteAllText("output_5.txt", "no");        
    }
    }
}
