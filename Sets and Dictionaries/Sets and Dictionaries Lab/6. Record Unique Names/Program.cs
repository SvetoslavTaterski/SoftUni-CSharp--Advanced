﻿using System;
using System.Collections.Generic;

namespace _6._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesToAdd = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < namesToAdd; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
