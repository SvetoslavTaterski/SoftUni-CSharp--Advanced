using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> freshnessLevel = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<string, int> dishes = new Dictionary<string, int>();
            dishes.Add("Dipping sauce", 0);
            dishes.Add("Green salad", 0);
            dishes.Add("Chocolate cake", 0);
            dishes.Add("Lobster", 0);


            while (ingredients.Count != 0 && freshnessLevel.Count != 0)
            {
                int currentIngredient = ingredients.Dequeue();

                if (currentIngredient == 0)
                {
                    continue;
                }

                int currentFreshnessLevel = freshnessLevel.Pop();
                int result = currentIngredient * currentFreshnessLevel;

                if (result == 150)
                {
                    dishes["Dipping sauce"]++;
                }
                else if (result == 250)
                {
                    dishes["Green salad"]++;
                }
                else if (result == 300)
                {
                    dishes["Chocolate cake"]++;
                }
                else if (result == 400)
                {
                    dishes["Lobster"]++;
                }
                else
                {
                    currentIngredient += 5;
                    ingredients.Enqueue(currentIngredient);
                }
            }

            var orderedDishes = new Dictionary<string, int>(dishes.Where(d => d.Value > 0).OrderBy(d => d.Key));

            if (orderedDishes.Count >= 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            if (orderedDishes.Count > 0)
            {
                foreach (var dish in orderedDishes)
                {
                    Console.WriteLine($" # {dish.Key} --> {dish.Value}");
                }
            }
        }
    }
}
