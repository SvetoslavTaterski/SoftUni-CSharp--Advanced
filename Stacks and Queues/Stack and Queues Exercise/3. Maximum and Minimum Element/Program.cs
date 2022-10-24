using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = tokens[0];
                int biggestNum = int.MinValue;
                int smallestNum = int.MaxValue;

                if (command == 1)
                {
                    int element = tokens[1];
                    stackOfNumbers.Push(element);
                }
                else if (command == 2)
                {
                    if (stackOfNumbers.Count==0)
                    {
                        continue;
                    }
                    stackOfNumbers.Pop();
                }
                else if (command == 3)
                {
                    if (stackOfNumbers.Count == 0)
                    {
                        continue;
                    }

                    foreach (int number in stackOfNumbers)
                    {
                        if (number > biggestNum)
                        {
                            biggestNum = number;
                        }
                    }

                    Console.WriteLine(biggestNum);
                }
                else if (command == 4)
                {
                    if (stackOfNumbers.Count == 0)
                    {
                        continue;
                    }

                    foreach (int number in stackOfNumbers)
                    {
                        if (number < smallestNum)
                        {
                            smallestNum = number;
                        }
                    }

                    Console.WriteLine(smallestNum);
                }
            }

            Console.WriteLine(string.Join(", ",stackOfNumbers));
        }
    }
}
