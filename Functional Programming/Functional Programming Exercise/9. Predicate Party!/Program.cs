using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<string>, string, string, string> startsWithOrEndsWith = (people, action, criteria, word) =>
             {
                 for (int i = 0; i < people.Count; i++)
                 {
                     if (action == "Remove")
                     {
                         if (criteria == "StartsWith")
                         {
                             people.RemoveAll(p => p.StartsWith(word));
                             break;
                         }
                         else if (criteria == "EndsWith")
                         {
                             people.RemoveAll(p => p.EndsWith(word));
                             break;
                         }
                         else
                         {
                             people.RemoveAll(p => p.Count() == int.Parse(word));
                             break;
                         }
                     }
                     else
                     {
                         if (criteria == "StartsWith")
                         {
                             string[] guys = people.FindAll(p => p.StartsWith(word)).ToArray();

                             for (int j = 0; j < guys.Length; j++)
                             {
                                 int index = people.IndexOf(guys[j]);
                                 people.Insert(index, guys[j]);
                             }
                             break;
                         }
                         else if (criteria == "EndsWith")
                         {
                             string[] guys = people.FindAll(p => p.EndsWith(word)).ToArray();

                             for (int j = 0; j < guys.Length; j++)
                             {
                                 int index = people.IndexOf(guys[j]);
                                 people.Insert(index, guys[j]);
                             }
                             break;
                         }
                         else
                         {
                             string[] guys = people.FindAll(p => p.Count() == int.Parse(word)).ToArray();

                             for (int j = 0; j < guys.Length; j++)
                             {
                                 int index = people.IndexOf(guys[j]);
                                 people.Insert(index, guys[j]);
                             }
                             break;
                         }
                     }
                 }
             };


            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Party!")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string criteria = tokens[1];
                string word = tokens[2];

                startsWithOrEndsWith(people, action, criteria, word);
            }

            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ",people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
