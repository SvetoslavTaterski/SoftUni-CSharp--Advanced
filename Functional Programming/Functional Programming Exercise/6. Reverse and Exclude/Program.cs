using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>, int> reverseAndRemove = (numbers, numberToDivide) =>
            {
                numbers.Reverse();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % numberToDivide == 0)
                    {
                        numbers.Remove(numbers[i]);
                        i--;
                    }
                }

                Console.WriteLine(string.Join(" ", numbers));
            };

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int numberToDivide = int.Parse(Console.ReadLine());

            reverseAndRemove(numbers, numberToDivide);
        }
    }
}
