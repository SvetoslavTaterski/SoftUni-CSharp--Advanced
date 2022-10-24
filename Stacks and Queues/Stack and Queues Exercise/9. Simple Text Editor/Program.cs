using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            stack.Push("");

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string action = commands[0];

                if (action == "1")
                {
                    string someString = commands[1];
                    text.Append(someString);
                    stack.Push(text.ToString());
                }
                else if (action == "2")
                {
                    int count = int.Parse(commands[1]);
                    text.Remove(text.Length - count, count);
                    stack.Push(text.ToString());
                }
                else if (action == "3")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index <= text.Length)
                    {
                        Console.WriteLine(text[index-1]);
                    }
                }
                else if (action == "4")
                {
                    stack.Pop();
                    text = new StringBuilder();
                    text.Append(stack.Peek());
                    
                }
            }
        }
    }
}
