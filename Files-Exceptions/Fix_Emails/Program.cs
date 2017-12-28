using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = File.ReadAllLines("input_1.txt");
            File.Create("output.txt").Close();
            for (int i = 0; i < inputNumbers.Length; i += 2)
            {
                if (inputNumbers[i] == "stop")
                {
                    return;
                }

                var name = inputNumbers[i];
                var email = inputNumbers[i + 1];
                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    return;
                }

                File.AppendAllText("output.txt", $"{name} -> {email}" + Environment.NewLine);

                
    
            }
        }
    }
}
