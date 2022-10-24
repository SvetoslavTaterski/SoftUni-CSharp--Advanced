namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();

            string line = string.Empty;
            int count = 0;

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                while (line != null)
                {
                    line = reader.ReadLine();

                    if (count % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        string reversedWords = ReversedWords(replacedSymbols);
                        sb.AppendLine(reversedWords);
                    }

                    count++;
                }

            }

            return sb.ToString().TrimEnd();
        }

        private static string ReplaceSymbols(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '-' ||
                    line[i] == '.' ||
                    line[i] == ',' ||
                    line[i] == '!' ||
                    line[i] == '?')
                {
                    line = line.Replace(line[i], '@');
                }
            }

            return line;
        }

        private static string ReversedWords(string replacedSymbols)
        {
            string[] reversedWords = replacedSymbols
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            return string.Join(" ", reversedWords);
        }
    }
}
