using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaggedArrayRows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[jaggedArrayRows][];

            for (int row = 0; row < jaggedArrayRows; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[elements.Length];

                for (int col = 0; col < elements.Length; col++)
                {
                    jaggedArray[row][col] = elements[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    for (int row = 0; row < jaggedArrayRows; row++)
                    {
                        for (int col = 0; col < jaggedArray[row].Length; col++)
                        {
                            Console.Write(jaggedArray[row][col] + " ");
                        }

                        Console.WriteLine();
                    }

                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];
                int firstIndex = int.Parse(tokens[1]);
                int secondIndex = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (firstIndex >= 0 
                    && firstIndex < jaggedArray.Length 
                    && secondIndex >= 0 
                    && secondIndex< jaggedArray[firstIndex].Length)
                {
                    if (action == "Add")
                    {
                        jaggedArray[firstIndex][secondIndex] += value;
                    }
                    else
                    {
                        jaggedArray[firstIndex][secondIndex] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
            }
        }
    }
}
