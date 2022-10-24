using System;
using System.Linq;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> returnSmallestNum = (numbers) =>
            {
                 int smallestNum = int.MaxValue;

                 foreach (int number in numbers)
                 {
                     if (number < smallestNum)
                     {
                         smallestNum = number;
                     }
                 }

                 return smallestNum;
            };

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(returnSmallestNum(numbers));

        }
    }
}
