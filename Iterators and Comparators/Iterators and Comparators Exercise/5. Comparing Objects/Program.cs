using System;
using System.Collections.Generic;

namespace _5._Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] personProp = command.Split();

                Person person = new Person(personProp[0], int.Parse(personProp[1]), personProp[2]);
                people.Add(person);
            }

            int indexOfPerson = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = people[indexOfPerson];

            int equalCount = 0;
            int diffCount = 0;

            foreach (Person person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
            }
        }
    }
}
