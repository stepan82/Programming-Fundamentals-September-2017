using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                var inputData = Console.ReadLine().Split(' ').ToArray();
                string command = inputData[0];

                switch (command)
                {
                    case "A":
                        if (phonebook.ContainsKey(inputData[1]))
                        {
                            phonebook[inputData[1]] = inputData[2];
                        }
                        else
                        {
                            phonebook.Add(inputData[1], inputData[2]);
                        }
                        break;

                    case "S":
                        if (phonebook.ContainsKey(inputData[1]))
                        {
                            Console.WriteLine("{0} -> {1}", inputData[1], phonebook[inputData[1]]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Contact {inputData[1]} does not exist.");
                        }
                        break;

                    case "ListAll":
                        foreach (var contact in phonebook)
                        {
                            Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                        }
                        break;

                    case "END":
                        break;
                }
                if (command == "END")
                {
                    break;
                }
            }
        }
    }
}
