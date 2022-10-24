using System;

namespace _02._Help_A_Mole
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            char[,] field = new char[sizeOfField, sizeOfField];
            int moleRow = 0;
            int moleCol = 0;

            for (int row = 0; row < sizeOfField; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < sizeOfField; col++)
                {
                    field[row, col] = line[col];

                    if (field[row, col] == 'M')
                    {
                        moleRow = row;
                        moleCol = col;
                    }
                }
            }

            int totalPoints = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                field[moleRow, moleCol] = '-';
                int oldRow = moleRow;
                int oldCol = moleCol;

                if (command == "up")
                {
                    moleRow--;
                }
                else if (command == "down")
                {
                    moleRow++;
                }
                else if (command == "left")
                {
                    moleCol--;
                }
                else if (command == "right")
                {
                    moleCol++;
                }

                if (moleRow >= 0 && moleRow < sizeOfField && moleCol >= 0 && moleCol < sizeOfField)
                {
                    if (field[moleRow, moleCol] != '-' && field[moleRow, moleCol] != 'S')
                    {
                        int pointToCollect = (int)char.GetNumericValue(field[moleRow, moleCol]);
                        totalPoints += pointToCollect;
                        field[moleRow, moleCol] = '-';

                        if (totalPoints >= 25)
                        {
                            break;
                        }
                    }
                    else if (field[moleRow, moleCol] == 'S')
                    {
                        field[moleRow, moleCol] = '-';

                        for (int row = 0; row < sizeOfField; row++)
                        {
                            for (int col = 0; col < sizeOfField; col++)
                            {
                                if (field[row, col] == 'S')
                                {
                                    moleRow = row;
                                    moleCol = col;
                                    field[row, col] = '-';
                                    totalPoints -= 3;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Don't try to escape the playing field!");
                    moleRow = oldRow;
                    moleCol = oldCol;
                }
            }

            if (totalPoints >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {totalPoints} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {totalPoints} points.");
            }

            field[moleRow, moleCol] = 'M';

            for (int row = 0; row < sizeOfField; row++)
            {
                for (int col = 0; col < sizeOfField; col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
