namespace Proxy
{
    class Security : IDoor
    {
        private Door door;
        private string password;
        public Security(Door door, string password)
        {
            this.door = door;
            this.password = password;
        }
        public void Open()
        {
            if(this.password == "123")
            {
                this.door.Open();
            }
            else
            {
                System.Console.WriteLine("Password not right!");
            }            
        }
        public void Close()
        {
            this.door.Close();
        }
    }
}