using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> func1 = (firstNum, secondNum) =>
            {
                if (firstNum != 0 && secondNum != 0)
                {
                    return 1;
                }

                return 0;
            };

            Func<int, int, int> func2 = (firstNum, secondNum) =>
            {
                if (firstNum != 0 || secondNum != 0)
                {
                    return 1;
                }

                return 0;
            };

            Func<int, int, int> func3 = (firstNum, secondNum) =>
              {
                  if (firstNum != 0 && secondNum != 0)
                  {
                      return 0;
                  }

                  return 1;
              };

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine()); ;
            //int thirdNum = int.Parse(Console.ReadLine()); ;
            //int fourthNum = int.Parse(Console.ReadLine()); ;

            int func1Result = func1(firstNum, secondNum);
            //int func2Result = func2(func1(firstNum, secondNum), thirdNum);
            //int func3Result = func3(func2(func1(firstNum, secondNum), thirdNum), fourthNum);

            Console.WriteLine(func1Result);
        }
    }
}
