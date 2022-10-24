using System;
using System.Linq;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            string carRacingNumber = Console.ReadLine();
            char[,] field = new char[sizeOfField, sizeOfField];

            for (int row = 0; row < sizeOfField; row++)
            {
                char[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < sizeOfField; col++)
                {
                    field[row, col] = line[col];
                }
            }

            int kilometersPassed = 0;
            int carRow = 0;
            int carCol = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine($"Racing car {carRacingNumber} DNF.");
                    break;
                }

                if (command == "up")
                {
                    carRow--;

                    if (field[carRow,carCol] == 'T')
                    {
                        field[carRow, carCol] = '.';

                        for (int row = 0; row < sizeOfField; row++)
                        {
                            for (int col = 0; col < sizeOfField; col++)
                            {
                                if (field[row,col] == 'T')
                                {
                                    carRow = row;
                                    carCol = col;
                                }
                            }
                        }

                        field[carRow, carCol] = '.';
                        kilometersPassed += 30;
                        continue;
                    }


                    if (field[carRow,carCol] == 'F')
                    {
                        kilometersPassed += 10;
                        Console.WriteLine($"Racing car {carRacingNumber} finished the stage!");
                        break;
                    }

                    kilometersPassed += 10;
                }
                else if(command == "down")
                {
                    carRow++;

                    if (field[carRow, carCol] == 'T')
                    {
                        field[carRow, carCol] = '.';

                        for (int row = 0; row < sizeOfField; row++)
                        {
                            for (int col = 0; col < sizeOfField; col++)
                            {
                                if (field[row, col] == 'T')
                                {
                                    carRow = row;
                                    carCol = col;
                                }
                            }
                        }

                        field[carRow, carCol] = '.';
                        kilometersPassed += 30;
                        continue;
                    }

                    if (field[carRow, carCol] == 'F')
                    {
                        kilometersPassed += 10;
                        Console.WriteLine($"Racing car {carRacingNumber} finished the stage!");
                        break;
                    }

                    kilometersPassed += 10;
                }
                else if(command == "left")
                {
                    carCol--;

                    if (field[carRow, carCol] == 'T')
                    {
                        field[carRow, carCol] = '.';

                        for (int row = 0; row < sizeOfField; row++)
                        {
                            for (int col = 0; col < sizeOfField; col++)
                            {
                                if (field[row, col] == 'T')
                                {
                                    carRow = row;
                                    carCol = col;
                                }
                            }
                        }

                        field[carRow, carCol] = '.';
                        kilometersPassed += 30;
                        continue;
                    }

                    if (field[carRow, carCol] == 'F')
                    {
                        kilometersPassed += 10;
                        Console.WriteLine($"Racing car {carRacingNumber} finished the stage!");
                        break;
                    }

                    kilometersPassed += 10;
                }
                else if(command == "right")
                {
                    carCol++;

                    if (field[carRow, carCol] == 'T')
                    {
                        field[carRow, carCol] = '.';

                        for (int row = 0; row < sizeOfField; row++)
                        {
                            for (int col = 0; col < sizeOfField; col++)
                            {
                                if (field[row, col] == 'T')
                                {
                                    carRow = row;
                                    carCol = col;
                                }
                            }
                        }

                        field[carRow, carCol] = '.';
                        kilometersPassed += 30;
                        continue;
                    }

                    if (field[carRow, carCol] == 'F')
                    {
                        kilometersPassed += 10;
                        Console.WriteLine($"Racing car {carRacingNumber} finished the stage!");
                        break;
                    }

                    kilometersPassed += 10;
                }
            }

            field[carRow, carCol] = 'C';
            Console.WriteLine($"Distance covered {kilometersPassed} km.");

            for (int row = 0; row < sizeOfField; row++)
            {
                for (int col = 0; col < sizeOfField; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
