using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, string, List<int>> listCalculator = (numbers, command) =>
            {
                if (command == "add")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]++;
                    }

                    return numbers;
                }
                else if (command == "multiply")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] *= 2;
                    }

                    return numbers;
                }
                else if (command == "subtract")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }

                    return numbers;
                }
                else if(command == "print")
                {
                    return numbers;
                }
                else
                {
                    throw new ArgumentException(command);
                }
            };




            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                listCalculator(numbers, command);

                if (command == "print")
                {
                        Console.WriteLine($"{string.Join(" ",numbers)}");   
                }

            }
        }
    }
}
