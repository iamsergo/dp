namespace Command
{
    class Developer
    {
        private IDbCommand create;
        private IDbCommand delete;
        public Developer(IDbCommand create, IDbCommand delete)
        {
            this.create = create;
            this.delete = delete;
        }
        public void Create()
        {
            this.create.Execute();
        }
        public void Delete()
        {
            this.delete.Execute();
        }
    }
}