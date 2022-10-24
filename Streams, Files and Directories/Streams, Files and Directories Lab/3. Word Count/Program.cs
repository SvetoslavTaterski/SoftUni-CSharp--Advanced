using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader wordsReader = new StreamReader(wordsFilePath))
            {
                using (StreamReader textReader = new StreamReader(textFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        Dictionary<string, int> matchingWords = new Dictionary<string, int>();
                        string[] words = wordsReader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                        while (!textReader.EndOfStream)
                        {
                            string line = textReader.ReadLine().ToLower();

                            for (int i = 0; i < words.Length; i++)
                            {
                                if (line.Contains(words[i]))
                                {
                                    if (!matchingWords.ContainsKey(words[i]))
                                    {
                                        matchingWords.Add(words[i], 0);
                                    }
                                    matchingWords[words[i]]++;
                                }

                            }
                        }

                        var sorted = matchingWords.OrderByDescending(n => n.Value).ToDictionary(n => n.Key, n => n.Value);

                        foreach (var item in sorted)
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
