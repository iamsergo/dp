using System.Collections.Generic;

namespace Iterator
{
    // Итератор по четным индексам
    class EvenIterator : IOddEvenIterator
    {
        private int id;
        private List<int> seq;
        public EvenIterator(List<int> seq)
        {
            this.seq = seq;
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