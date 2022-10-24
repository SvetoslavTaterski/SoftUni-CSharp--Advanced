using System;
using System.Linq;

namespace _1._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).Where(n => n % 2 == 0).ToArray();

            Console.WriteLine(string.Join(", ",arrayOfNumbers.OrderBy(n => n)));
                
        }
    }
}
