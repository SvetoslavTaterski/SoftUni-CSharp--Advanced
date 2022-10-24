using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class TupleClass<T1,T2,T3>
    {
        public T1 Item1 { get; set; }

        public T2 Item2 { get; set; }

        public T3 Item3 { get; set; }

        public TupleClass(T1 firstItem, T2 secondItem,T3 thirdItem)
        {
            Item1 = firstItem;
            Item2 = secondItem;
            Item3 = thirdItem;
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
