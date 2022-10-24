using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var numbersList = new List<int>(input);

            numbersList = new List<int>(numbersList.OrderByDescending(n => n));

            for (int i = 0; i < numbersList.Count; i++)
            {

                if (i == 3)
                {
                    break;
                }

                Console.Write($"{numbersList[i]} ");
            }
        }
    }
}
