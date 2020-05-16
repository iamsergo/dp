namespace Command
{
    // Конкретная команда
    // Финиш - Выключение ПК
    class FinishCommand : ComputerCommand
    {
        public FinishCommand(Computer computer) : base(computer) {}
        override public void Execute()
        {
            this.computer.Finish();
        }
    }
}