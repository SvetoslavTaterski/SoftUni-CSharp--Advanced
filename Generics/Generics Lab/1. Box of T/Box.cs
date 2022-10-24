using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public int Count { get; set; }
        public Stack<T> Stack { get; set; }

        public Box()
        {
            Count = 0;
            Stack = new Stack<T>();
        }

        public void Add(T element)
        {
            Stack.Push(element);
            Count++;
        }

        public T Remove()
        {
            Count--;
            return Stack.Pop();
        }
    }
}
