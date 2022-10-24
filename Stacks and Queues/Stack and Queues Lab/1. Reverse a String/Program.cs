using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (char letter in input)
            {
                stack.Push(letter);
            }

            while (stack.Count>0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
