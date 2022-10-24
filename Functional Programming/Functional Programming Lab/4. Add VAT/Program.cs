using System;
using System.Linq;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVat = p => p * 1.20M;

            decimal[] prices = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(p => addVat(p))
                .ToArray();

            foreach (decimal price in prices)
                Console.WriteLine($"{price:f2}");
        }
    }
}
