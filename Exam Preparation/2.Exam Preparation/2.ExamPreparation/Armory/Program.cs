using System;

namespace Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArmory = int.Parse(Console.ReadLine());
            char[,] armory = new char[sizeOfArmory, sizeOfArmory];

            int officerRow = 0;
            int officerCol = 0;

            for (int row = 0; row < sizeOfArmory; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < sizeOfArmory; col++)
                {
                    armory[row, col] = line[col];

                    if (armory[row, col] == 'A')
                    {
                        officerRow = row;
                        officerCol = col;
                    }
                }
            }

            int boughtSwordsCount = 0;

            while (true)
            {
                string command = Console.ReadLine();
                armory[officerRow, officerCol] = '-';

                if (command == "up")
                {
                    officerRow--;

                    if (officerRow < 0 || officerRow > sizeOfArmory - 1)
                    {
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {boughtSwordsCount} gold coins.");

                        for (int row = 0; row < sizeOfArmory; row++)
                        {
                            for (int col = 0; col < sizeOfArmory; col++)
                            {
                                Console.Write(armory[row, col]);
                            }
                            Console.WriteLine();
                        }

                        return;
                    }

                    if (char.IsDigit(armory[officerRow, officerCol]))
                    {
                        int digit = (int)char.GetNumericValue(armory[officerRow, officerCol]);
                        boughtSwordsCount += digit;

                        if (boughtSwordsCount > 65)
                        {
                            armory[officerRow, officerCol] = 'A';
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {boughtSwordsCount} gold coins.");

                            for (int row = 0; row < sizeOfArmory; row++)
                            {
                                for (int col = 0; col < sizeOfArmory; col++)
                                {
                                    Console.Write(armory[row, col]);
                                }
                                Console.WriteLine();
                            }

                            return;
                        }
                        armory[officerRow, officerCol] = 'A';
                    }

                    if (armory[officerRow,officerCol] == 'M')
                    {
                        armory[officerRow, officerCol] = '-';
                        int mirrorRow = 0;
                        int mirrorCol = 0;

                        for (int row = 0; row < sizeOfArmory; row++)
                        {
                            for (int col = 0; col < sizeOfArmory; col++)
                            {
                                if (armory[row,col] == 'M')
                                {
                                    mirrorRow = row;
                                    mirrorCol = col;
                                }
                            }
                        }

                        officerRow = mirrorRow;
                        officerCol = mirrorCol;
                        armory[officerRow, officerCol] = 'A';
                    }
                }
                else if (command == "down")
                {
                    officerRow++;

                    if (officerRow < 0 || officerRow > sizeOfArmory - 1)
                    {
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {boughtSwordsCount} gold coins.");

                        for (int row = 0; row < sizeOfArmory; row++)
                        {
                            for (int col = 0; col < sizeOfArmory; col++)
                            {
                                Console.Write(armory[row, col]);
                            }
                            Console.WriteLine();
                        }

                        return;
                    }

                    if (char.IsDigit(armory[officerRow, officerCol]))
                    {
                        int digit = (int)char.GetNumericValue(armory[officerRow, officerCol]);
                        boughtSwordsCount += digit;

                        if (boughtSwordsCount > 65)
                        {
                            armory[officerRow, officerCol] = 'A';
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {boughtSwordsCount} gold coins.");

                            for (int row = 0; row < sizeOfArmory; row++)
                            {
                                for (int col = 0; col < sizeOfArmory; col++)
                                {
                                    Console.Write(armory[row, col]);
                                }
                                Console.WriteLine();
                            }

                            return;
                        }
                        armory[officerRow, officerCol] = 'A';
                    }

                    if (armory[officerRow, officerCol] == 'M')
                    {
                        armory[officerRow, officerCol] = '-';
                        int mirrorRow = 0;
                        int mirrorCol = 0;

                        for (int row = 0; row < sizeOfArmory; row++)
                        {
                            for (int col = 0; col < sizeOfArmory; col++)
                            {
                                if (armory[row, col] == 'M')
                                {
                                    mirrorRow = row;
                                    mirrorCol = col;
                                }
                            }
                        }

                        officerRow = mirrorRow;
                        officerCol = mirrorCol;
                        armory[officerRow, officerCol] = 'A';
                    }
                }
                else if (command == "left")
                {
                    officerCol--;

                    if (officerCol < 0 || officerCol > sizeOfArmory - 1)
                    {
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {boughtSwordsCount} gold coins.");

                        for (int row = 0; row < sizeOfArmory; row++)
                        {
                            for (int col = 0; col < sizeOfArmory; col++)
                            {
                                Console.Write(armory[row, col]);
                            }
                            Console.WriteLine();
                        }

                        return;
                    }

                    if (char.IsDigit(armory[officerRow, officerCol]))
                    {
                        int digit = (int)char.GetNumericValue(armory[officerRow, officerCol]);
                        boughtSwordsCount += digit;

                        if (boughtSwordsCount > 65)
                        {
                            armory[officerRow, officerCol] = 'A';
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {boughtSwordsCount} gold coins.");

                            for (int row = 0; row < sizeOfArmory; row++)
                            {
                                for (int col = 0; col < sizeOfArmory; col++)
                                {
                                    Console.Write(armory[row, col]);
                                }
                                Console.WriteLine();
                            }

                            return;
                        }
                        armory[officerRow, officerCol] = 'A';
                    }

                    if (armory[officerRow, officerCol] == 'M')
                    {
                        armory[officerRow, officerCol] = '-';
                        int mirrorRow = 0;
                        int mirrorCol = 0;

                        for (int row = 0; row < sizeOfArmory; row++)
                        {
                            for (int col = 0; col < sizeOfArmory; col++)
                            {
                                if (armory[row, col] == 'M')
                                {
                                    mirrorRow = row;
                                    mirrorCol = col;
                                }
                            }
                        }

                        officerRow = mirrorRow;
                        officerCol = mirrorCol;
                        armory[officerRow, officerCol] = 'A';
                    }
                }
                else if (command == "right")
                {
                    officerCol++;

                    if (officerCol < 0 || officerCol > sizeOfArmory - 1)
                    {
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {boughtSwordsCount} gold coins.");

                        for (int row = 0; row < sizeOfArmory; row++)
                        {
                            for (int col = 0; col < sizeOfArmory; col++)
                            {
                                Console.Write(armory[row, col]);
                            }
                            Console.WriteLine();
                        }

                        return;
                    }

                    if (char.IsDigit(armory[officerRow, officerCol]))
                    {
                        int digit = (int)char.GetNumericValue(armory[officerRow, officerCol]);
                        boughtSwordsCount += digit;

                        if (boughtSwordsCount > 65)
                        {
                            armory[officerRow, officerCol] = 'A';
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {boughtSwordsCount} gold coins.");

                            for (int row = 0; row < sizeOfArmory; row++)
                            {
                                for (int col = 0; col < sizeOfArmory; col++)
                                {
                                    Console.Write(armory[row, col]);
                                }
                                Console.WriteLine();
                            }

                            return;
                        }
                        armory[officerRow, officerCol] = 'A';
                    }

                    if (armory[officerRow, officerCol] == 'M')
                    {
                        armory[officerRow, officerCol] = '-';
                        int mirrorRow = 0;
                        int mirrorCol = 0;

                        for (int row = 0; row < sizeOfArmory; row++)
                        {
                            for (int col = 0; col < sizeOfArmory; col++)
                            {
                                if (armory[row, col] == 'M')
                                {
                                    mirrorRow = row;
                                    mirrorCol = col;
                                }
                            }
                        }

                        officerRow = mirrorRow;
                        officerCol = mirrorCol;
                        armory[officerRow, officerCol] = 'A';
                    }
                }
            }
        }
    }
}
