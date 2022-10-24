using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                int numberToAdd = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(numberToAdd))
                {
                    numbers.Add(numberToAdd, 0);
                }

                numbers[numberToAdd]++;
            }

            Console.WriteLine(numbers.First(n => n.Value % 2 == 0).Key);
        }
    }
}
