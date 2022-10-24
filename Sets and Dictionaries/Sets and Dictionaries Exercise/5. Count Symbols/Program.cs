using System;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> charDictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char charToAdd = input[i];

                if (!charDictionary.ContainsKey(charToAdd))
                {
                    charDictionary.Add(charToAdd, 0);
                }

                charDictionary[charToAdd]++;
            }

            foreach (var @char in charDictionary)
            {
                Console.WriteLine($"{@char.Key}: {@char.Value} time/s");
            }
        }
    }
}
