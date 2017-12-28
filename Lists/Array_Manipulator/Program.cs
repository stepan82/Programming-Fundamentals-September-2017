using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var tokens = Console.ReadLine().Split(' ').ToList();
            while (tokens[0] != "print")
            {
                switch (tokens[0])
                {
                    case "add":
                        int index = int.Parse(tokens[1]);
                        int element = int.Parse(tokens[2]);
                        numbers.Insert(index, element);
                        break;

                    case "addMany":
                        int indexMany = int.Parse(tokens[1]);
                        for (int i = 2; i < tokens.Count; i++)
                        {
                            int elementMany = int.Parse(tokens[i]);
                            numbers.Insert(indexMany, elementMany);
                            indexMany++;
                        }
                        break;

                    case "contains":
                        int elementFind = int.Parse(tokens[1]);
                        Console.WriteLine(numbers.IndexOf(elementFind));                                                    
                        break;

                    case "remove":
                        int removeIndex = int.Parse(tokens[1]);
                        numbers.RemoveAt(removeIndex);
                        break;

                    case "sumPairs":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (i == numbers.Count - 1)
                            {
                                break;
                            }
                            var result = numbers[i] + numbers[i + 1];
                            numbers.Insert(i, result);
                            numbers.RemoveRange(i + 1, 2);
                           
                        }
                        break;

                    case "shift":
                        int shifts = int.Parse(tokens[1]);                     
                        for (int i = 0; i < shifts; i++)
                        {
                            numbers.Add(numbers[i]);

                        }
                        numbers.RemoveRange(0, shifts);
                        break;
                }

                tokens = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
