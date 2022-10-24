using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T LeftItem;
        private T RightItem;

        public EqualityScale(T leftItem,T rightItem)
        {
            LeftItem = leftItem;
            RightItem = rightItem;
        }

        public bool AreEqual()
        {
            return LeftItem.Equals(RightItem); 
        }
    }
}
