using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class MyTuple<TItem1, TItem2>
    {
        private TItem1 item1;
        private TItem2 item2;

        public MyTuple(TItem1 item1, TItem2 item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public TItem1 Item1 => this.item1;
        public TItem2 Item2 => this.item2;

        public override string ToString()
        {
            return $"{this.item1} -> {this.item2}";
        }
    }
}
