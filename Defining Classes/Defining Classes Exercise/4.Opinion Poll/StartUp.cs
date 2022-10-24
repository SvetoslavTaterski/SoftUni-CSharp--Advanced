using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<Person> peopleOver30 = new List<Person>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = personInfo[0];
                int personAge = int.Parse(personInfo[1]);
                var person = new Person(personAge, personName);

                if (person.Age > 30)
                {
                    peopleOver30.Add(person);
                }
            }

            foreach (Person person in peopleOver30.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
