using System.Collections.Generic;

namespace Iterator
{
    class Sequence : ISequence
    {
        private List<int> seq;
        public Sequence(List<int> seq)
        {
            this.seq = seq;
        }
        public OddIterator CreateOddIterator()
        {
            return new OddIterator(this.seq);
        }
        public EvenIterator CreateEvenIterator()
        {
            return new EvenIterator(this.seq);
        }
    }
}