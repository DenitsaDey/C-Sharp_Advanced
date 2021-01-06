﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
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

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {this.Value}";
        }
    }
}
