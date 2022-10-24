using System;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = tokens[0];
                string clothes = tokens[1];
                string[] clothesArray = clothes.Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothesArray.Length; j++)
                {
                    string cloth = clothesArray[j];

                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 0);
                    }

                    wardrobe[color][cloth]++;
                }
            }

            string[] clothToSearch = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var newItem in item.Value)
                {
                    if (item.Key == clothToSearch[0] && newItem.Key == clothToSearch[1])
                    {
                        Console.WriteLine($"* {newItem.Key} - {newItem.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {newItem.Key} - {newItem.Value}");
                }
            }
        }
    }
}
