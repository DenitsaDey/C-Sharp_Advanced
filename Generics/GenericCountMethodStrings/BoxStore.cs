using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class BoxStore<T> where T : IComparable
    {
        private List<Box<T>> boxes;

        public BoxStore()
        {
            this.boxes = new List<Box<T>>();
        }

        public void AddBox(Box<T> box)
        {
            this.boxes.Add(box);
        }

        public void SwapBoxes(int firstIndex, int secondIndex)
        {
            Box<T> temp = this.boxes[firstIndex];
            this.boxes[firstIndex] = this.boxes[secondIndex];
            this.boxes[secondIndex] = temp;
        }

        public int GetCount(T searchValue)
        {
            Box<T> searchedBox = new Box<T>(searchValue);
            //Box<T> searchedBox = this.boxes.First(b => b.MyCompareTo(new Box<T>(searchValue)) == 0);
            int counter = 0;
            foreach (Box<T> box in this.boxes)
            {
                if (searchedBox.IsLower(box))
                {
                    counter++;
                }
            }
            return counter;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Box<T> box in this.boxes)
            {
                sb.AppendLine(box.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
