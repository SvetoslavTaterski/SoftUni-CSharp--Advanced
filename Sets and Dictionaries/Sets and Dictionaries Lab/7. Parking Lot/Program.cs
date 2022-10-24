using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingInfo = new HashSet<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    if (parkingInfo.Any())
                    {
                        foreach (var numberPlate in parkingInfo)
                        {
                            Console.WriteLine(numberPlate);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Parking Lot is Empty");
                    }

                    break;
                }

                string[] tokens = command.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string numberplate = tokens[1];

                if (action == "IN")
                {
                    parkingInfo.Add(numberplate);
                }
                else
                {
                    parkingInfo.Remove(numberplate);
                }
            }
        }
    }
}
