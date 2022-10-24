using System;
using System.Linq;

namespace _11.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string[], int, string> findName = (names, number) =>
             {
                 foreach (string name in names)
                 {
                     if (name.Sum(c => c) >= number)
                     {
                         return name;
                     }
                     else
                     {
                         continue;
                     }
                 }

                 return null;
             };


            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine(findName(names, number));
        }
    }
}
