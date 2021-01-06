using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodInt
{
    public class BoxStore<T>
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
