using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));

            Dictionary<string, int> products = new Dictionary<string, int>();
            products.Add("Croissant", 0);
            products.Add("Muffin", 0);
            products.Add("Baguette", 0);
            products.Add("Bagel", 0);

            while (water.Count != 0 && flour.Count != 0)
            {
                double currentWater = water.Dequeue();
                double currentFlour = flour.Pop();
                double waterAndFlour = currentWater + currentFlour;
                double waterPercentage = (currentWater * 100) / waterAndFlour;

                if (waterPercentage == 40)
                {
                    products["Muffin"]++;
                }
                else if (waterPercentage == 50)
                {
                    products["Croissant"]++;
                }
                else if (waterPercentage == 30)
                {
                    products["Baguette"]++;
                }
                else if (waterPercentage == 20)
                {
                    products["Bagel"]++;
                }
                else
                {
                    double remainingFlour = currentFlour - currentWater;
                    flour.Push(remainingFlour);
                    products["Croissant"]++;
                }
            }

            var orderedProducts = new Dictionary<string, int>(products.Where(p => p.Value>0).OrderByDescending(p => p.Value).ThenBy(p => p.Key));

            foreach (var product in orderedProducts)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            if (water.Any())
            {
                Console.WriteLine($"Water left: {string.Join(", ",water)}");
            }
            else
            {
                Console.WriteLine("Water left: None");
            }

            if (flour.Any())
            {
                Console.WriteLine($"Flour left: {string.Join(", ",flour)}");
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}
