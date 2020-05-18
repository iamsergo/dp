namespace Iterator
{
    class SequnceIterator
    {
        private int prev = 0;
        private int cur = 1;
        private int id;
        public void Next()
        {
            int c = prev + cur;
            this.prev = this.cur;
            this.cur = c;
            System.Console.WriteLine($"[{this.id++}] : {this.cur}");
        }
    }
}