using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(people);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] tokens = command.Split("", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];

                if (action == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
                else if (action == "Move")
                {
                    bool flag = listyIterator.Move();

                    if (flag)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "HasNext")
                {
                    bool flag = listyIterator.HasNext();

                    if (flag)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "PrintAll")
                {
                    try
                    {
                        listyIterator.PrintAll();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            }
        }
    }
}
