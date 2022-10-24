using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
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
            Queue<int> queueOfNumbers = new Queue<int>(n);

            for (int i = 0; i < n; i++)
            {
                queueOfNumbers.Enqueue(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queueOfNumbers.Dequeue();
            }

            int smallestElement = int.MaxValue;

            if (queueOfNumbers.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            foreach (int number in queueOfNumbers)
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
