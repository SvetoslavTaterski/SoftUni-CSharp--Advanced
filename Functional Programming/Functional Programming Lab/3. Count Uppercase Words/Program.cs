using System;
using System.Linq;

namespace _3._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Predicate<string> checker = w => char.IsUpper(w[0]);

            string[] words = input.Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(w => checker(w)).ToArray();

            Console.WriteLine(string.Join("\n",words));
        }
    }
}
