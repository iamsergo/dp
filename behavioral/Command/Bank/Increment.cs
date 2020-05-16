namespace Command
{
    // Пополнение - конкретная операция
    class Increment : BankCommand
    {
        public Increment(Client client, int amount) : base(client, amount) {}
        override public void Execute()
        {
            this.client.Balance += this.amount;
        }
        override public void Undo()
        {
            System.Console.WriteLine("[undo]");
            this.client.Balance -= this.amount;
        }
        override public string ToString()
        {
            return $"[inc] : +{this.amount}";
        }
    }
}