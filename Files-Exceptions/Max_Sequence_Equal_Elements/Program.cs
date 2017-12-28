using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Max_Sequence_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = File.ReadAllText("input_3.txt").Split(' ').Select(int.Parse).ToArray();
            File.Create("output_3.txt").Close();
            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestStart = start;
                        bestLength = length;
                    }

                }
                else
                {
                    start = i;
                    length = 1;
                }
            }

            if (start == arr.Length - 1 && length == 1)
            {

                File.WriteAllText("output_3.txt", arr[0].ToString());
            }
            else
            {
                for (int i = 1; i <= bestLength; i++)
                {

                    File.AppendAllText("output_3.txt", arr[bestStart].ToString() + " ");
                }
            }
        }
    }
}
