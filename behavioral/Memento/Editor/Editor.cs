namespace Memento
{
    // Редактор - создатель - сохраняет состояние в снимке
    class Editor
    {
        private int x;
        private int y;
        private string text;
        public void SetText(string text)
        {
            this.text = text;
        }
        public void SetCursor(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Snapshot CreateSnapshot()
        {
            return new Snapshot(
                this,
                this.x,
                this.y,
                this.text
            );
        }
        override public string ToString()
        {
            return $"[{this.x};{this.y}] : {this.text}";
        }
    }
}