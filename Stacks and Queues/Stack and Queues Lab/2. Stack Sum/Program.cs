using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stackOfNumbers.Push(numbers[i]);
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0].ToLower();

                if (action == "add")
                {
                    int firstNum = int.Parse(tokens[1]);
                    int secondNum = int.Parse(tokens[2]);
                    stackOfNumbers.Push(firstNum);
                    stackOfNumbers.Push(secondNum);
                }
                else if (action == "remove")
                {
                    int numbersToRemove = int.Parse(tokens[1]);

                    if (stackOfNumbers.Count < numbersToRemove)
                    {
                        continue;
                    }

                    for (int i = 0; i < numbersToRemove; i++)
                    {
                        stackOfNumbers.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {stackOfNumbers.Sum()}");
        }
    }
}
