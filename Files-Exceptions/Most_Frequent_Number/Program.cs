using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = File.ReadAllText("input_3.txt").Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int perm = 0;
            int mostFrequent = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > perm && i <= mostFrequent)
                {
                    mostFrequent = arr[i];
                    perm = count;
                }
                count = 0;
            }
            File.Create("output_3.txt").Close();
            File.WriteAllText("output_3.txt", mostFrequent.ToString());
        }
    }
}
