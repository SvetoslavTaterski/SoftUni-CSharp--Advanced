using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _1.Generic_Box_of_String
{
    public class Box<T> where T : IComparable
    {
        public List<T> Items { get; set; }

        public Box()
        {
            Items = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString();
        }

        public void Swap(int first, int second)
        {
            T temp = Items[first];
            Items[first] = Items[second];
            Items[second] = temp;
        }

        public int Count(T value)
        {
            int count = 0;

            foreach (var item in Items)
            {
                if (item.CompareTo(value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
