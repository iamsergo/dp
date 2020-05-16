namespace Command
{
    class BankApplication
    {
        public void Run()
        {
            Bank bank = new Bank();

            Client ivan = new Client(1000);
            ivan.GetBalance();

            bank.Increment(ivan, 1000);
            bank.Decrement(ivan, 500);
            bank.Increment(ivan, 2500);         
            bank.History();
            ivan.GetBalance();

            bank.Undo();
            ivan.GetBalance();

            bank.History();
            ivan.GetBalance();
        }
    }
}