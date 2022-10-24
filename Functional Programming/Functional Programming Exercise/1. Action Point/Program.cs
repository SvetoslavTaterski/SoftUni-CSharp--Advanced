using System;

namespace _1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = (names) =>
            {
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            };

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            printNames(names);
        }
    }
}
