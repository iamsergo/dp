namespace Command
{
    // Общий интерфейс команд
    abstract class ComputerCommand
    {
        protected Computer computer;
        public ComputerCommand(Computer computer)
        {
            this.computer = computer;
        }
        // Главный метод
        abstract public void Execute();
    }
}