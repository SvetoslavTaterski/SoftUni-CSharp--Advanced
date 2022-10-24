using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> whiteTilesList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            Stack<int> whiteTilesStack = new Stack<int>(whiteTilesList);

            List<int> greyTilesList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            Queue<int> greyTilesQueue = new Queue<int>(greyTilesList);

            Dictionary<string, int> decoration = new Dictionary<string, int>();

            decoration.Add("Sink", 0);
            decoration.Add("Oven", 0);
            decoration.Add("Countertop", 0);
            decoration.Add("Wall", 0);
            decoration.Add("Floor", 0);

            while (whiteTilesStack.Count != 0 && greyTilesQueue.Count != 0)
            {
                if (whiteTilesStack.Peek() == greyTilesQueue.Peek())
                {
                    int sumOfTiles = whiteTilesStack.Pop() + greyTilesQueue.Dequeue();

                    if (sumOfTiles == 40)
                    {
                        decoration["Sink"]++;
                    }
                    else if (sumOfTiles == 50)
                    {
                        decoration["Oven"]++;
                    }
                    else if (sumOfTiles == 60)
                    {
                        decoration["Countertop"]++;
                    }
                    else if (sumOfTiles == 70)
                    {
                        decoration["Wall"]++;
                    }
                    else
                    {
                        decoration["Floor"]++;
                    }
                }
                else
                {
                    int newWhiteTile = whiteTilesStack.Pop() / 2;
                    whiteTilesStack.Push(newWhiteTile);

                    int newGreyTile = greyTilesQueue.Dequeue();
                    greyTilesQueue.Enqueue(newGreyTile);
                }
            }

            string whiteTilesLeft = string.Empty;

            if (whiteTilesStack.Count == 0)
            {
                whiteTilesLeft = "none";
            }
            else
            {
                whiteTilesLeft = $"{string.Join(", ", whiteTilesStack)}";
            }

            string greyTilesLeft = string.Empty;

            if (greyTilesQueue.Count == 0)
            {
                greyTilesLeft = "none";
            }
            else
            {
                greyTilesLeft = $"{string.Join(", ", greyTilesQueue)}";
            }

            var ordered = new Dictionary<string, int>(decoration.Where(v => v.Value > 0)
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key));

            Console.WriteLine($"White tiles left: {whiteTilesLeft}");
            Console.WriteLine($"Grey tiles left: {greyTilesLeft}");

            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
