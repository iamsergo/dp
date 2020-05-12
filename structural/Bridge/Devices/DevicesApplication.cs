namespace Bridge
{
    class DevicesApplication
    {
        public void Run()
        {
            Radio ro = new Radio();
            TV tv = new TV();

            Remote r = new Remote(ro);
            r.SetChannel(5);
            r.SetVolume(1);
            r.SetVolume(19);
        }
    }
}