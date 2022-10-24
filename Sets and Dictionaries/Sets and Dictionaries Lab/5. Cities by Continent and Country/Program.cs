using System;
using System.Collections.Generic;

namespace _5._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var citiesDictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = elements[0];
                string country = elements[1];
                string city = elements[2];

                if (!citiesDictionary.ContainsKey(continent))
                {
                    citiesDictionary.Add(continent, new Dictionary<string, List<string>>());

                }

                if (!citiesDictionary[continent].ContainsKey(country))
                {
                    citiesDictionary[continent].Add(country, new List<string>());
                }

                citiesDictionary[continent][country].Add(city);

            }

            foreach (var continent in citiesDictionary)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.Write($"  {country.Key} -> ");
                    Console.WriteLine(string.Join(", ", country.Value));
                }
            }
        }
    }
}
