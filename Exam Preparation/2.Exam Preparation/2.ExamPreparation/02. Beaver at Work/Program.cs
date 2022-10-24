using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfPound = int.Parse(Console.ReadLine());
            char[,] pound = new char[sizeOfPound, sizeOfPound];
            int beaverRow = 0;
            int beaverCol = 0;
            Stack<char> branches = new Stack<char>();

            for (int row = 0; row < sizeOfPound; row++)
            {
                char[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < sizeOfPound; col++)
                {
                    pound[row, col] = line[col];

                    if (pound[row, col] == 'B')
                    {
                        beaverRow = row;
                        beaverCol = col;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                pound[beaverRow, beaverCol] = '-';
                int oldRow = beaverRow;
                int oldCol = beaverCol;
                int count = 0;

                foreach (char element in pound)
                {
                    if (char.IsLower(element))
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    break;
                }

                if (command == "up")
                {
                    beaverRow--;

                    if (beaverRow < 0 || beaverRow > sizeOfPound - 1)
                    {
                        if (branches.Any())
                        {
                            branches.Pop();
                        }

                        beaverRow = oldRow;
                        beaverCol = oldCol;
                    }

                    if (char.IsLower(pound[beaverRow, beaverCol]))
                    {
                        branches.Push(pound[beaverRow, beaverCol]);
                    }

                    if (pound[beaverRow,beaverCol] == 'F')
                    {
                        pound[beaverRow, beaverCol] = '-';

                        if (beaverRow != 0)
                        {
                            int currentBeaverRow = beaverRow;
                            for (int i = currentBeaverRow; i >= 0 ; i--)
                            {
                                beaverRow--;
                            }

                            if (char.IsLower(pound[beaverRow,beaverCol]))
                            {
                                branches.Push(pound[beaverRow, beaverCol]);
                            }
                        }
                        else
                        {
                            int currentBeaverRow = beaverRow;
                            for (int i = currentBeaverRow; i < sizeOfPound -1; i++)
                            {
                                beaverRow++;
                            }

                            if (char.IsLower(pound[beaverRow, beaverCol]))
                            {
                                branches.Push(pound[beaverRow, beaverCol]);
                            }
                        }
                    }

                    pound[beaverRow, beaverCol] = 'B';
                }
                else if (command == "down")
                {
                    beaverRow++;

                    if (beaverRow < 0 || beaverRow > sizeOfPound - 1)
                    {
                        if (branches.Any())
                        {
                            branches.Pop();
                        }

                        beaverRow = oldRow;
                        beaverCol = oldCol;
                    }

                    if (char.IsLower(pound[beaverRow, beaverCol]))
                    {
                        branches.Push(pound[beaverRow, beaverCol]);
                    }

                    if (pound[beaverRow, beaverCol] == 'F')
                    {
                        pound[beaverRow, beaverCol] = '-';

                        if (beaverRow != sizeOfPound-1)
                        {
                            int currentBeaverRow = beaverRow;

                            for (int i = currentBeaverRow; i < sizeOfPound - 1; i++)
                            {
                                beaverRow++;
                            }

                            if (char.IsLower(pound[beaverRow, beaverCol]))
                            {
                                branches.Push(pound[beaverRow, beaverCol]);
                            }
                        }
                        else
                        {
                            int currentBeaverRow = beaverRow;

                            for (int i = currentBeaverRow; i >= 0; i--)
                            {
                                beaverRow--;
                            }

                            if (char.IsLower(pound[beaverRow, beaverCol]))
                            {
                                branches.Push(pound[beaverRow, beaverCol]);
                            }
                        }
                    }
                    pound[beaverRow, beaverCol] = 'B';

                }
                else if (command == "left")
                {
                    beaverCol--;

                    if (beaverCol < 0 || beaverCol > sizeOfPound - 1)
                    {
                        if (branches.Any())
                        {
                            branches.Pop();
                        }

                        beaverRow = oldRow;
                        beaverCol = oldCol;
                    }

                    if (char.IsLower(pound[beaverRow, beaverCol]))
                    {
                        branches.Push(pound[beaverRow, beaverCol]);
                    }

                    if (pound[beaverRow, beaverCol] == 'F')
                    {
                        pound[beaverRow, beaverCol] = '-';

                        if (beaverCol != 0)
                        {
                            int currentCol = beaverCol;

                            for (int i = currentCol; i >= 0; i--)
                            {
                                beaverCol--;
                            }

                            if (char.IsLower(pound[beaverRow, beaverCol]))
                            {
                                branches.Push(pound[beaverRow, beaverCol]);
                            }
                        }
                        else
                        {
                            int currentCol = beaverCol;

                            for (int i = 0; i < sizeOfPound - 1; i++)
                            {
                                beaverCol++;
                            }

                            if (char.IsLower(pound[beaverRow, beaverCol]))
                            {
                                branches.Push(pound[beaverRow, beaverCol]);
                            }
                        }
                    }
                    pound[beaverRow, beaverCol] = 'B';
                }
                else if (command == "right")
                {
                    beaverCol++;

                    if (beaverCol < 0 || beaverCol > sizeOfPound - 1)
                    {
                        if (branches.Any())
                        {
                            branches.Pop();
                        }

                        beaverRow = oldRow;
                        beaverCol = oldCol;
                    }

                    if (char.IsLower(pound[beaverRow, beaverCol]))
                    {
                        branches.Push(pound[beaverRow, beaverCol]);
                    }

                    if (pound[beaverRow,beaverCol] == 'F')
                    {
                        pound[beaverRow, beaverCol] = '-';

                        if (beaverCol != sizeOfPound - 1)
                        {
                            int currentCol = beaverCol;

                            for (int i = currentCol; i < sizeOfPound - 1; i++)
                            {
                                beaverCol++;
                            }

                            if (char.IsLower(pound[beaverRow, beaverCol]))
                            {
                                branches.Push(pound[beaverRow, beaverCol]);
                            }
                        }
                        else
                        {
                            int currentCol = beaverCol;

                            for (int i = currentCol; i >= 0; i--)
                            {
                                beaverCol--;
                            }

                            if (char.IsLower(pound[beaverRow, beaverCol]))
                            {
                                branches.Push(pound[beaverRow, beaverCol]);
                            }
                        }
                    }
                    pound[beaverRow, beaverCol] = 'B';
                }
            }

            int branchesInPound = 0;

            foreach (char element in pound)
            {
                if (char.IsLower(element))
                {
                    branchesInPound++;
                }
            }

            if (branchesInPound == 0)
            {
                pound[beaverRow, beaverCol] = 'B';
                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ",branches.Reverse())}.");

                for (int row = 0; row < sizeOfPound; row++)
                {
                    for (int col = 0; col < sizeOfPound; col++)
                    {
                        Console.Write($"{pound[row, col]} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {branchesInPound} branches left.");

                for (int row = 0; row < sizeOfPound; row++)
                {
                    for (int col = 0; col < sizeOfPound; col++)
                    {
                        Console.Write($"{pound[row, col]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
