using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int currentIndex;
        private List<T> items;

        public ListyIterator(List<T> initialItems)
        {
            this.currentIndex = 0;
            this.items = initialItems;
        }

        public int Count => this.items.Count;       

        public bool HasNext()
        {
            if (this.currentIndex < this.Count - 1)
            {
                return true;
            }
            return false;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.currentIndex++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Invalid operation");
            }
            Console.WriteLine(this.items[this.currentIndex]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            //while (this.currentIndex < this.Count)
            //{
            //    yield return this.items[this.currentIndex];

            //    if (!this.Move())
            //    {
            //        yield break;
            //    }
            //}

            foreach (T item in this.items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}
