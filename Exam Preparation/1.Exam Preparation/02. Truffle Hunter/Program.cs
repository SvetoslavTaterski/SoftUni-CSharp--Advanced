using System;
using System.Linq;

namespace _02._Truffle_Hunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                char[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int blackTrufflePeter = 0;
            int summerTrufflePeter = 0;
            int whiteTrufflePeter = 0;

            int blackTruffleBoar = 0;
            int summerTruffleBoar = 0;
            int whiteTruffleBoar = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop the hunt")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];

                if (action == "Collect")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);

                    if (matrix[row, col] == 'B')
                    {
                        blackTrufflePeter++;
                        matrix[row, col] = '-';
                    }
                    else if (matrix[row, col] == 'S')
                    {
                        summerTrufflePeter++;
                        matrix[row, col] = '-';
                    }
                    else if (matrix[row, col] == 'W')
                    {
                        whiteTrufflePeter++;
                        matrix[row, col] = '-';
                    }
                }
                else if (action == "Wild_Boar")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    string direction = tokens[3];

                    if (direction == "up")
                    {
                        for (int i = row; i >= 0; i--)
                        {
                            if (i % 2 == 0)
                            {
                                if (matrix[i, col] == 'B')
                                {
                                    blackTruffleBoar++;
                                    matrix[i, col] = '-';
                                }
                                else if (matrix[i, col] == 'S')
                                {
                                    summerTruffleBoar++;
                                    matrix[i, col] = '-';
                                }
                                else if (matrix[i, col] == 'W')
                                {
                                    whiteTruffleBoar++;
                                    matrix[i, col] = '-';
                                }
                            }
                        }
                    }
                    else if (direction == "down")
                    {
                        for (int i = row; i < sizeOfMatrix; i++)
                        {
                            if (i % 2 == 0)
                            {
                                if (matrix[i, col] == 'B')
                                {
                                    blackTruffleBoar++;
                                    matrix[i, col] = '-';
                                }
                                else if (matrix[i, col] == 'S')
                                {
                                    summerTruffleBoar++;
                                    matrix[i, col] = '-';
                                }
                                else if (matrix[i, col] == 'W')
                                {
                                    whiteTruffleBoar++;
                                    matrix[i, col] = '-';
                                }
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int i = col; i >= 0; i--)
                        {
                            if (i % 2 == 0)
                            {
                                if (matrix[row, i] == 'B')
                                {
                                    blackTruffleBoar++;
                                    matrix[row, i] = '-';
                                }
                                else if (matrix[row, i] == 'S')
                                {
                                    summerTruffleBoar++;
                                    matrix[row, i] = '-';
                                }
                                else if (matrix[row, i] == 'W')
                                {
                                    whiteTruffleBoar++;
                                    matrix[row, i] = '-';
                                }
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = col; i < sizeOfMatrix; i++)
                        {
                            if (i % 2 != 0)
                            {
                                if (matrix[row, i] == 'B')
                                {
                                    blackTruffleBoar++;
                                    matrix[row, i] = '-';
                                }
                                else if (matrix[row, i] == 'S')
                                {
                                    summerTruffleBoar++;
                                    matrix[row, i] = '-';
                                }
                                else if (matrix[row, i] == 'W')
                                {
                                    whiteTruffleBoar++;
                                    matrix[row, i] = '-';
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Peter manages to harvest {blackTrufflePeter} black, {summerTrufflePeter} summer, and {whiteTrufflePeter} white truffles.");
            Console.WriteLine($"The wild boar has eaten {blackTruffleBoar+summerTruffleBoar+whiteTruffleBoar} truffles.");

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
