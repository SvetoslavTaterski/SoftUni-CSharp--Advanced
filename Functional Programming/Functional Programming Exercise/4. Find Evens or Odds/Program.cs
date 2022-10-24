using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Predicate<string> evenOrOdd = (command) =>
            {
                if (command == "even")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int startNum = range[0];
            int endNum = range[1];
            string command = Console.ReadLine();

            for (int i = startNum; i <= endNum; i++)
            {
                if (evenOrOdd(command))
                {
                    if (i % 2 == 0)
                    {
                        numbers.Add(i);
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        numbers.Add(i);
                    }
                }
            }

            Console.Write(string.Join(" ", numbers));
        }
    }
}
