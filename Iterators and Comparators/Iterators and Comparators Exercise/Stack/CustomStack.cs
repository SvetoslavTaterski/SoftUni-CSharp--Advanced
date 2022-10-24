using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack : IEnumerable<int>
    {
        public List<int> Items { get; set; }

        public CustomStack()
        {
            Items = new List<int>();
        }

        public void Push(int item)
        {
            Items.Add(item);
        }

        public void Pop()
        {
            if (Items.Count == 0)
            {
                throw new Exception("No elements");
            }

            Items.RemoveAt(Items.Count -1);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = Items.Count - 1; i >= 0; i--)
            {
                yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
