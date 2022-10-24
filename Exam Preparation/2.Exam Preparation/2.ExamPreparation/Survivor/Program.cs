using System;
using System.Linq;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            char[][] beach = new char[numberOfRows][];

            for (int row = 0; row < numberOfRows; row++)
            {
                char[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                beach[row] = line;
            }

            int playerTokens = 0;
            int oponentTokens = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Gong")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];

                if (action == "Find")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);

                    if (row >= 0 && row < numberOfRows && col >= 0 && col < beach[row].Length)
                    {
                        if (beach[row][col] == 'T')
                        {
                            playerTokens++;
                            beach[row][col] = '-';
                        }
                    }
                    else
                    {

                    }
                }
                else if (action == "Opponent")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    string direction = tokens[3];

                    if (row >= 0 && row < numberOfRows && col >= 0 && col < beach[row].Length)
                    {
                        if (beach[row][col] == 'T')
                        {
                            oponentTokens++;
                            beach[row][col] = '-';
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            if (direction == "up")
                            {
                                row--;
                                if (row < 0 || row > numberOfRows - 1)
                                {

                                }
                                else
                                {
                                    if (beach[row][col] == 'T')
                                    {
                                        oponentTokens++;
                                        beach[row][col] = '-';
                                    }
                                }
                            }
                            else if (direction == "down")
                            {
                                row++;
                                if (row < 0 || row > numberOfRows - 1)
                                {

                                }
                                else
                                {
                                    if (beach[row][col] == 'T')
                                    {
                                        oponentTokens++;
                                        beach[row][col] = '-';
                                    }
                                }
                            }
                            else if (direction == "left")
                            {
                                col--;
                                if (col < 0 || col > beach[row].Length - 1)
                                {

                                }
                                else
                                {
                                    if (beach[row][col] == 'T')
                                    {
                                        oponentTokens++;
                                        beach[row][col] = '-';
                                    }
                                }
                            }
                            else if (direction == "right")
                            {
                                col++;
                                if (col < 0 || col > beach[row].Length -1)
                                {

                                }
                                else
                                {
                                    if (beach[row][col] == 'T')
                                    {
                                        oponentTokens++;
                                        beach[row][col] = '-';
                                    }
                                }
                            }
                        }
                    }
                    else
                    {

                    }
                }
            }

            for (int row = 0; row < numberOfRows; row++)
            {
                Console.Write(string.Join(" ", beach[row]));
                Console.WriteLine();
            }
            Console.WriteLine($"Collected tokens: {playerTokens}");
            Console.WriteLine($"Opponent's tokens: {oponentTokens}");
        }
    }
}
