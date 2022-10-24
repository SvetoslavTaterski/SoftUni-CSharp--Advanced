using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Generic_Box_of_String
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfCommands = double.Parse(Console.ReadLine());
            Box<double> boxes = new Box<double>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                double command = double.Parse(Console.ReadLine());
                boxes.Items.Add(command);
            }

            double element = double.Parse(Console.ReadLine());

            Console.WriteLine(boxes.Count(element));
        }
    }
}
