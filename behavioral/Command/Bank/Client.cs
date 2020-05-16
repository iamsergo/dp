namespace Command
{
    // Отправитель
    class Client
    {
        public int Balance { get; set; }
        public Client(int balance)
        {
            this.Balance = balance;
        }
        public void GetBalance()
        {
            System.Console.WriteLine($"[balance] : {this.Balance}\n\n");
        }
    }
}