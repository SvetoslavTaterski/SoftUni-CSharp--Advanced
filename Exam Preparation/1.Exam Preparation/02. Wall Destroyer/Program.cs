using System;

namespace _02._Wall_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];
            int vankoIndexRow = 0;
            int vankoIndexCol = 0;

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    if (line[col] == 'V')
                    {
                        vankoIndexRow = row;
                        vankoIndexCol = col;
                    }
                    matrix[row, col] = line[col];
                }
            }

            int holes = 1;
            int rods = 0;
            bool isElectrocuted = false;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                matrix[vankoIndexRow, vankoIndexCol] = '*';
                int oldRowIndex = vankoIndexRow;
                int oldColIndex = vankoIndexCol;

                if (command == "up")
                {
                    vankoIndexRow--;
                }
                else if (command == "down")
                {
                    vankoIndexRow++;
                }
                else if (command == "left")
                {
                    vankoIndexCol--;
                }
                else if (command == "right")
                {
                    vankoIndexCol++;
                }

                if (vankoIndexRow >= 0 && vankoIndexRow < sizeOfMatrix && vankoIndexCol >= 0 && vankoIndexCol < sizeOfMatrix)
                {
                    if (matrix[vankoIndexRow,vankoIndexCol] == '-')
                    {
                        matrix[vankoIndexRow, vankoIndexCol] = '*';
                        holes++;
                    }
                    else if (matrix[vankoIndexRow, vankoIndexCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rods++;
                        vankoIndexRow = oldRowIndex;
                        vankoIndexCol = oldColIndex;
                    }
                    else if (matrix[vankoIndexRow, vankoIndexCol] == 'C')
                    {
                        matrix[vankoIndexRow, vankoIndexCol] = 'E';
                        holes++;
                        isElectrocuted = true;
                        break;
                    }
                    else if(matrix[vankoIndexRow, vankoIndexCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{vankoIndexRow}, {vankoIndexCol}]!");
                    }
                }
                else
                {
                    vankoIndexRow = oldRowIndex;
                    vankoIndexCol = oldColIndex;
                }
            }

            if (isElectrocuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
            }
            else
            {
                matrix[vankoIndexRow, vankoIndexCol] = 'V';
                Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {rods} rod(s).");
            }


            for (int row = 0; row < sizeOfMatrix; row++)
            {
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
