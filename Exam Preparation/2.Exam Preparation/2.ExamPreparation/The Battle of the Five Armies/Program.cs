using System;
using System.Linq;

namespace The_Battle_of_the_Five_Armies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int sizeOfField = int.Parse(Console.ReadLine());
            char[][] field = new char[sizeOfField][];

            int armyRow = 0;
            int armyCol = 0;

            for (int row = 0; row < sizeOfField; row++)
            {
                string line = Console.ReadLine();
                field[row] = line.ToCharArray();

                if (field[row].Any(c => c == 'A'))
                {
                    armyRow = row;
                    armyCol = field[row].First(c => c == 'A');
                }

            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = command[0];
                int orcsRow = int.Parse(command[1]);
                int orcsCol = int.Parse(command[2]);

                field[armyRow][armyCol] = '-';
                field[orcsRow][orcsCol] = 'O';

                int armyOldRow = armyRow;
                int armyOldCol = armyCol;

                if (action == "up")
                {
                    armyRow--;
                    if (armyRow < 0 && armyRow > sizeOfField - 1)
                    {
                        armyRow = armyOldRow;
                    }

                    if (field[armyRow][armyCol] == 'O')
                    {
                        armor -= 3;

                        if (armor <= 0)
                        {
                            field[armyRow][armyCol] = 'X';
                            Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");

                            for (int row = 0; row < sizeOfField; row++)
                            {
                                for (int col = 0; col < sizeOfField; col++)
                                {
                                    Console.Write(field[row][col]);
                                }
                                Console.WriteLine();
                            }

                            break;
                        }

                        field[armyRow][armyCol] = '-';
                    }

                    if (field[armyRow][armyCol] == 'M')
                    {
                        armor -= 1;
                        field[armyRow][armyCol] = '-';
                        Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");

                        for (int row = 0; row < sizeOfField; row++)
                        {
                            for (int col = 0; col < sizeOfField; col++)
                            {
                                Console.Write(field[row][col]);
                            }
                            Console.WriteLine();
                        }
                        break;
                    }

                    armor -= 1;
                }
                else if (action == "down")
                {
                    armyRow++;
                    if (armyRow < 0 && armyRow > sizeOfField - 1)
                    {
                        armyRow = armyOldRow;
                    }

                    if (field[armyRow][armyCol] == 'O')
                    {
                        armor -= 3;

                        if (armor <= 0)
                        {
                            field[armyRow][armyCol] = 'X';
                            Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");

                            for (int row = 0; row < sizeOfField; row++)
                            {
                                for (int col = 0; col < sizeOfField; col++)
                                {
                                    Console.Write(field[row][col]);
                                }
                                Console.WriteLine();
                            }

                            break;
                        }

                        field[armyRow][armyCol] = '-';
                    }

                    if (field[armyRow][armyCol] == 'M')
                    {
                        armor -= 1;
                        field[armyRow][armyCol] = '-';
                        Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");

                        for (int row = 0; row < sizeOfField; row++)
                        {
                            for (int col = 0; col < sizeOfField; col++)
                            {
                                Console.Write(field[row][col]);
                            }
                            Console.WriteLine();
                        }
                        break;
                    }

                    armor -= 1;
                }
                else if (action == "left")
                {
                    armyCol--;

                    if (armyCol < 0 && armyCol > sizeOfField - 1)
                    {
                        armyCol = armyOldCol;
                    }

                    if (field[armyRow][armyCol] == 'O')
                    {
                        armor -= 3;

                        if (armor <= 0)
                        {
                            field[armyRow][armyCol] = 'X';
                            Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");

                            for (int row = 0; row < sizeOfField; row++)
                            {
                                for (int col = 0; col < sizeOfField; col++)
                                {
                                    Console.Write(field[row][col]);
                                }
                                Console.WriteLine();
                            }

                            break;
                        }

                        field[armyRow][armyCol] = '-';
                    }

                    if (field[armyRow][armyCol] == 'M')
                    {
                        armor -= 1;
                        field[armyRow][armyCol] = '-';
                        Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");

                        for (int row = 0; row < sizeOfField; row++)
                        {
                            for (int col = 0; col < sizeOfField; col++)
                            {
                                Console.Write(field[row][col]);
                            }
                            Console.WriteLine();
                        }
                        break;
                    }

                    armor -= 1;
                }
                else if (action == "right")
                {
                    armyCol++;

                    if (armyCol < 0 && armyCol > sizeOfField - 1)
                    {
                        armyCol = armyOldCol;
                    }

                    if (field[armyRow][armyCol] == 'O')
                    {
                        armor -= 3;

                        if (armor <= 0)
                        {
                            field[armyRow][armyCol] = 'X';
                            Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");

                            for (int row = 0; row < sizeOfField; row++)
                            {
                                for (int col = 0; col < sizeOfField; col++)
                                {
                                    Console.Write(field[row][col]);
                                }
                                Console.WriteLine();
                            }

                            break;
                        }

                        field[armyRow][armyCol] = '-';
                    }

                    if (field[armyRow][armyCol] == 'M')
                    {
                        armor -= 1;
                        field[armyRow][armyCol] = '-';
                        Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");

                        for (int row = 0; row < sizeOfField; row++)
                        {
                            for (int col = 0; col < sizeOfField; col++)
                            {
                                Console.Write(field[row][col]);
                            }
                            Console.WriteLine();
                        }
                        break;
                    }

                    armor -= 1;
                }
            }
        }
    }
}
