using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damage_Pesho = int.Parse(Console.ReadLine());
            int damage_Gosho = int.Parse(Console.ReadLine());
            int health_Pesho = 100;
            int health_Gosho = 100;
            var turns = 0;
            while (true)
            {
                    turns++;
                if (turns % 2 == 0)
                {
                    health_Pesho -= damage_Gosho;
                    if (health_Pesho <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {health_Pesho} health."); 
                }
                else
                {
                    health_Gosho -= damage_Pesho;
                    if (health_Gosho <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {health_Gosho} health.");    
                }
                if (turns % 3 == 0)
                {
                    health_Gosho += 10;
                    health_Pesho += 10;
                }
            }
            if (health_Gosho > 0)
            {
                Console.WriteLine($"Gosho won in {turns}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {turns}th round.");
            }
        }
    }
}
