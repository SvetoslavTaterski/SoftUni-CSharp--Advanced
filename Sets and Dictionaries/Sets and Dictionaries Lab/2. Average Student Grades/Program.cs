using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var studentDictionary = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                string studentName = studentInfo[0];
                decimal studentGrade = decimal.Parse(studentInfo[1]);

                if (!studentDictionary.ContainsKey(studentName))
                {
                    studentDictionary.Add(studentName, new List<decimal>());
                }

                studentDictionary[studentName].Add(studentGrade);
            }

            foreach (var student in studentDictionary)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {student.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
