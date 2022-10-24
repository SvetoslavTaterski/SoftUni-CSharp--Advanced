using System;

namespace _7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[], int> printer = (names, nameLength) =>
            {
                foreach (string name in names)
                {
                    if (name.Length <= nameLength)
                    {
                        Console.WriteLine(name);
                    }
                }
            };

            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printer(names, nameLength);
        }
    }
}
