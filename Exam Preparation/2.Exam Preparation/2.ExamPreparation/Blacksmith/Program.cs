using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<string, int> swords = new Dictionary<string, int>();
            swords.Add("Gladius", 0);
            swords.Add("Shamshir", 0);
            swords.Add("Katana", 0);
            swords.Add("Sabre", 0);
            swords.Add("Broadsword", 0);

            while (steel.Count != 0 && carbon.Count != 0)
            {
                int currentSteel = steel.Dequeue();
                int currentCarbon = carbon.Pop();
                int carbonAndSteel = currentCarbon + currentSteel;

                if (carbonAndSteel == 70)
                {
                    swords["Gladius"]++;
                }
                else if (carbonAndSteel == 80)
                {
                    swords["Shamshir"]++;
                }
                else if (carbonAndSteel == 90)
                {
                    swords["Katana"]++;
                }
                else if (carbonAndSteel == 110)
                {
                    swords["Sabre"]++;
                }
                else if (carbonAndSteel == 150)
                {
                    swords["Broadsword"]++;
                }
                else
                {
                    currentCarbon += 5;
                    carbon.Push(currentCarbon);
                }
            }

            var orderedSwords = new Dictionary<string, int>(swords.Where(s => s.Value > 0).OrderBy(s => s.Key));

            if (orderedSwords.Any())
            {
                Console.WriteLine($"You have forged {orderedSwords.Sum(s => s.Value)} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ",steel)}");
            }

            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }

            foreach (var sword in orderedSwords)
            {
                Console.WriteLine($"{sword.Key}: {sword.Value}");
            }
        }
    }
}
