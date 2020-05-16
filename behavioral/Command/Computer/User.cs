namespace Command
{
    // Пользователь - отправитель(вызыватель)
    class User
    {
        private ComputerCommand start;
        private ComputerCommand finish;
        public User(ComputerCommand start, ComputerCommand finish)
        {
            this.start = start;
            this.finish = finish;
        }
        public void Start()
        {
            this.start.Execute();
        }
        public void Finish()
        {
            this.finish.Execute();
        }
    }
}