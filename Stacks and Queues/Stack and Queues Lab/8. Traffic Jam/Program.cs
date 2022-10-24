using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            int numOfPassingCars = int.Parse(Console.ReadLine());
            int counter = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine($"{counter} cars passed the crossroads.");
                    break;
                }

                if (command == "green")
                {
                    for (int i = 0; i < numOfPassingCars; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            counter++;
                        }
                    }
                    continue;
                }

                cars.Enqueue(command);
            }
        }
    }
}
