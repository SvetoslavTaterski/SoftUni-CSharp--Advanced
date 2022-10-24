using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ordersQueue = new Queue<int>(orders);
            int biggestOrder = int.MinValue;

            foreach (var item in ordersQueue)
            {
                if (item > biggestOrder)
                {
                    biggestOrder = item;
                }
            }

            Console.WriteLine(biggestOrder);

            while (ordersQueue.Count > 0)
            {
                if (foodQuantity - ordersQueue.Peek() < 0)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",ordersQueue)}");
                    return;
                }

                foodQuantity-=ordersQueue.Dequeue();
            }

            Console.WriteLine("Orders complete");
        }
    }
}
