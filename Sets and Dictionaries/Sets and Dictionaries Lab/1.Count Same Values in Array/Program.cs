using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersDictionary = new Dictionary<double, int>();

            double[] numbersToAdd = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbersToAdd.Length; i++)
            {
                double numberToAdd = numbersToAdd[i];

                if (!numbersDictionary.ContainsKey(numberToAdd))
                {
                    numbersDictionary.Add(numberToAdd,0);
                }

                numbersDictionary[numberToAdd]++;
            }

            foreach (var number in numbersDictionary)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
