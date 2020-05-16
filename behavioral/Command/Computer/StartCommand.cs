namespace Command
{
    // Конкретная команда
    // Старт - выключение ПК
    class StartCommand : ComputerCommand
    {
        public StartCommand(Computer computer) : base(computer) {}
        override public void Execute()
        {
            this.computer.Start();
        }
    }
}