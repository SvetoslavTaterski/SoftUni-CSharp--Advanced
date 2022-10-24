﻿using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            string snake = Console.ReadLine();

            int currentWordIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currentWordIndex == snake.Length)
                        {
                            currentWordIndex = 0;
                        }

                        matrix[row, col] = snake[currentWordIndex];
                        currentWordIndex++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (currentWordIndex == snake.Length)
                        {
                            currentWordIndex = 0;
                        }

                        matrix[row, col] = snake[currentWordIndex];
                        currentWordIndex++;
                    }
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
