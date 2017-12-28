
namespace Restaurant_Discount
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int group_Size = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            if (group_Size <= 50 && package == "Normal")
            {
                double total_Price = 2500 + 500;
                double discount_Price = total_Price - (total_Price * 0.05);
                double price_Per_person = discount_Price / group_Size;
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {price_Per_person:F2}$");
            }
            else if (group_Size <= 50 && package == "Gold")
            {
                double total_Price = 2500 + 750;
                double discount_Price = total_Price - (total_Price * 0.10);
                double price_Per_person = discount_Price / group_Size;
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {price_Per_person:F2}$");
            }
            else if (group_Size <= 50 && package == "Platinum")
            {
                double total_Price = 2500 + 1000;
                double discount_Price = total_Price - (total_Price * 0.15);
                double price_Per_person = discount_Price / group_Size;
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {price_Per_person:F2}$");
            }
            else if ((group_Size > 50 && group_Size <= 100) && package == "Normal")
            {
                double total_Price = 5000 + 500;
                double discount_Price = total_Price - (total_Price * 0.05);
                double price_Per_person = discount_Price / group_Size;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {price_Per_person:F2}$");
            }
            else if ((group_Size > 50 && group_Size <= 100) && package == "Gold")
            {
                double total_Price = 5000 + 750;
                double discount_Price = total_Price - (total_Price * 0.10);
                double price_Per_person = discount_Price / group_Size;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {price_Per_person:F2}$");
            }
            else if ((group_Size > 50 && group_Size <= 100) && package == "Platinum")
            {
                double total_Price = 5000 + 1000;
                double discount_Price = total_Price - (total_Price * 0.15);
                double price_Per_person = discount_Price / group_Size;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {price_Per_person:F2}$");
            }
            else if ((group_Size > 100 && group_Size <= 120) && package == "Normal")
            {
                double total_Price = 7500 + 500;
                double discount_Price = total_Price - (total_Price * 0.05);
                double price_Per_person = discount_Price / group_Size;
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {price_Per_person:F2}$");
            }
            else if ((group_Size > 100 && group_Size <= 120) && package == "Gold")
            {
                double total_Price = 7500 + 750;
                double discount_Price = total_Price - (total_Price * 0.10);
                double price_Per_person = discount_Price / group_Size;
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {price_Per_person:F2}$");
            }
            else if ((group_Size > 100 && group_Size <= 120) && package == "Platinum")
            {
                double total_Price = 7500 + 750;
                double discount_Price = total_Price - (total_Price * 0.05);
                double price_Per_person = discount_Price / group_Size;
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {price_Per_person:F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
