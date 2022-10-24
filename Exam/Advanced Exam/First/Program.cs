using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> caffeine = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> energyDrinks = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int stamatCaffeineLimit = 300;
            int stamatCaffeineDrinked = 0;

            while (caffeine.Count != 0 && energyDrinks.Count != 0)
            {
                int currentCaffeine = caffeine.Peek();
                int currentEnergy = energyDrinks.Peek();
                int result = currentCaffeine * currentEnergy;

                if (result <= stamatCaffeineLimit)
                {
                    stamatCaffeineLimit -= result;
                    stamatCaffeineDrinked += result;
                    caffeine.Pop();
                    energyDrinks.Dequeue();
                }
                else
                {
                    caffeine.Pop();
                    energyDrinks.Enqueue(energyDrinks.Dequeue());

                    if (stamatCaffeineDrinked - 30 > 0)
                    {
                        stamatCaffeineDrinked -= 30;
                        stamatCaffeineLimit += 30;
                    }

                }

            }

            if (energyDrinks.Any())
            {
                Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {stamatCaffeineDrinked} mg caffeine.");
        }
    }
}
