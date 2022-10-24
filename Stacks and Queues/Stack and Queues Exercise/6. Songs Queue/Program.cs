using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songsQueue = new Queue<string>(songs);

            while (songsQueue.Count > 0)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                string action = commands[0];

                if (action == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if(action == "Add")
                {
                    string songToAdd = string.Join(" ",commands.Skip(1));

                    if (songsQueue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                        continue;
                    }
                    songsQueue.Enqueue(songToAdd);
                }
                else if (action == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
