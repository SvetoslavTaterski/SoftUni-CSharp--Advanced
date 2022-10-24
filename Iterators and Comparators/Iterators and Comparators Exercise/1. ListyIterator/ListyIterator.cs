using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1._ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public List<T> Elements { get; set; }
        public int Index { get; set; }

        public ListyIterator(List<T> elements)
        {
            Elements = elements;
            Index = 0;
        }

        public bool Move()
        {
            if (Index < Elements.Count - 1)
            {
                Index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return Index < Elements.Count - 1;
        }

        public void Print()
        {
            if (Elements.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }

            Console.WriteLine(Elements[Index]);
        }

        public void PrintAll()
        {
            if (Elements.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }

            foreach (var element in Elements)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Elements.Count-1; i++)
            {
                yield return Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
