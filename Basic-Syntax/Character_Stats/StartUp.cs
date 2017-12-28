
namespace Character_Stats
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int current_Health = int.Parse(Console.ReadLine());
            int max_Health = int.Parse(Console.ReadLine());
            int current_Energy = int.Parse(Console.ReadLine());
            int max_Energy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', current_Health), new string('.', max_Health - current_Health));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', current_Energy), new string('.', max_Energy - current_Energy));
        }
    }
}
