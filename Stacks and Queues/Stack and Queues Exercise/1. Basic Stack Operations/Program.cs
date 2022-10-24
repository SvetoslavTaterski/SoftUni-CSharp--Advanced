using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersForCommands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = numbersForCommands[0];
            int s = numbersForCommands[1];
            int x = numbersForCommands[2];
            Stack<int> stackOfNumbers = new Stack<int>(n);

            for (int i = 0; i < n; i++)
            {
                stackOfNumbers.Push(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stackOfNumbers.Pop();
            }

            int smallestElement = int.MaxValue;

            if (stackOfNumbers.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            foreach (int number in stackOfNumbers)
            {
                if (number == x)
                {
                    Console.WriteLine("true");
                    return;
                }

                if (number < smallestElement)
                {
                    smallestElement = number;
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
