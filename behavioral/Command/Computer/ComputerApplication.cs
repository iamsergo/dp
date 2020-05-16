namespace Command
{
    class ComputerApplication
    {
        public void Run()
        {
            Computer pc = new Computer();

            var s = new StartCommand(pc);
            var f = new FinishCommand(pc);

            User u = new User(s , f);

            u.Start();
            u.Finish();
        }
    }
}