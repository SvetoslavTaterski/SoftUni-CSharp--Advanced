using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Meal_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meals = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> mealsQueue = new Queue<string>(meals);
            int mealsQueueCount = mealsQueue.Count;

            int[] calories = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> caloriesStack = new Stack<int>(calories);

            Dictionary<string, int> mealsAndCalories = new Dictionary<string, int>();
            mealsAndCalories.Add("salad", 350);
            mealsAndCalories.Add("soup", 490);
            mealsAndCalories.Add("pasta", 680);
            mealsAndCalories.Add("steak", 790);

            int caloriesDay = 0;
            string meal = string.Empty;
            int eatenMeals = 0;

            while (mealsQueue.Count != 0 && caloriesStack.Count != 0)
            {
                caloriesDay = caloriesStack.Peek();
                meal = mealsQueue.Peek();

                while (caloriesDay - mealsAndCalories[meal] >= 0)
                {
                    caloriesDay -= mealsAndCalories[meal];
                    mealsQueue.Dequeue();
                    eatenMeals++;

                    if (mealsQueue.Any())
                    {
                        meal = mealsQueue.Peek();
                    }
                    else
                    {
                        caloriesStack.Pop();
                        caloriesStack.Push(caloriesDay);
                        break;
                    }

                    if (caloriesDay - mealsAndCalories[meal] < 0)
                    {
                        mealsAndCalories[meal] -= caloriesDay;
                        caloriesStack.Pop();
                        if (caloriesStack.Count == 0)
                        {
                            mealsQueue.Dequeue();
                            eatenMeals++;
                        }
                        break;
                    }
                }
            }

            if (mealsQueue.Count == 0)
            {
                Console.WriteLine($"John had {mealsQueueCount} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ",caloriesStack)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {eatenMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ",mealsQueue)}.");
            }
        }
    }
}
