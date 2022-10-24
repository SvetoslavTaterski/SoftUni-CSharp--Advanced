using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothesStack = new Stack<int>(clothes);
            int counter = 0;

            while (clothesStack.Count > 0)
            {
                int currSum = 0;

                while (currSum <= rackCapacity && clothesStack.Any())
                {
                    if (currSum < rackCapacity)
                    {
                        if (currSum + clothesStack.Peek() > rackCapacity)
                        {
                            counter++;
                            break;
                        }

                        currSum += clothesStack.Pop();

                        if (clothesStack.Count == 0)
                        {
                            counter++;
                            break;
                        }
                    }
                    else if (currSum == rackCapacity)
                    {
                        if (clothesStack.Any())
                        {
                            counter++;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(counter);
        }
    }
}
