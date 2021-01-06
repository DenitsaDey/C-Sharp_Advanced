using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable
    {
        private T value;
        public Box(T value)
        {
            this.value = value;
        }
        public T Value
        {
            get => this.value;
            private set => this.value = value;
        }

        public int MyCompareTo(Box<T> otherBox)
        {
            int res = this.Value.CompareTo(otherBox.Value);
            return res;
        }

        public bool IsLower(Box<T> otherBox)
        {
            int res = this.Value.CompareTo(otherBox.Value);
            return res < 0;
        }
        public override string ToString()
        {
            return $"{typeof(T).FullName}: {this.Value}";
        }
    }
}
