using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (char item in input)
            {
                if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == '{')
                {
                    stack.Push(item);
                }
                else if (item == '[')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    if (stack.Any() && stack.Peek()=='(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (item == '}')
                {
                    if (stack.Any() && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (item == ']')
                {
                    if (stack.Any() && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
