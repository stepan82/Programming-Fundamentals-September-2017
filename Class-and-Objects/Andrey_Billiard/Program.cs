using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrey_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int productsCount = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>(); //Product PriceCatalog

            //adding entities and their price!!
            for (int i = 0; i < productsCount; i++)
            {
                string[] productsAndPrice = Console.ReadLine().Split('-').ToArray();
                string product = productsAndPrice[0];
                decimal price = decimal.Parse(productsAndPrice[1]);

                if (!productPrice.ContainsKey(product))
                {
                    productPrice.Add(product, price);
                }
                else
                {
                    productPrice[product] = price;
                }

            }
            // all entities have been added!!

            SortedDictionary<string, Dictionary<string, int>> buyingList = new SortedDictionary<string, Dictionary<string, int>>(); //Buyers List

            //adding Buyers and quantity!!
            while (true)
            {
                string[] buyersData = Console.ReadLine().Split('-', ',').ToArray();
                if (buyersData[0] == "end of clients")
                {
                    break;
                }
                string buyerName = buyersData[0];
                string productGet = buyersData[1];
                int quantity = int.Parse(buyersData[2]);

                if (!buyingList.ContainsKey(buyerName) && productPrice.ContainsKey(productGet))
                {
                    buyingList.Add(buyerName, new Dictionary<string, int>());
                    buyingList[buyerName].Add(productGet, quantity);
                }
                else if (buyingList.ContainsKey(buyerName) && productPrice.ContainsKey(productGet))
                {
                    if (buyingList[buyerName].ContainsKey(productGet))
                    {
                        buyingList[buyerName][productGet] += quantity;
                    }
                    else
                    {
                        buyingList[buyerName].Add(productGet, quantity);
                    }                          
                }
                
            }
            //Buyers and quantity have been added!!

            //Printing output
            decimal totalResult = 0.0m;
            foreach (var user in buyingList)
            {
                Console.WriteLine(user.Key);
                decimal result = 0.0m;
                foreach (var item in user.Value)
                {
                    
                    foreach (var entity in productPrice)
                    {

                        if (item.Key == entity.Key)
                        {
                            result += entity.Value * item.Value;
                            totalResult += entity.Value * item.Value;
                        }

                    }
                    Console.WriteLine("-- {0} - {1}", item.Key, item.Value);
                      
                }
                Console.WriteLine($"Bill: {result:F2}");
            }

            Console.WriteLine($"Total bill: {totalResult:F2}");

            //printing has finished!!
        }
    }
}
