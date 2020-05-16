namespace Command
{
    // Снятие - конкретная команда
    class Decrement : BankCommand
    {
        public Decrement(Client client, int amount) : base(client, amount) {}
        override public void Execute()
        {
            this.client.Balance -= this.amount;
        }
        override public void Undo()
        {
            System.Console.WriteLine("[undo]");
            this.client.Balance += this.amount;
        }
        override public string ToString()
        {
            return $"[dec] : -{this.amount}";
        }
    }
}