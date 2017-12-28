using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, Dictionary<string, int>> usersData = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ', '=').ToArray();

                if (input[0] == "end")
                {
                    break;
                }
                string ipAdrress = input[1];
                string userName = input[5];
                int messsage = 1;

                if (!usersData.ContainsKey(userName))
                {
                    usersData.Add(userName, new Dictionary<string, int>());
                    usersData[userName].Add(ipAdrress, messsage);
                }

                else if (usersData.ContainsKey(userName))
                {

                    if (usersData[userName].ContainsKey(ipAdrress))
                    {
                        usersData[userName][ipAdrress] += 1;
                    }
                    else
                    {
                        usersData[userName].Add(ipAdrress, messsage);
                    }
                }
            }



            foreach (var user in usersData)
            {
                Console.WriteLine($"{user.Key}: ");

                foreach (var item in user.Value)
                {

                    if (item.Key != user.Value.Keys.Last())
                    {
                        Console.Write("{0} => {1}, ", item.Key, item.Value);
                    }

                    else
                    {
                        Console.Write("{0} => {1}.", item.Key, item.Value);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
