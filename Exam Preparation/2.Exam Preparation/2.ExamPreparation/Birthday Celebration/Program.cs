using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Celebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> guests = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse());
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int wastedFood = 0;

            while (guests.Count != 0 && plates.Count != 0)
            {
                int guest = guests.Pop();
                int plate = plates.Pop();
                guest -= plate;

                if (guest<=0)
                {
                    wastedFood -= guest;
                }
                else
                {
                    guests.Push(guest);
                }
                
            }

            if (plates.Any())
            {
                Console.WriteLine($"Plates: {string.Join(" ", plates)}");
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(" ", guests)}");
            }

            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
