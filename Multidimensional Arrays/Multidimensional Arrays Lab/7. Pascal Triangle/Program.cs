using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[inputNumber][];

            for (int row = 0; row < inputNumber; row++)
            {
                jaggedArray[row] = new long[row + 1];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (row == 0)
                    {
                        jaggedArray[row][col] = 1;
                        continue;
                    }

                    long currValue = 0;

                    if (col > 0 && row > 0)
                    {
                        currValue += jaggedArray[row - 1][col - 1];
                    }

                    if (jaggedArray[row].Length - 1 > col)
                    {
                        currValue += jaggedArray[row - 1][col];
                    }

                    jaggedArray[row][col] = currValue;
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
