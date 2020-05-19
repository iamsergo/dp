namespace Memento
{
    // Команда - опекун
    class Command
    {
        private Snapshot backup;
        private Editor editor;
        public Command(Editor editor)
        {
            this.editor = editor;
        }
        public void MakeBackup()
        {
            this.backup = this.editor.CreateSnapshot();
        }
        public void Undo()
        {
            if(this.backup != null)
            {
                this.backup.Restore();
            }
        }
    }
}