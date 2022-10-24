using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split();
            int numberOfPasses = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(people);

            while (queue.Count > 1)
            {
                for (int i = 1; i < numberOfPasses; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
