using System.Collections.Generic;

namespace Command
{
    // Получатель
    class Bank
    {
        private List<BankCommand> history;
        public Bank()
        {
            this.history = new List<BankCommand>();
        }
        public void Increment(Client client, int count)
        {
            var inc = new Increment(client, count);
            inc.Execute();
            this.history.Add(inc);
        }
        public void Decrement(Client client, int count)
        {
            var dec = new Decrement(client, count);
            dec.Execute();
            this.history.Add(dec);
        }
        public void Undo()
        {
            this.history[this.history.Count - 1].Undo();
            this.history.RemoveAt(this.history.Count - 1);
        }

        public void History()
        {
            foreach (var op in this.history)
            {
                System.Console.WriteLine(op.ToString());
            }
        }
    }
}