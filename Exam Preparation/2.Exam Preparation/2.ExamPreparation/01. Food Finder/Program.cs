using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Food_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));

            Dictionary<string, HashSet<int>> words = new Dictionary<string, HashSet<int>>();
            words.Add("pear", new HashSet<int>());
            words.Add("flour", new HashSet<int>());
            words.Add("pork", new HashSet<int>());
            words.Add("olive", new HashSet<int>());


            while (consonants.Count != 0)
            {
                char vowel = vowels.Dequeue();
                char consonant = consonants.Pop();

                foreach (var word in words)
                {
                    if (word.Key.Contains(vowel))
                    {
                        word.Value.Add(vowel);
                    }

                    if (word.Key.Contains(consonant))
                    {
                        word.Value.Add(consonant);
                    }
                }

                vowels.Enqueue(vowel);
            }

            var foundWords = new Dictionary<string, HashSet<int>>(words.Where(w => w.Value.Count == w.Key.Length));

            Console.WriteLine($"Words found: {foundWords.Count}");
            foreach (var word in foundWords)
            {
                Console.WriteLine(word.Key);
            }
        }
    }
}
