using System;
using System.Collections.Generic;

namespace _4._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopDictionary = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Revision")
                {
                    break;
                }

                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shopDictionary.ContainsKey(shop))
                {
                    shopDictionary.Add(shop, new Dictionary<string, double>());
                }

                shopDictionary[shop].Add(product, price);
            }

            foreach (var shop in shopDictionary)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
