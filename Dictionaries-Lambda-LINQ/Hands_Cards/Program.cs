using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_Cards
{
    class Program
    {

        static void Main(string[] args)
        {
           
            Dictionary<string, List<string>> usersData = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine().Split(new[] { ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                List<string> cards = new List<string>();

                for (int i = 1; i < input.Length; i++)
                {
                    cards.Add(input[i]);
                }

                List<string> removeIdenticalCards = cards.Distinct().ToList();
                cards = removeIdenticalCards;

                if (input[0] == "JOKER")
                {
                    break;
                }

                if (!usersData.ContainsKey(name))
                {
                    usersData.Add(name, new List<string>());
                    for (int i = 0; i < cards.Count; i++)
                    {
                        usersData[name].Add(cards[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < cards.Count; i++)
                    {
                        usersData[name].Add(cards[i]);
                    }
                    List<string> removeIdentical = usersData[name].Distinct().ToList();
                    usersData[name] = removeIdentical;
                }

            }
            //end of while loop
            
            //counting card points
            foreach (var item in usersData)
            {
                int finalResult = 0;
    
                foreach (var card in item.Value)
                {
                    var cards = card
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                  
                    var result = 1;
                    for (int i = 0; i < cards.Count; i++)
                    {
                        foreach (var ch in cards[i])
                        {
                            switch (ch)
                            {
                                case '0': result *= 10; break;
                                case '1': result *= 1; break;
                                case '2': result *= 2; break;
                                case '3': result *= 3; break;
                                case '4': result *= 4; break;
                                case '5': result *= 5; break;
                                case '6': result *= 6; break;
                                case '7': result *= 7; break;
                                case '8': result *= 8; break;
                                case '9': result *= 9; break;
                                case 'J': result *= 11; break;
                                case 'Q': result *= 12; break;
                                case 'K': result *= 13; break;
                                case 'A': result *= 14; break;
                                case 'S': result *= 4; break;
                                case 'H': result *= 3; break;
                                case 'D': result *= 2; break;
                                case 'C': result *= 1; break;
                                default:
                                    break;
                            }
                        }
                    }
                    finalResult += result;
                    result = 1;                 
                }
                Console.WriteLine($"{item.Key}: {finalResult}");
            }
        }
    }   
}
