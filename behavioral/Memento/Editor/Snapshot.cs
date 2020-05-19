namespace Memento
{
    // Снимок - хранит прошлое состояние редактора
    class Snapshot
    {
        private Editor editor;
        private int x;
        private int y;
        private string text;
        public Snapshot(Editor editor, int x, int y, string text)
        {
            this.editor = editor;
            this.x = x;
            this.y = y;
            this.text = text;
        }
        // Метод восстановления
        public void Restore()
        {
            this.editor.SetCursor(this.x, this.y);
            this.editor.SetText(this.text);
        }
    }
}