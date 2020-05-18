using System.Collections.Generic;

namespace Iterator
{
    // Итератор по нечетным индексам
    class OddIterator : IOddEvenIterator
    {
        private int id;
        private List<int> seq;
        public OddIterator(List<int> seq)
        {
            this.seq = seq;
            this.id = 1;
        }
        public object Next()
        {
            int el = this.seq[this.id];
            this.id += 2;
            return el;
        }
        public bool CanMove()
        {
            return this.id < this.seq.Count;
        }
    }
}