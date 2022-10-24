namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text;

    public class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            ProcessLines(inputPath, outputPath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = 0;
                int symbolsCount = 0;
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    if (char.IsLetter(currentLine[j]))
                    {
                        lettersCount++;
                    }
                    else if (char.IsPunctuation(currentLine[j]))
                    {
                        symbolsCount++;
                    }
                }

                string stringToAdd = $"Line {i+1}: {currentLine} ({lettersCount})({symbolsCount})";
                sb.AppendLine(stringToAdd);

                File.WriteAllText(outputFilePath, sb.ToString());
            }
        }

    }
}