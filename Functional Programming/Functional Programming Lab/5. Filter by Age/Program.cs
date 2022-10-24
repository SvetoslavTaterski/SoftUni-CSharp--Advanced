using System;
using System.Collections.Generic;

namespace _5._Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPersons = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>(numberOfPersons);

            for (int i = 0; i < numberOfPersons; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                var person = new Person(int.Parse(personInfo[1]), personInfo[0]);
                persons.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<Person, bool> filter = CreateFilter(condition, age);
            Action<Person> printer = CreatePrinter(format);

            foreach (Person person in persons)
            {
                if (filter(person))
                {
                    printer(person);
                }
            }
        }

        private static Func<Person, bool> CreateFilter(string condition, int age)
        {
            if (condition == "younger")
            {
                return person => person.Age < age;
            }
            else if (condition == "older")
            {
                return person => person.Age >= age;
            }

            throw new ArgumentException(condition);
        }

        private static Action<Person> CreatePrinter(string[] format)
        {
            if (format.Length == 2)
            {
                if (format[0] == "name" || format[1] == "age")
                {
                    return person => Console.WriteLine($"{person.Name} - {person.Age}");
                }
                else if (format[0] == "age" || format[1] == "name")
                {
                    return person => Console.WriteLine($"{person.Age} - {person.Name}");
                }
            }
            else if (format.Length == 1)
            {
                if (format[0] == "name")
                {
                    return person => Console.WriteLine($"{person.Name}");
                }
                else if (format[0] == "age")
                {
                    return person => Console.WriteLine($"{person.Age}");
                }
            }

            throw new ArgumentException(format[2]);
        }
    }

    public class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
