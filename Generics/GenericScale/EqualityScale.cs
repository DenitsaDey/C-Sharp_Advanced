using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    class EqualityScale<T>
    {
        private readonly T left;
        private readonly T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            var result = left.Equals(right);
            return result;
        }

    }
}
