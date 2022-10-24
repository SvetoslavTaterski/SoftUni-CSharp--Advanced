using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLootbox = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> secondLootbox = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int collection = 0;

            while (firstLootbox.Count != 0 && secondLootbox.Count != 0)
            {
                int currentLootFirst = firstLootbox.Peek();
                int currentLootSecond = secondLootbox.Peek();
                int result = currentLootFirst + currentLootSecond;

                if (result % 2 == 0)
                {
                    collection += result;
                    firstLootbox.Dequeue();
                    secondLootbox.Pop();
                }
                else
                {
                    firstLootbox.Enqueue(secondLootbox.Pop());
                }
            }

            if (!firstLootbox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (!secondLootbox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (collection >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {collection}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {collection}");
            }
        }
    }
}
