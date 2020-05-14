namespace Proxy
{
    class DoorApplication
    {
        public void Run()
        {
            var d = new Door();
            var p = new Security(d , "1");

            p.Open();
            p.Close();
        }
    }
}