using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inputNumbers = File.ReadAllLines("input_1.txt");
            File.Create("output.txt").Close();
            for (int i = 0; i < inputNumbers.Length; i+=2)
            {
                if (inputNumbers[i] == "stop")
                {
                    break;
                }

                var resources = inputNumbers[i];
                var quantity = inputNumbers[i + 1];

                File.AppendAllText("output.txt", $"{resources} -> {quantity}" + Environment.NewLine);
            }

        }
    }
}
