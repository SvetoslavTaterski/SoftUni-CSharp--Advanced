using System;
using System.Collections.Generic;

namespace _3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] elementsToAdd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < elementsToAdd.Length; j++)
                {
                    elements.Add(elementsToAdd[j]);
                }
            }

            foreach (var element in elements)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
