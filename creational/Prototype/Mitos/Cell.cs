namespace Prototype
{
    class Cell : ICloneable<Cell>
    {
        private bool live;
        public Cell(bool live)
        {
            this.live = live;
        }
        public Cell(Cell source) : this(source.live)
        {
            this.live = source.live;
        }
        public Cell Clone()
        {
            return new Cell(this);
        }
        override public string ToString()
        {
            return this.live ? "Жива!" : "Не жива!";
        }
    }
}