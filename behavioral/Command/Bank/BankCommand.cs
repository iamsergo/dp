namespace Command
{
    // Общий интерфейс команды
    abstract class BankCommand
    {
        protected Client client;
        protected int amount;
        public BankCommand(Client client, int amount)
        {
            this.client = client;
            this.amount = amount;
        }
        abstract public void Execute();
        abstract public void Undo();
    }
}