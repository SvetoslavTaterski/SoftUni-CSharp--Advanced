using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Barista_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> coffeeList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Queue<int> coffeeQueue = new Queue<int>(coffeeList);

            List<int> milkList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Stack<int> milkStack = new Stack<int>(milkList);

            Dictionary<string, int> drinks = new Dictionary<string, int>();
            drinks.Add("Cortado", 0);
            drinks.Add("Espresso", 0);
            drinks.Add("Capuccino", 0);
            drinks.Add("Americano", 0);
            drinks.Add("Latte", 0);

            while (coffeeQueue.Count != 0 && milkStack.Count != 0)
            {
                if (coffeeQueue.Peek() + milkStack.Peek() == 50)
                {
                    drinks["Cortado"]++;
                    coffeeQueue.Dequeue();
                    milkStack.Pop();
                }
                else if (coffeeQueue.Peek() + milkStack.Peek() == 75)
                {
                    drinks["Espresso"]++;
                    coffeeQueue.Dequeue();
                    milkStack.Pop();
                }
                else if (coffeeQueue.Peek() + milkStack.Peek() == 100)
                {
                    drinks["Capuccino"]++;
                    coffeeQueue.Dequeue();
                    milkStack.Pop();
                }
                else if (coffeeQueue.Peek() + milkStack.Peek() == 150)
                {
                    drinks["Americano"]++;
                    coffeeQueue.Dequeue();
                    milkStack.Pop();
                }
                else if (coffeeQueue.Peek() + milkStack.Peek() == 200)
                {
                    drinks["Latte"]++;
                    coffeeQueue.Dequeue();
                    milkStack.Pop();
                }
                else
                {
                    coffeeQueue.Dequeue();
                    int newMilkQuantity = milkStack.Pop() - 5;
                    milkStack.Push(newMilkQuantity);
                }
            }

            if (milkStack.Count == 0 && coffeeQueue.Count == 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
                Console.WriteLine("Coffee left: none");
                Console.WriteLine("Milk left: none");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");

                if (coffeeQueue.Count == 0)
                {
                    Console.WriteLine("Coffee left: none");
                }
                else
                {
                    Console.WriteLine($"Coffee left: {string.Join(", ", coffeeQueue)}");
                }

                if (milkStack.Count == 0)
                {
                    Console.WriteLine("Milk left: none");
                }
                else
                {
                    Console.WriteLine($"Milk left: {string.Join(", ", milkStack)}");
                }
            }

            var ordered = new Dictionary<string, int>(drinks)
                .Where(d => d.Value > 0)
                .OrderBy(d => d.Value)
                .ThenByDescending(d => d.Key);

            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
