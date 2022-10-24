using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<PetrolPump> petrolStations = new Queue<PetrolPump>(petrolPumps);

            for (int i = 0; i < petrolPumps; i++)
            {
                int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int liters = info[0];
                int distance = info[1];
                petrolStations.Enqueue(new PetrolPump(liters, distance));
            }

            int counter = 0;

            while (true)
            {
                int currLiters = 0;
                bool valid = true;

                for (int i = 0; i < petrolStations.Count; i++)
                {
                    PetrolPump currPump = petrolStations.Dequeue();
                    currLiters += currPump.Liters;
                    currLiters -= currPump.Distance;
                    petrolStations.Enqueue(currPump);

                    if (currLiters < 0)
                    {
                        valid = false;
                    }
                }

                if (valid)
                {
                    break;
                }

                petrolStations.Enqueue(petrolStations.Dequeue());
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
    class PetrolPump
    {
        public PetrolPump(int liters, int distance)
        {
            Liters = liters;
            Distance = distance;
        }
        public int Liters { get; set; }

        public int Distance { get; set; }
    }
}
