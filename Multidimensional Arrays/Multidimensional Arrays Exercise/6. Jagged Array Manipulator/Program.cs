using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[numberOfRows][];

            for (int row = 0; row < numberOfRows; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < elements.Length; col++)
                {
                    jaggedArray[row] = elements;
                }
            }

            for (int row = 0; row < numberOfRows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] *= 2;
                    }
                    for (int j = 0; j < jaggedArray[row + 1].Length; j++)
                    {
                        jaggedArray[row + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] /= 2;
                    }
                    for (int j = 0; j < jaggedArray[row + 1].Length; j++)
                    {
                        jaggedArray[row + 1][j] /= 2;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    for (int row = 0; row < numberOfRows; row++)
                    {
                        for (int col = 0; col < jaggedArray[row].Length; col++)
                        {
                            Console.Write($"{jaggedArray[row][col]} ");
                        }
                        Console.WriteLine();
                    }

                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];
                int rowIndex = int.Parse(tokens[1]);
                int colIndex = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (rowIndex >= 0 && rowIndex < numberOfRows &&
                    colIndex >=0  && colIndex < jaggedArray[rowIndex].Length)
                {
                    if (action == "Add")
                    {
                        jaggedArray[rowIndex][colIndex] += value;
                    }
                    else
                    {
                        jaggedArray[rowIndex][colIndex] -= value;
                    }
                }

            }
        }
    }
}
